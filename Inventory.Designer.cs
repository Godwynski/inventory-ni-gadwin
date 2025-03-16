namespace inventory_ni_gadwin
{
    partial class Inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSettings = new Button();
            btnUserMan = new Button();
            btnReports = new Button();
            btnSupCus = new Button();
            btnStoTra = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnUserMan);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnSupCus);
            panel1.Controls.Add(btnStoTra);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 564);
            panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.LightSkyBlue;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Location = new Point(0, 306);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(183, 51);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnUserMan
            // 
            btnUserMan.BackColor = Color.LightSkyBlue;
            btnUserMan.Dock = DockStyle.Top;
            btnUserMan.Location = new Point(0, 255);
            btnUserMan.Name = "btnUserMan";
            btnUserMan.Size = new Size(183, 51);
            btnUserMan.TabIndex = 6;
            btnUserMan.Text = "User Management";
            btnUserMan.UseVisualStyleBackColor = false;
            btnUserMan.Click += btnUserMan_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.LightSkyBlue;
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 204);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(183, 51);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnSupCus
            // 
            btnSupCus.BackColor = Color.LightSkyBlue;
            btnSupCus.Dock = DockStyle.Top;
            btnSupCus.Location = new Point(0, 153);
            btnSupCus.Name = "btnSupCus";
            btnSupCus.Size = new Size(183, 51);
            btnSupCus.TabIndex = 4;
            btnSupCus.Text = "Suppliers and Customers";
            btnSupCus.UseVisualStyleBackColor = false;
            btnSupCus.Click += btnSupCus_Click;
            // 
            // btnStoTra
            // 
            btnStoTra.BackColor = Color.LightSkyBlue;
            btnStoTra.Dock = DockStyle.Top;
            btnStoTra.Location = new Point(0, 102);
            btnStoTra.Name = "btnStoTra";
            btnStoTra.Size = new Size(183, 51);
            btnStoTra.TabIndex = 3;
            btnStoTra.Text = "Stock Transactions";
            btnStoTra.UseVisualStyleBackColor = false;
            btnStoTra.Click += btnStoTra_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.LightSkyBlue;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.Location = new Point(0, 51);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(183, 51);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightSkyBlue;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(183, 51);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 54);
            panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(183, 54);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(650, 564);
            panelMain.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 188);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "This is the default shits";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 618);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            panel1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMain;
        private Button btnUserMan;
        private Button btnReports;
        private Button btnSupCus;
        private Button btnStoTra;
        private Button btnProducts;
        private Button btnSettings;
        private Button btnDashboard;
        private Label label1;
    }
}
