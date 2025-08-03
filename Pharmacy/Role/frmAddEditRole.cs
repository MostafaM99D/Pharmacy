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

namespace Pharmacy.Role
{
    public partial class frmAddEditRole : Form
    {
        private int _RoleID;
        private clsRoles _Role;

        public frmAddEditRole(int RoleID)
        {
            InitializeComponent();
            _RoleID = RoleID;

            if (RoleID == -1)
                lblHeader.Text = "ADD NEW ROLE";
            else
                lblHeader.Text = $"UPDATE ROLE WITH [{RoleID}]";

        }

        public void PerformLaunchData()
        {
            if (_RoleID != -1)
            {
                _Role = clsRoles.Find(_RoleID);
                if (_Role != null)
                {
                    lblRoleID.Text = _Role.RoleID.ToString();
                    txtRoleName.Text = _Role.RoleName;
                }
                else
                {
                    MessageBox.Show("This role was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            else
            {
                _Role = new clsRoles();
                lblRoleID.Text = "N/A";
            }
        }

        private bool _Validate()
        {
            if (string.IsNullOrEmpty(txtRoleName.Text.Trim()))
            {
                MessageBox.Show("Role Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoleName.Focus();
                return false;
            }

            if (clsRoles.Find(txtRoleName.Text.Trim()) != null)
            {
                MessageBox.Show("Role Name Is Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoleName.Focus();
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

            _Role.RoleName = txtRoleName.Text.Trim();

            try
            {
                if (_Role.Save())
                {
                    _RoleID = _Role.RoleID;
                    MessageBox.Show($"Role with ID = {_Role.RoleID} saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblHeader.Text = $"UPDATE ROLE WITH [{_RoleID}]";

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error during saving role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmAddEditRole_Load(object sender, EventArgs e)
        {
            PerformLaunchData();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
