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
    public partial class ctrlViewMedicines : UserControl
    {
        public ctrlViewMedicines()
        {
            InitializeComponent();
        }

        private DataTable _dtMedicines;
        public void LoadData()
        {
            dgvMedicineList.ColumnHeadersHeight = 70;
            _dtMedicines = clsMedicines.GetAllMedicines();
            dgvMedicineList.DataSource = _dtMedicines;
            if (dgvMedicineList.Rows.Count > 0)
            {
                dgvMedicineList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvMedicineList.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                dgvMedicineList.Columns[0].HeaderText = "Medicine ID";
                dgvMedicineList.Columns[0].Width = 100;

                dgvMedicineList.Columns[1].HeaderText = "Medicine Name";
                dgvMedicineList.Columns[1].Width = 215;

                dgvMedicineList.Columns[2].HeaderText = "Description";
                dgvMedicineList.Columns[2].Width = 350;

                dgvMedicineList.Columns[3].HeaderText = "Dosage";
                dgvMedicineList.Columns[3].Width = 100;

                dgvMedicineList.Columns[4].HeaderText = "Sale Price";
                dgvMedicineList.Columns[4].Width = 100;

                dgvMedicineList.Columns[5].HeaderText = "Category Name";
                dgvMedicineList.Columns[5].Width = 250;

                dgvMedicineList.Columns[6].HeaderText = "Quantity";
                dgvMedicineList.Columns[6].Width = 100;

                dgvMedicineList.Columns[7].HeaderText = "Expiration Date";
                dgvMedicineList.Columns[7].Width = 200;

                dgvMedicineList.Columns[8].HeaderText = "Purchase Price";
                dgvMedicineList.Columns[8].Width = 100;

                for(int i = 0; i < dgvMedicineList.Rows.Count; i++)
                    dgvMedicineList.Rows[i].Height = 30;
                

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                _dtMedicines.DefaultView.RowFilter = "";
                return;
            }
            string Filter = "MedicineName";
            _dtMedicines.DefaultView.RowFilter = string.Format($"[{Filter}] like '%{txtSearch.Text.Trim()}%'");
        }
    }
}
