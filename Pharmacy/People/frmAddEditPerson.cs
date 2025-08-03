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

namespace Pharmacy.People
{
    public partial class frmAddEditPerson : Form
    {
        private int _PersonID;
        private clsPeople _Person;

        public delegate void DataBackHandler(int PersonID, object sender);
        public virtual event DataBackHandler DataBack;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            if (PersonID == -1)
                lblHeader.Text = "ADD NEW PERSON";
            else
                lblHeader.Text = $"UPDATE PERSON WITH [{PersonID}]";

            _PersonID = PersonID;
        }




        public void PerformLaunchData()
        {
            if (_PersonID != -1)
            {
                _Person = clsPeople.Find(_PersonID);
                if (_Person != null)
                {

                    lblPersonID.Text = _Person.PersonID.ToString();
                    txtAddress.Text = _Person.Address;
                    txtEmail.Text = _Person.Email;
                    txtFirstName.Text = _Person.FirstName;
                    txtLastName.Text = _Person.LastName;
                    txtPhoneNumber.Text = _Person.PhoneNumber;

                }
                else
                {
                    MessageBox.Show("This person is not founded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                _Person = new clsPeople();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            PerformLaunchData();
        }

        private bool _Validate()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("First Name Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Last Name Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_Validate())
            {
                _Person.FirstName = txtFirstName.Text.Trim();
                _Person.LastName = txtLastName.Text.Trim();
                _Person.Email = string.IsNullOrEmpty(txtEmail.Text.Trim()) ? null : txtEmail.Text.Trim();
                _Person.PhoneNumber = string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()) ? null : txtPhoneNumber.Text.Trim();
                _Person.Address = string.IsNullOrEmpty(txtAddress.Text.Trim()) ? null : txtAddress.Text.Trim();

                if (_Person.Save())
                {
                    if (_PersonID == -1)
                        MessageBox.Show($"person with id= {_Person.PersonID} added successfully.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"person with id= {_Person.PersonID} updated successfully.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _PersonID = _Person.PersonID;
                    lblHeader.Text = $"UPDATE PERSON WITH [{_PersonID}]";
                    txtAddress.Text = _Person.Address;
                    txtEmail.Text = _Person.Email;
                    txtFirstName.Text = _Person.FirstName;
                    txtLastName.Text = _Person.LastName;
                    txtPhoneNumber.Text = _Person.PhoneNumber;


                    DataBack?.Invoke(_PersonID, this);

                }
                else
                {
                    MessageBox.Show("Error During Save Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
