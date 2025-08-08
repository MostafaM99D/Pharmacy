using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Administrator
{
    public partial class frmAdminstratorDashboard : Form
    {
        public frmAdminstratorDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminstratorDashboard_Load(object sender, EventArgs e)
        {

            lblAdminName.Text = clsGlobal.CurrentUser.PersonInfo.FirstName + " " + clsGlobal.CurrentUser.PersonInfo.LastName;
            ctrlDashboard1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ctrlDashboard1.Visible = true;
            ctrlDashboard1.BringToFront();
            ctrlDashboard1.LoadData();
        }

        private void btnPeopleManagement_Click(object sender, EventArgs e)
        {
            ctrlPeopleScreen1.Visible = true;
            ctrlPeopleScreen1.BringToFront();
            ctrlPeopleScreen1.LoadData();
        }

        private void btnRolesManagement_Click(object sender, EventArgs e)
        {
           ctrlRolesScreen1.Visible = true;
           ctrlRolesScreen1.BringToFront();
            ctrlRolesScreen1.LoadData();
            // continue
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            ctrlUsersScreen1.Visible = true;
            ctrlUsersScreen1.BringToFront();
            ctrlUsersScreen1.LoadData();
        }

        private void btnCategoriesManagement_Click(object sender, EventArgs e)
        {
            ctrlCategoriesScreen1.Visible = true;
            ctrlCategoriesScreen1.BringToFront();
            ctrlCategoriesScreen1.LoadData();

        }

        private void btnMedicinesManagement_Click(object sender, EventArgs e)
        {
            ctrlMedicinesScreen1.Visible = true;
            ctrlMedicinesScreen1.BringToFront();
            ctrlMedicinesScreen1.LoadData();
        }

        private void btnSuppliersManagement_Click(object sender, EventArgs e)
        {
            ctrlSuppliersScreen1.Visible = true;
            ctrlSuppliersScreen1.BringToFront();
        }

        private void btnPurchasesManagement_Click(object sender, EventArgs e)
        {
            ctrlPurchasesScreen1.Visible = true;
            ctrlPurchasesScreen1.BringToFront();
        }

        private void btnCustomersManagement_Click(object sender, EventArgs e)
        {
            ctrlCustomersScreen1.Visible = true;
            ctrlCustomersScreen1.BringToFront();
        }

        private void btnOrdersManagemrnt_Click(object sender, EventArgs e)
        {
            ctrlOrdersManagement1.Visible = true;
            ctrlOrdersManagement1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ctrlReportsScreen1.Visible = true;
            ctrlReportsScreen1.BringToFront();
        }
    }
}
