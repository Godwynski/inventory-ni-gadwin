using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;


namespace inventory_ni_gadwin
{
    public partial class landing : Form
    {
        private int userID;

        public landing()
        {
            InitializeComponent();
        }

        // Event handler for Login button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string username = userInput.Text.Trim();
            string password = passInput.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate credentials
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                 new products().Show(); this.Hide();
                Session.userID = this.userID;
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false; // Default to false
            string connectionString = "server=localhost;database=inventory;user=root;password=;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Secure the query with parameters to prevent SQL injection
                    string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND PasswordHash = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and check the result
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = (count > 0); // True if a matching record exists
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }


        private void userInput_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation or styling
        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time validation or styling
        }
    }
}
