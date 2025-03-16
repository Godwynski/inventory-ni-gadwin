namespace inventory_ni_gadwin
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void LoadForm(Form form)
        {
            panelMain.Controls.Clear(); // Clear previous form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new dashboard());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            LoadForm(new products());
        }

        private void btnStoTra_Click(object sender, EventArgs e)
        {
            LoadForm(new stocktransactions());
        }

        private void btnSupCus_Click(object sender, EventArgs e)
        {
            LoadForm(new suppliersandcustomers());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new reports());
        }

        private void btnUserMan_Click(object sender, EventArgs e)
        {
            LoadForm(new usermanagement());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new settings());
        }
    }
}
