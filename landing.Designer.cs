namespace inventory_ni_gadwin
{
    partial class landing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            userInput = new TextBox();
            label2 = new Label();
            passInput = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 240, 240);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 658);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(userInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passInput);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(327, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 300);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // userInput
            // 
            userInput.BorderStyle = BorderStyle.FixedSingle;
            userInput.Font = new Font("Segoe UI", 10F);
            userInput.Location = new Point(30, 60);
            userInput.Name = "userInput";
            userInput.Size = new Size(280, 25);
            userInput.TabIndex = 1;
            userInput.TextChanged += userInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 110);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // passInput
            // 
            passInput.BorderStyle = BorderStyle.FixedSingle;
            passInput.Font = new Font("Segoe UI", 10F);
            passInput.Location = new Point(30, 140);
            passInput.Name = "passInput";
            passInput.PasswordChar = '●';
            passInput.Size = new Size(280, 25);
            passInput.TabIndex = 3;
            passInput.TextChanged += passInput_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 150, 250);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 200);
            button1.Name = "button1";
            button1.Size = new Size(280, 40);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // landing
            // 
            ClientSize = new Size(1136, 658);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox passInput;
        private TextBox userInput;
        private Label label1;
        private Label label2;


    }
}