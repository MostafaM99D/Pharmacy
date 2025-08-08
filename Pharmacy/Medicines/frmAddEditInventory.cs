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
    public partial class frmAddEditInventory : Form
    {
       
        private int _InventoryID;
        private clsMedicineInventories _Inventory;

        public frmAddEditInventory(int InventoryID)
        {
            InitializeComponent();
            _InventoryID = InventoryID;

            if (InventoryID == -1)
                lblHeader.Text = "ADD NEW INVENTORY BATCH";
            else
                lblHeader.Text = $"UPDATING INVENTORY WITH [{_InventoryID}]";
        }

        public void LoadInventoryInfo()
        {
            if (_InventoryID != -1)
            {
                _Inventory = clsMedicineInventories.Find(_InventoryID);
                if (_Inventory != null)
                {
                    ctrlMedicineDetailsWithFilter1.LoadMedicine(_Inventory.MedicineID);
                    gbInventoryDetails.Enabled = true;
                    gbMedicineDetails.Enabled = false;

                    lblInventoryID.Text = _InventoryID.ToString();
                    txtQuantity.Text = _Inventory.Quantity.ToString();
                    dtpExpirationDate.Value = _Inventory.ExpirationDate;
                    txtPurchasePrice.Text = _Inventory.PurchasePrice.ToString();
                }
                else
                {
                    MessageBox.Show("This inventory record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                gbMedicineDetails.Enabled = true;
                gbInventoryDetails.Enabled = false;
                _Inventory = new clsMedicineInventories();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ctrlMedicineDetailsWithFilter1.IsSelectedMedicine)
            {
                MessageBox.Show("Please select a medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbInventoryDetails.Enabled = true;
            gbMedicineDetails.Enabled = false;
            btnNext.Visible = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditMedicineInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryInfo();
        }

        private bool _IsValidInputs()
        {
            if (!ctrlMedicineDetailsWithFilter1.IsSelectedMedicine)
            {
                MessageBox.Show("Please select a medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int quantity;
            if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpExpirationDate.Value <= DateTime.Now.Date)
            {
                MessageBox.Show("Expiration date must be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal purchasePrice;
            if (!decimal.TryParse(txtPurchasePrice.Text, out purchasePrice) || purchasePrice < 0)
            {
                MessageBox.Show("Purchase price must be a valid non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidInputs())
            {
                return;
            }

            _Inventory.MedicineID = ctrlMedicineDetailsWithFilter1.MedicineID;
            _Inventory.Quantity = int.Parse(txtQuantity.Text);
            _Inventory.ExpirationDate = dtpExpirationDate.Value;
            _Inventory.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);

            try
            {
                if (_Inventory.Save())
                {
                    _InventoryID = _Inventory.MedInventoryID;
                    MessageBox.Show($"Inventory record with ID [{_InventoryID}] saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblHeader.Text = $"UPDATING INVENTORY WITH [{_InventoryID}]";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the inventory record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            
        }
    }
}
