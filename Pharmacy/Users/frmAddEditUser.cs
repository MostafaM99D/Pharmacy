using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.Users
{
    public partial class frmAddEditUser : Form
    {
        private int _UserID;
        private clsUsers _User;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            if (UserID == -1)
                lblHeader.Text = "ADD NEW USER";
            else
                lblHeader.Text = $"UPDATING USER WITH [{_UserID}]";
        }

        public void LoadUserInfo()
        {
            if (_UserID != -1)
            {

                _User = clsUsers.Find(_UserID);
                if (_User != null)
                {

                    ctrlPersonDetailsWithFilter1.LoadPerson(_User.PersonID);
                    btnNext.Visible = false;
                    lblUserID.Text = _UserID.ToString();
                    txtUsername.Text = _User.Username;
                    txtPassword.Text = _User.Password;
                    txtConPassword.Text = _User.Password;
                    chkIsActive.Checked = _User.IsActive;
                    cbRoles.SelectedIndex = _User.RoleID - 1;
                    gbPersonDetails.Enabled = false;

                }
                else
                {
                    MessageBox.Show("This user not founded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
            else
            {
                btnNext.Visible = true;
                gbPersonDetails.Enabled = true;
                gbUserDetails.Enabled = false;
                _User = new clsUsers();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ctrlPersonDetailsWithFilter1.IsSelectedPerson)
            {
                MessageBox.Show("Please Select Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsUsers.IsExistByPersonID(ctrlPersonDetailsWithFilter1.PersonID))
            {
                MessageBox.Show("This person is already user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gbUserDetails.Enabled = true;
            btnNext.Visible = false;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillComboBox()
        {
            DataTable dt = clsRoles.GetAllRoles();
            foreach (DataRow dr in dt.Rows)
                cbRoles.Items.Add(dr["RoleName"]);

        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _FillComboBox();
            LoadUserInfo();
            pbUsernameCheck.Visible = false;
        }

        private bool _IsValidInputs()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConPassword.Text))
            {
                MessageBox.Show("username and password connot be empty.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbRoles.SelectedItem == null)
            {
                MessageBox.Show("Please pick up a role.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtConPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("password and confirm password are not matching.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clsUsers.IsExist(txtUsername.Text.Trim()) && txtUsername.Text.Trim() != _User.Username)
            {
                MessageBox.Show("this username is already user by another user", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsValidInputs())
            {


                _User.Username = txtUsername.Text;
                _User.Password = txtPassword.Text;
                _User.IsActive = chkIsActive.Checked;
                _User.PersonID = ctrlPersonDetailsWithFilter1.PersonID;
                _User.RoleID = cbRoles.SelectedIndex + 1;

                if (_User.Save())
                {
                    this._UserID = _User.UserID;
                    MessageBox.Show($"user with [{_UserID}] saved successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblHeader.Text = $"UPDATING USER WITH [{_UserID}]";
                    lblUserID.Text=_User.UserID.ToString();

                }
                else
                {
                    MessageBox.Show("error occurd during save this person", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text)||_User.Username==txtUsername.Text)
            {
                pbUsernameCheck.Visible = false;
                return;
            }
            pbUsernameCheck.Visible = true;

            if (clsUsers.IsExist(txtUsername.Text))
                pbUsernameCheck.Image = Properties.Resources.decline;
            else
                pbUsernameCheck.Image = Properties.Resources.check__1_;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
