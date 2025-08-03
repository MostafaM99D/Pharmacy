using BLL;
using Pharmacy.People;
using Pharmacy.Users;
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
    public partial class ctrlUsersScreen : UserControl
    {
        public ctrlUsersScreen()
        {
            InitializeComponent();
            dgvUsersList.CellContentClick += DgvUsersList_CellContentClick;
        }

        private void DgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvUsersList.Columns[e.ColumnIndex].Name == "EditColumn" && e.RowIndex >= 0)
            {
                int UserID = Convert.ToInt32(dgvUsersList.Rows[e.RowIndex].Cells["UserID"].Value);

                frmAddEditUser f = new frmAddEditUser(UserID);
                f.ShowDialog();
                LoadData();
            }
        }

        private DataTable _dtUsers;

        private void _FillDgv()
        {
            dgvUsersList.Columns.Clear();

            _dtUsers = clsUsers.GetAllUsers();
            dgvUsersList.DataSource = _dtUsers;

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.ColumnHeadersHeight = 50;
                dgvUsersList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvUsersList.DefaultCellStyle.Font = new Font("Segoe UI", 11);

                dgvUsersList.Columns["UserID"].HeaderText = "User ID";
                dgvUsersList.Columns["UserID"].Width = 60;

                dgvUsersList.Columns["PersonID"].HeaderText = "Person ID";
                dgvUsersList.Columns["PersonID"].Width = 60;

                dgvUsersList.Columns["Name"].HeaderText = "Full Name";
                dgvUsersList.Columns["Name"].Width = 180;

                dgvUsersList.Columns["Email"].HeaderText = "Email";
                dgvUsersList.Columns["Email"].Width = 200;

                dgvUsersList.Columns["Username"].HeaderText = "Username";
                dgvUsersList.Columns["Username"].Width = 140;

                dgvUsersList.Columns["Password"].Visible = false;

                dgvUsersList.Columns["IsActive"].HeaderText = "Active";
                dgvUsersList.Columns["IsActive"].Width = 80;

                dgvUsersList.Columns["RoleName"].HeaderText = "Role";
                dgvUsersList.Columns["RoleName"].Width = 120;

                if (!dgvUsersList.Columns.Contains("EditColumn"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "EditColumn";
                    editButtonColumn.HeaderText = "";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    editButtonColumn.Width = 60;
                    dgvUsersList.Columns.Add(editButtonColumn);
                }

                clsGlobal.WidthCorrector(dgvUsersList, 30);
            }
        }

        public void LoadData()
        {
            _FillDgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                _dtUsers.DefaultView.RowFilter = "";
                clsGlobal.WidthCorrector(dgvUsersList, 30);

                return;
            }
            string Filter = "Username";
            _dtUsers.DefaultView.RowFilter = string.Format($"[{Filter}] like '%{txtSearch.Text.Trim()}%'");
            clsGlobal.WidthCorrector(dgvUsersList, 30);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.Index < 0 || !dgvUsersList.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a user to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedUserID;
            if (dgvUsersList.CurrentRow.Cells[0].Value == DBNull.Value || !int.TryParse(dgvUsersList.CurrentRow.Cells[0].Value.ToString(), out selectedUserID))
            {
                MessageBox.Show("Could not retrieve User ID from selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.UserID == selectedUserID)
            {
                MessageBox.Show("You cannot delete yourself.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsUsers.DeleteByID(selectedUserID))
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error during user deletion. Please check logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            LoadData();
        }
    }


    



}
