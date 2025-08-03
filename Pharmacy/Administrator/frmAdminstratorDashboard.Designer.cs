namespace Pharmacy.Administrator
{
    partial class frmAdminstratorDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlOrdersManagement1 = new Pharmacy.Administrator_Managements.ctrlOrdersManagement();
            this.ctrlCustomersScreen1 = new Pharmacy.Administrator_Managements.ctrlCustomersScreen();
            this.ctrlPurchasesScreen1 = new Pharmacy.Administrator_Managements.ctrlPurchasesScreen();
            this.ctrlSuppliersScreen1 = new Pharmacy.Administrator_Managements.ctrlSuppliersScreen();
            this.ctrlMedicinesScreen1 = new Pharmacy.Administrator_Managements.ctrlMedicinesScreen();
            this.ctrlCategoriesScreen1 = new Pharmacy.Administrator_Managements.ctrlCategoriesScreen();
            this.ctrlUsersScreen1 = new Pharmacy.Administrator.ctrlUsersScreen();
            this.ctrlRolesScreen1 = new Pharmacy.Administrator_Managements.ctrlRolesScreen();
            this.ctrlPeopleScreen1 = new Pharmacy.Administrator_Managements.ctrlPeopleScreen();
            this.ctrlDashboard1 = new Pharmacy.Administrator.ctrlDashboard();
            this.btnPeopleManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdersManagemrnt = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomersManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchasesManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuppliersManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicinesManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsersManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoriesManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnRolesManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctrlReportsScreen1 = new Pharmacy.Administrator_Managements.ctrlReportsScreen();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnPeopleManagement);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnOrdersManagemrnt);
            this.panel1.Controls.Add(this.btnCustomersManagement);
            this.panel1.Controls.Add(this.btnPurchasesManagement);
            this.panel1.Controls.Add(this.btnSuppliersManagement);
            this.panel1.Controls.Add(this.btnMedicinesManagement);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.btnUsersManagement);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnCategoriesManagement);
            this.panel1.Controls.Add(this.btnRolesManagement);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 1080);
            this.panel1.TabIndex = 0;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(63, 1040);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(207, 40);
            this.lblAdminName.TabIndex = 9;
            this.lblAdminName.Text = "Admin Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(86, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrators";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlReportsScreen1);
            this.panel2.Controls.Add(this.ctrlOrdersManagement1);
            this.panel2.Controls.Add(this.ctrlCustomersScreen1);
            this.panel2.Controls.Add(this.ctrlPurchasesScreen1);
            this.panel2.Controls.Add(this.ctrlSuppliersScreen1);
            this.panel2.Controls.Add(this.ctrlMedicinesScreen1);
            this.panel2.Controls.Add(this.ctrlCategoriesScreen1);
            this.panel2.Controls.Add(this.ctrlUsersScreen1);
            this.panel2.Controls.Add(this.ctrlRolesScreen1);
            this.panel2.Controls.Add(this.ctrlPeopleScreen1);
            this.panel2.Controls.Add(this.ctrlDashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(430, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1490, 1080);
            this.panel2.TabIndex = 1;
            // 
            // ctrlOrdersManagement1
            // 
            this.ctrlOrdersManagement1.BackColor = System.Drawing.Color.White;
            this.ctrlOrdersManagement1.Location = new System.Drawing.Point(0, 0);
            this.ctrlOrdersManagement1.Name = "ctrlOrdersManagement1";
            this.ctrlOrdersManagement1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlOrdersManagement1.TabIndex = 9;
            // 
            // ctrlCustomersScreen1
            // 
            this.ctrlCustomersScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomersScreen1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCustomersScreen1.Name = "ctrlCustomersScreen1";
            this.ctrlCustomersScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlCustomersScreen1.TabIndex = 8;
            // 
            // ctrlPurchasesScreen1
            // 
            this.ctrlPurchasesScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlPurchasesScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlPurchasesScreen1.Name = "ctrlPurchasesScreen1";
            this.ctrlPurchasesScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlPurchasesScreen1.TabIndex = 7;
            // 
            // ctrlSuppliersScreen1
            // 
            this.ctrlSuppliersScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlSuppliersScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlSuppliersScreen1.Name = "ctrlSuppliersScreen1";
            this.ctrlSuppliersScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlSuppliersScreen1.TabIndex = 6;
            // 
            // ctrlMedicinesScreen1
            // 
            this.ctrlMedicinesScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlMedicinesScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlMedicinesScreen1.Name = "ctrlMedicinesScreen1";
            this.ctrlMedicinesScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlMedicinesScreen1.TabIndex = 5;
            // 
            // ctrlCategoriesScreen1
            // 
            this.ctrlCategoriesScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlCategoriesScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlCategoriesScreen1.Name = "ctrlCategoriesScreen1";
            this.ctrlCategoriesScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlCategoriesScreen1.TabIndex = 4;
            // 
            // ctrlUsersScreen1
            // 
            this.ctrlUsersScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlUsersScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlUsersScreen1.Name = "ctrlUsersScreen1";
            this.ctrlUsersScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlUsersScreen1.TabIndex = 3;
            // 
            // ctrlRolesScreen1
            // 
            this.ctrlRolesScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlRolesScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlRolesScreen1.Name = "ctrlRolesScreen1";
            this.ctrlRolesScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlRolesScreen1.TabIndex = 2;
            // 
            // ctrlPeopleScreen1
            // 
            this.ctrlPeopleScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlPeopleScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlPeopleScreen1.Name = "ctrlPeopleScreen1";
            this.ctrlPeopleScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlPeopleScreen1.TabIndex = 1;
            // 
            // ctrlDashboard1
            // 
            this.ctrlDashboard1.BackColor = System.Drawing.Color.White;
            this.ctrlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDashboard1.Name = "ctrlDashboard1";
            this.ctrlDashboard1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlDashboard1.TabIndex = 0;
            // 
            // btnPeopleManagement
            // 
            this.btnPeopleManagement.BorderRadius = 20;
            this.btnPeopleManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPeopleManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPeopleManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPeopleManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeopleManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeopleManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeopleManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeopleManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPeopleManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleManagement.ForeColor = System.Drawing.Color.White;
            this.btnPeopleManagement.Image = global::Pharmacy.Properties.Resources.people;
            this.btnPeopleManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeopleManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPeopleManagement.Location = new System.Drawing.Point(3, 319);
            this.btnPeopleManagement.Name = "btnPeopleManagement";
            this.btnPeopleManagement.Size = new System.Drawing.Size(418, 62);
            this.btnPeopleManagement.TabIndex = 16;
            this.btnPeopleManagement.Text = "People Managment";
            this.btnPeopleManagement.Click += new System.EventHandler(this.btnPeopleManagement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BorderRadius = 20;
            this.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReports.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::Pharmacy.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReports.Location = new System.Drawing.Point(3, 895);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(418, 62);
            this.btnReports.TabIndex = 15;
            this.btnReports.Text = "Reports ";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnOrdersManagemrnt
            // 
            this.btnOrdersManagemrnt.BorderRadius = 20;
            this.btnOrdersManagemrnt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrdersManagemrnt.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrdersManagemrnt.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnOrdersManagemrnt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdersManagemrnt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdersManagemrnt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdersManagemrnt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdersManagemrnt.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdersManagemrnt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersManagemrnt.ForeColor = System.Drawing.Color.White;
            this.btnOrdersManagemrnt.Image = global::Pharmacy.Properties.Resources.infrastructure;
            this.btnOrdersManagemrnt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrdersManagemrnt.ImageSize = new System.Drawing.Size(50, 50);
            this.btnOrdersManagemrnt.Location = new System.Drawing.Point(6, 831);
            this.btnOrdersManagemrnt.Name = "btnOrdersManagemrnt";
            this.btnOrdersManagemrnt.Size = new System.Drawing.Size(418, 62);
            this.btnOrdersManagemrnt.TabIndex = 14;
            this.btnOrdersManagemrnt.Text = "Orders Management";
            this.btnOrdersManagemrnt.Click += new System.EventHandler(this.btnOrdersManagemrnt_Click);
            // 
            // btnCustomersManagement
            // 
            this.btnCustomersManagement.BorderRadius = 20;
            this.btnCustomersManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomersManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomersManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomersManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomersManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomersManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomersManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomersManagement.ForeColor = System.Drawing.Color.White;
            this.btnCustomersManagement.Image = global::Pharmacy.Properties.Resources.public_service;
            this.btnCustomersManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomersManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCustomersManagement.Location = new System.Drawing.Point(3, 767);
            this.btnCustomersManagement.Name = "btnCustomersManagement";
            this.btnCustomersManagement.Size = new System.Drawing.Size(418, 62);
            this.btnCustomersManagement.TabIndex = 13;
            this.btnCustomersManagement.Text = "Customers Management";
            this.btnCustomersManagement.Click += new System.EventHandler(this.btnCustomersManagement_Click);
            // 
            // btnPurchasesManagement
            // 
            this.btnPurchasesManagement.BorderRadius = 20;
            this.btnPurchasesManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPurchasesManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPurchasesManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPurchasesManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasesManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasesManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchasesManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchasesManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPurchasesManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasesManagement.ForeColor = System.Drawing.Color.White;
            this.btnPurchasesManagement.Image = global::Pharmacy.Properties.Resources.customer;
            this.btnPurchasesManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchasesManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPurchasesManagement.Location = new System.Drawing.Point(3, 703);
            this.btnPurchasesManagement.Name = "btnPurchasesManagement";
            this.btnPurchasesManagement.Size = new System.Drawing.Size(418, 62);
            this.btnPurchasesManagement.TabIndex = 12;
            this.btnPurchasesManagement.Text = "Purchases Management";
            this.btnPurchasesManagement.Click += new System.EventHandler(this.btnPurchasesManagement_Click);
            // 
            // btnSuppliersManagement
            // 
            this.btnSuppliersManagement.BorderRadius = 20;
            this.btnSuppliersManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSuppliersManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSuppliersManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSuppliersManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppliersManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppliersManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuppliersManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuppliersManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSuppliersManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliersManagement.ForeColor = System.Drawing.Color.White;
            this.btnSuppliersManagement.Image = global::Pharmacy.Properties.Resources.supplier;
            this.btnSuppliersManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuppliersManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSuppliersManagement.Location = new System.Drawing.Point(3, 639);
            this.btnSuppliersManagement.Name = "btnSuppliersManagement";
            this.btnSuppliersManagement.Size = new System.Drawing.Size(418, 62);
            this.btnSuppliersManagement.TabIndex = 11;
            this.btnSuppliersManagement.Text = "Suppliers Management";
            this.btnSuppliersManagement.Click += new System.EventHandler(this.btnSuppliersManagement_Click);
            // 
            // btnMedicinesManagement
            // 
            this.btnMedicinesManagement.BorderRadius = 20;
            this.btnMedicinesManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicinesManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicinesManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedicinesManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicinesManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicinesManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicinesManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicinesManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnMedicinesManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicinesManagement.ForeColor = System.Drawing.Color.White;
            this.btnMedicinesManagement.Image = global::Pharmacy.Properties.Resources.syringe__1_;
            this.btnMedicinesManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicinesManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMedicinesManagement.Location = new System.Drawing.Point(3, 575);
            this.btnMedicinesManagement.Name = "btnMedicinesManagement";
            this.btnMedicinesManagement.Size = new System.Drawing.Size(418, 62);
            this.btnMedicinesManagement.TabIndex = 10;
            this.btnMedicinesManagement.Text = "Medicines Management";
            this.btnMedicinesManagement.Click += new System.EventHandler(this.btnMedicinesManagement_Click);
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.BorderRadius = 20;
            this.btnUsersManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsersManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsersManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUsersManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsersManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsersManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnUsersManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagement.ForeColor = System.Drawing.Color.White;
            this.btnUsersManagement.Image = global::Pharmacy.Properties.Resources.management;
            this.btnUsersManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsersManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUsersManagement.Location = new System.Drawing.Point(3, 447);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.Size = new System.Drawing.Size(418, 62);
            this.btnUsersManagement.TabIndex = 8;
            this.btnUsersManagement.Text = "Users Management";
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
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
            this.btnLogOut.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Pharmacy.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(3, 959);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(418, 62);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCategoriesManagement
            // 
            this.btnCategoriesManagement.BorderRadius = 20;
            this.btnCategoriesManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategoriesManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCategoriesManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCategoriesManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoriesManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoriesManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategoriesManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategoriesManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCategoriesManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriesManagement.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesManagement.Image = global::Pharmacy.Properties.Resources.medicine__1_;
            this.btnCategoriesManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategoriesManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCategoriesManagement.Location = new System.Drawing.Point(3, 511);
            this.btnCategoriesManagement.Name = "btnCategoriesManagement";
            this.btnCategoriesManagement.Size = new System.Drawing.Size(418, 62);
            this.btnCategoriesManagement.TabIndex = 5;
            this.btnCategoriesManagement.Text = "Categories Management";
            this.btnCategoriesManagement.Click += new System.EventHandler(this.btnCategoriesManagement_Click);
            // 
            // btnRolesManagement
            // 
            this.btnRolesManagement.BorderRadius = 20;
            this.btnRolesManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRolesManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRolesManagement.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnRolesManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRolesManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRolesManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRolesManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRolesManagement.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnRolesManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolesManagement.ForeColor = System.Drawing.Color.White;
            this.btnRolesManagement.Image = global::Pharmacy.Properties.Resources.project_manager;
            this.btnRolesManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRolesManagement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnRolesManagement.Location = new System.Drawing.Point(0, 383);
            this.btnRolesManagement.Name = "btnRolesManagement";
            this.btnRolesManagement.Size = new System.Drawing.Size(418, 62);
            this.btnRolesManagement.TabIndex = 4;
            this.btnRolesManagement.Text = "Roles Management";
            this.btnRolesManagement.Click += new System.EventHandler(this.btnRolesManagement_Click);
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
            this.btnDashboard.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Pharmacy.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDashboard.Location = new System.Drawing.Point(3, 251);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(418, 62);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Pharmacy.Properties.Resources.administrator;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(53, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 193);
            this.panel3.TabIndex = 0;
            // 
            // ctrlReportsScreen1
            // 
            this.ctrlReportsScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlReportsScreen1.Location = new System.Drawing.Point(-3, 0);
            this.ctrlReportsScreen1.Name = "ctrlReportsScreen1";
            this.ctrlReportsScreen1.Size = new System.Drawing.Size(1490, 1080);
            this.ctrlReportsScreen1.TabIndex = 10;
            // 
            // frmAdminstratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminstratorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminstratorDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminstratorDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnCategoriesManagement;
        private Guna.UI2.WinForms.Guna2Button btnRolesManagement;
        private ctrlDashboard ctrlDashboard1;
        private Guna.UI2.WinForms.Guna2Button btnUsersManagement;
        private System.Windows.Forms.Label lblAdminName;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnOrdersManagemrnt;
        private Guna.UI2.WinForms.Guna2Button btnCustomersManagement;
        private Guna.UI2.WinForms.Guna2Button btnPurchasesManagement;
        private Guna.UI2.WinForms.Guna2Button btnSuppliersManagement;
        private Guna.UI2.WinForms.Guna2Button btnMedicinesManagement;
        private Guna.UI2.WinForms.Guna2Button btnPeopleManagement;
        private Administrator_Managements.ctrlPeopleScreen ctrlPeopleScreen1;
        private Administrator_Managements.ctrlRolesScreen ctrlRolesScreen1;
        private ctrlUsersScreen ctrlUsersScreen1;
        private Administrator_Managements.ctrlCategoriesScreen ctrlCategoriesScreen1;
        private Administrator_Managements.ctrlMedicinesScreen ctrlMedicinesScreen1;
        private Administrator_Managements.ctrlSuppliersScreen ctrlSuppliersScreen1;
        private Administrator_Managements.ctrlPurchasesScreen ctrlPurchasesScreen1;
        private Administrator_Managements.ctrlCustomersScreen ctrlCustomersScreen1;
        private Administrator_Managements.ctrlOrdersManagement ctrlOrdersManagement1;
        private Administrator_Managements.ctrlReportsScreen ctrlReportsScreen1;
    }
}