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
using System.IO;
using Pharmacy.Administrator;
using Pharmacy.Pharmacist;
using Pharmacy.SalesPerson;

namespace Pharmacy
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            string username, password;
            username = password = "";
            if (clsGlobal.GetSavedUsernameAndPassword(ref username, ref password))
            {
                txtPassword.Text = password;
                txtUsername.Text = username;
                chkRememberMe.Checked = true;
            }
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool _Validate()
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username and Password Connot Be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }
        private void _RememberChecker()
        {
            if (chkRememberMe.Checked)
                clsGlobal.AddUsernameAndPasswordToFile(txtUsername.Text, txtPassword.Text);
            else if (File.Exists(clsGlobal.FilePath))
                File.Delete(clsGlobal.FilePath);

        }
        private void _WhatAfterLogin()
        {
            Form frm;
            switch (clsGlobal.CurrentUser.RoleID)
            {
                case 1:
                    frm = new frmAdminstratorDashboard();
                    break;
                case 2:
                    frm = new frmPharmacist();
                    break;
                default:
                    frm = new frmSalesPerson();
                    break;

            }

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (_Validate())
            {
                clsGlobal.CurrentUser = clsUsers.Find(txtUsername.Text, txtPassword.Text);
                if (clsGlobal.CurrentUser == null)
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!clsGlobal.CurrentUser.IsActive)
                {
                    MessageBox.Show("This user is not active, please contact your administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _RememberChecker();
                _WhatAfterLogin();


            }
        }


        private bool _IsHide = true;
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (_IsHide)
            {
                txtPassword.PasswordChar = '\0';
                btnHide.Image = Properties.Resources.open_eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnHide.Image = Properties.Resources.eye__1_;
            }
            _IsHide = !_IsHide;
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
