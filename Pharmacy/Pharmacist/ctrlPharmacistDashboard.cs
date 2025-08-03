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

namespace Pharmacy.Pharmacist
{
    public partial class ctrlPharmacistDashboard : UserControl
    {
        public ctrlPharmacistDashboard()
        {
            InitializeComponent();
        }



        public void LoadData()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            this.chart1.Series[0].Points.AddXY("", clsMedicineInventories.CountExpirationMedicines());
            this.chart1.Series[1].Points.AddXY("", clsMedicineInventories.CountValidMedicines());
        }
    }
}
