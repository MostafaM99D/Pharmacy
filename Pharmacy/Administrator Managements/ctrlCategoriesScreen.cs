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
    public partial class ctrlCategoriesScreen : UserControl
    {
        private DataTable _dtCategories;

        public ctrlCategoriesScreen()
        {
            InitializeComponent();
            dgvList.CellContentClick += DgvList_CellContentClick;
        }

        private void _FillDgv()
        {
            dgvList.Columns.Clear();

            _dtCategories = clsCategories.GetAllCategories();
            dgvList.DataSource = _dtCategories;

            if (dgvList.Rows.Count > 0)
            {
                dgvList.ColumnHeadersHeight = 50;
                dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                dgvList.Columns[0].HeaderText = "Category ID";
                dgvList.Columns[0].Width = 30;

                dgvList.Columns[1].HeaderText = "Category Name";
                dgvList.Columns[1].Width = 400;

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
                int categoryID = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["CategoryID"].Value);

                frmAddEditCategory f = new frmAddEditCategory(categoryID);
                f.ShowDialog();

                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                _dtCategories.DefaultView.RowFilter = "";
            }
            else
            {
                string FilterColumn = "CategoryName";
                _dtCategories.DefaultView.RowFilter = string.Format($"[{FilterColumn}] LIKE '%{filterText}%'");
            }
             clsGlobal.WidthCorrector(dgvList, 30);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditCategory f = new frmAddEditCategory(-1);
            f.ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index < 0 || !dgvList.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a category to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedCategoryID;
            if (dgvList.CurrentRow.Cells["CategoryID"].Value == DBNull.Value || !int.TryParse(dgvList.CurrentRow.Cells["CategoryID"].Value.ToString(), out selectedCategoryID))
            {
                MessageBox.Show("Could not retrieve Category ID from selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (clsMedicines.IsCategoryLinkedToMedicines(selectedCategoryID))
            //{
            //    MessageBox.Show("Cannot delete this category as it is linked to existing medicines. Please reassign medicines before deleting the category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (MessageBox.Show($"Are you sure you want to delete this category with ID = {selectedCategoryID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsCategories.DeleteByID(selectedCategoryID))
                    {
                        MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error during category deletion. Please check logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ctrlCategoriesScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
