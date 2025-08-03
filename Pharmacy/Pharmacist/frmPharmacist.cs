using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Pharmacist
{
    public partial class frmPharmacist : Form
    {
        public frmPharmacist()
        {
            InitializeComponent();
        }

        private void frmPharmacist_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = clsGlobal.CurrentUser.PersonInfo.FirstName + " " + clsGlobal.CurrentUser.PersonInfo.LastName;
            ctrlPharmacistDashboard1.Visible = false;
            ctrlViewMedicines1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ctrlPharmacistDashboard1.Visible=true;
            ctrlPharmacistDashboard1.BringToFront();
            ctrlPharmacistDashboard1.LoadData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ctrlViewMedicines1.Visible = true;
            ctrlViewMedicines1.BringToFront();
            ctrlViewMedicines1.LoadData();
        }
    }
}
