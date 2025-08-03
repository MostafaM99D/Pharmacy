namespace Pharmacy.Pharmacist
{
    partial class frmPharmacist
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPharmacistDashboard1 = new Pharmacy.Pharmacist.ctrlPharmacistDashboard();
            this.ctrlViewMedicines1 = new Pharmacy.Pharmacist.ctrlViewMedicines();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 1041);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pharmacist";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(114, 992);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(207, 40);
            this.lblAdminName.TabIndex = 15;
            this.lblAdminName.Text = "Admin Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlViewMedicines1);
            this.panel2.Controls.Add(this.ctrlPharmacistDashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(436, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1468, 1041);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Pharmacy.Properties.Resources.medical_book;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(59, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 258);
            this.panel3.TabIndex = 18;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Blue;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Pharmacy.Properties.Resources.sell;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(7, 818);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(418, 62);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "Sell Medicine";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Pharmacy.Properties.Resources.syringe;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(7, 734);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(418, 62);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Medicine Validity Check";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BorderRadius = 20;
            this.btnUpdateUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = global::Pharmacy.Properties.Resources.visualisation;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateUser.Location = new System.Drawing.Point(7, 482);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(418, 62);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "View Medicines";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 20;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Blue;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Pharmacy.Properties.Resources.exit;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(7, 902);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(418, 62);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BorderRadius = 20;
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewUser.FillColor = System.Drawing.Color.Blue;
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = global::Pharmacy.Properties.Resources.search;
            this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(7, 650);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(418, 62);
            this.btnViewUser.TabIndex = 12;
            this.btnViewUser.Text = "Modify Medicine";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BorderRadius = 20;
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.Blue;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::Pharmacy.Properties.Resources.medicine;
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(7, 566);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(418, 62);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add Medicine";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 20;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Blue;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Pharmacy.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(7, 398);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(418, 62);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // ctrlPharmacistDashboard1
            // 
            this.ctrlPharmacistDashboard1.BackColor = System.Drawing.Color.White;
            this.ctrlPharmacistDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPharmacistDashboard1.Name = "ctrlPharmacistDashboard1";
            this.ctrlPharmacistDashboard1.Size = new System.Drawing.Size(1474, 1080);
            this.ctrlPharmacistDashboard1.TabIndex = 0;
            // 
            // ctrlViewMedicines1
            // 
            this.ctrlViewMedicines1.BackColor = System.Drawing.Color.White;
            this.ctrlViewMedicines1.Location = new System.Drawing.Point(-6, 0);
            this.ctrlViewMedicines1.Name = "ctrlViewMedicines1";
            this.ctrlViewMedicines1.Size = new System.Drawing.Size(1474, 1080);
            this.ctrlViewMedicines1.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.ctrlViewMedicines1;
            // 
            // frmPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPharmacist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdminName;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ctrlPharmacistDashboard ctrlPharmacistDashboard1;
        private ctrlViewMedicines ctrlViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}