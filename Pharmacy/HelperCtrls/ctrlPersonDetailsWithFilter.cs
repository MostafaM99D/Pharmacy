using BLL;
using Pharmacy.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.HelperCtrls
{
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        public int PersonID;
        private clsPeople _Person;
        public bool IsSelectedPerson = false;
        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }


        public void LoadPerson(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);
            if (_Person != null)
            {
                this.PersonID = PersonID;
                IsSelectedPerson = true;
                txtSearch.Text=PersonID.ToString();
                lblAddress.Text = _Person.Address;
                lblEmail.Text = _Person.Email;
                lblFirstName.Text = _Person.FirstName;
                lblLastName.Text = _Person.LastName;
                lblPhoneNumber.Text = _Person.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // this.PersonID = PersonID;
                lblAddress.Text = "?????";
                lblEmail.Text = "?????";
                lblFirstName.Text = "?????";
                lblLastName.Text = "?????";
                lblPhoneNumber.Text = "?????";
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadPerson(Convert.ToInt32(txtSearch.Text));
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += _OnDataBack; ;
            frm.ShowDialog();
            
        }

        private void _OnDataBack(int PersonID, object sender)
        {
            this.PersonID = PersonID;
            LoadPerson(PersonID);
           // txtSearch.Text=PersonID.ToString();
        }
    }
}
