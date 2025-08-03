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

namespace Pharmacy.Administrator
{
    public partial class ctrlDashboard : UserControl
    {
        public ctrlDashboard()
        {
            InitializeComponent();
        }



        public void LoadData()
        {
            lblNumberOfAdmins.Text = clsUsers.Count(1).ToString();
            lblNumberOfPharmacist.Text=clsUsers.Count(2).ToString();
            lblNumberOfSalesPerson.Text=clsUsers.Count(3).ToString();
            lblNumberOfCustomers.Text = clsCustomers.Count().ToString();
            lblNumberOfSuppliers.Text=clsSuppliers.Count().ToString();
        }
    }
}
