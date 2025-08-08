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

namespace Pharmacy.Administrator_Managements
{
    public partial class ctrlMedicinesScreen : UserControl
    {
        private DataTable _dtMedicinesInventory; 

        public ctrlMedicinesScreen()
        {
            InitializeComponent();
            dgvList.CellContentClick += DgvList_CellContentClick;
        }

        private void _FillDgv()
        {
            dgvList.Columns.Clear(); 

            _dtMedicinesInventory = clsMedicines.GetAllMedicines();
            dgvList.DataSource = _dtMedicinesInventory; 

            if (dgvList.Rows.Count > 0)
            {
                dgvList.ColumnHeadersHeight = 50;
                dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                dgvList.Columns["MedicineID"].HeaderText = "Medicine ID";
                dgvList.Columns["MedicineID"].Width = 60;

                dgvList.Columns["MedicineName"].HeaderText = "Medicine Name";
                dgvList.Columns["MedicineName"].Width = 150;

                dgvList.Columns["CategoryName"].HeaderText = "Category";
                dgvList.Columns["CategoryName"].Width = 100;

                dgvList.Columns["Description"].HeaderText = "Description";
                dgvList.Columns["Description"].Width = 200;

                dgvList.Columns["Dosage"].HeaderText = "Dosage";
                dgvList.Columns["Dosage"].Width = 80;

                dgvList.Columns["SalePrice"].HeaderText = "Sale Price";
                dgvList.Columns["SalePrice"].Width = 80;

                dgvList.Columns["MedInventoryID"].HeaderText = "Inv ID";
                dgvList.Columns["MedInventoryID"].Width = 50;

                dgvList.Columns["Quantity"].HeaderText = "Quantity";
                dgvList.Columns["Quantity"].Width = 60;

                dgvList.Columns["ExpirationDate"].HeaderText = "Expiry Date";
                dgvList.Columns["ExpirationDate"].Width = 100;

                dgvList.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                dgvList.Columns["PurchasePrice"].Width = 90;

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "EditColumn";
                editButtonColumn.HeaderText = "";
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.Width = 50;
                dgvList.Columns.Add(editButtonColumn);

                clsGlobal.WidthCorrector(dgvList, 30);
            }
        }

        public void LoadData()
        {
            _FillDgv();
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "EditColumn" && e.RowIndex >= 0)
            {
                int medicineID = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["MedicineID"].Value);

                frmAddEditMedicine f = new frmAddEditMedicine(medicineID);
                f.ShowDialog();

                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                _dtMedicinesInventory.DefaultView.RowFilter = "";
            }
            else
            {
                string FilterColumn = "MedicineName";
                _dtMedicinesInventory.DefaultView.RowFilter = string.Format($"[{FilterColumn}] LIKE '%{filterText}%'");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
          frmAddEditMedicine f = new frmAddEditMedicine(-1);
          f.ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index < 0 || !dgvList.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a medicine to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedMedicineID;
            if (dgvList.CurrentRow.Cells["MedicineID"].Value == DBNull.Value || !int.TryParse(dgvList.CurrentRow.Cells["MedicineID"].Value.ToString(), out selectedMedicineID))
            {
                MessageBox.Show("Could not retrieve Medicine ID from selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (clsMedicines.IsMedicineLinked(selectedMedicineID)) 
            //{
            //    MessageBox.Show("Cannot delete this medicine as it is linked to existing orders or purchases. You can only delete the inventory record.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (MessageBox.Show($"Are you sure you want to delete this medicine with ID = {selectedMedicineID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsMedicines.DeleteByID(selectedMedicineID)) 
                    {
                        MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error during medicine deletion. Please check logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ctrlMedicinesScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddEditInventory f=new frmAddEditInventory(-1);
            f.ShowDialog();
            LoadData();
        }
    }
}
