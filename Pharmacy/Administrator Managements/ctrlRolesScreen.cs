using BLL;
using Pharmacy.Role;
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
    public partial class ctrlRolesScreen : UserControl
    {

        private DataTable _dtRoles;

        public ctrlRolesScreen()
        {
            InitializeComponent();
            dgvList.CellContentClick += DgvList_CellContentClick;

        }



        private void _FillDgv()
        {
            dgvList.Columns.Clear();

            _dtRoles = clsRoles.GetAllRoles();
            dgvList.DataSource = _dtRoles;

            if (dgvList.Rows.Count > 0)
            {
                dgvList.ColumnHeadersHeight = 50;
                dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                dgvList.Columns["RoleID"].HeaderText = "Role ID";
                dgvList.Columns["RoleID"].Width = 50;

                dgvList.Columns["RoleName"].HeaderText = "Role Name";
                dgvList.Columns["RoleName"].Width = 250;

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
                int roleID = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["RoleID"].Value);

                frmAddEditRole f = new frmAddEditRole(roleID);
                f.ShowDialog();

                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                _dtRoles.DefaultView.RowFilter = "";
            }
            else
            {
                string FilterColumn = "RoleName";
                _dtRoles.DefaultView.RowFilter = string.Format($"[{FilterColumn}] LIKE '%{filterText}%'");
            }
             clsGlobal.WidthCorrector(dgvList, 30);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditRole f = new frmAddEditRole(-1);
            f.ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index < 0 || !dgvList.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a role to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRoleID;
            if (dgvList.CurrentRow.Cells["RoleID"].Value == DBNull.Value || !int.TryParse(dgvList.CurrentRow.Cells["RoleID"].Value.ToString(), out selectedRoleID))
            {
                MessageBox.Show("Could not retrieve Role ID from selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (clsUsers.IsRoleLinkedToUsers(selectedRoleID))
            //{
            //    MessageBox.Show("Cannot delete this role as it is linked to existing users. Please reassign users before deleting the role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (MessageBox.Show($"Are you sure you want to delete this role with ID = {selectedRoleID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsRoles.DeleteByID(selectedRoleID))
                    {
                        MessageBox.Show("Role deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error during role deletion. Please check logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ctrlViewRoles_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
