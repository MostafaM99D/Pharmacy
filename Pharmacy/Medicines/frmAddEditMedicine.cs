using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Medicines
{
    public partial class frmAddEditMedicine : Form
    {
        private int _MedicineID;
        private clsMedicines _Medicine;

        public delegate void DataBackHandler(int MedicineID, object sender);
        public event DataBackHandler DataBack;

        public frmAddEditMedicine(int MedicineID)
        {
            InitializeComponent();
            _MedicineID = MedicineID;

            if (MedicineID == -1)
                lblHeader.Text = "ADD NEW MEDICINE";
            else
                lblHeader.Text = $"UPDATE MEDICINE WITH [{_MedicineID}]";
        }

        private void _FillCategoryComboBox()
        {
            DataTable dt = clsCategories.GetAllCategories();
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        public void PerformLaunchData()
        {
            _FillCategoryComboBox();
            if (_MedicineID != -1)
            {
                _Medicine = clsMedicines.Find(_MedicineID);
                if (_Medicine != null)
                {
                    lblHeader.Text = $"UPDATE MEDICINE WITH [{_MedicineID}]";
                    lblMedID.Text = _MedicineID.ToString();
                    txtMedName.Text = _Medicine.MedicineName;
                    txtDescription.Text = _Medicine.Description;
                    txtDosage.Text = _Medicine.Dosage;
                    txtSalePrice.Text = _Medicine.SalePrice.ToString();
                    cbCategory.SelectedValue = _Medicine.CategoryID;
                }
                else
                {
                    MessageBox.Show("This medicine was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            else
            {
                _Medicine = new clsMedicines();
                lblMedID.Text = "N/A";
            }
        }

        private bool _Validate()
        {
            if (string.IsNullOrEmpty(txtMedName.Text.Trim()))
            {
                MessageBox.Show("Medicine Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedName.Focus();
                return false;
            }

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCategory.Focus();
                return false;
            }

            decimal salePrice;
            if (!decimal.TryParse(txtSalePrice.Text.Trim(), out salePrice))
            {
                MessageBox.Show("Sale Price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalePrice.Focus();
                return false;
            }

            if (_MedicineID==-1 && clsMedicines.IsExist(txtMedName.Text.Trim()))
            {
                MessageBox.Show("Medicine Name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedName.Focus();
                return false;
            }
            if (_MedicineID!=-1 && _Medicine.MedicineName != txtMedName.Text.Trim() && clsMedicines.IsExist(txtMedName.Text.Trim()))
            {
                MessageBox.Show("Medicine Name already exists for another medicine. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_Validate())
            {
                return;
            }

            _Medicine.MedicineName = txtMedName.Text.Trim();
            _Medicine.Description = string.IsNullOrEmpty(txtDescription.Text.Trim()) ? null : txtDescription.Text.Trim();
            _Medicine.Dosage = string.IsNullOrEmpty(txtDosage.Text.Trim()) ? null : txtDosage.Text.Trim();
            _Medicine.SalePrice = decimal.Parse(txtSalePrice.Text.Trim());
            _Medicine.CategoryID = (int)cbCategory.SelectedValue;

            try
            {
                if (_Medicine.Save())
                {
                    _MedicineID = _Medicine.MedicineID;
                    MessageBox.Show($"Medicine with ID = {_Medicine.MedicineID} saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblHeader.Text = "UPDATE MEDICINE";

                    DataBack?.Invoke(_MedicineID, this);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error during saving medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditMedicine_Load(object sender, EventArgs e)
        {
            PerformLaunchData();
        }
    }
}
