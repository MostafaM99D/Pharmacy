using BLL;
using Pharmacy.Medicines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.HelperCtrls
{
    public partial class ctrlMedicineDetailsWithFilter : UserControl
    {
        public int MedicineID;
        private clsMedicines _Medicine;
        public bool IsSelectedMedicine = false;

        public ctrlMedicineDetailsWithFilter()
        {
            InitializeComponent();
        }

        public void LoadMedicine(int MedicineID)
        {
            _Medicine = clsMedicines.Find(MedicineID);
            if (_Medicine != null)
            {
                this.MedicineID = MedicineID;
                IsSelectedMedicine = true;
                txtSearch.Text = MedicineID.ToString();

                lblMedicineName.Text=_Medicine.MedicineName;
                lblDescription.Text = _Medicine.Description;
                lblSalePrice.Text=_Medicine.SalePrice.ToString();
                lblCategoryName.Text = _Medicine.CategoryInfo.CategoryName;
                lblDosage.Text=_Medicine.Dosage;

            }
            else
            {
                MessageBox.Show("Medicine not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMedicineName.Text = "????";
                lblDescription.Text = "????";
                lblSalePrice.Text = "????";
                lblCategoryName.Text = "????";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Medicine ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadMedicine(Convert.ToInt32(txtSearch.Text));
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnAddNewMedicine_Click(object sender, EventArgs e)
        {
            frmAddEditMedicine frm = new frmAddEditMedicine(-1);
            frm.DataBack += _OnDataBack;
            frm.ShowDialog();
        }

        private void _OnDataBack(int MedicineID, object sender)
        {
            this.MedicineID = MedicineID;
            LoadMedicine(MedicineID);
        }

        private void ctrlMedicineDetailsWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
