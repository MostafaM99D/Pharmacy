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

namespace Pharmacy.Administrator_Managements
{
    public partial class ctrlPeopleScreen : UserControl
    {


        private DataTable _dtPeople;
        public ctrlPeopleScreen()
        {
            InitializeComponent();
            dgvList.CellContentClick += DgvList_CellContentClick;

        }


     

        private void _FillDgv()
        {
            dgvList.Columns.Clear();
            _dtPeople = clsPeople.GetAllPeople();
            dgvList.DataSource = _dtPeople;

            if (dgvList.Rows.Count > 0)
            {
                dgvList.ColumnHeadersHeight = 50;
                dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                dgvList.Columns[0].HeaderText = "Person ID";
                dgvList.Columns[0].Width = 50;

                dgvList.Columns[1].HeaderText = "Name";
                dgvList.Columns[1].Width = 200;

                dgvList.Columns[2].HeaderText = "Email";
                dgvList.Columns[2].Width = 200;

                dgvList.Columns[3].HeaderText = "Phone Number";
                dgvList.Columns[3].Width = 100;

                dgvList.Columns[4].HeaderText = "Address";
                dgvList.Columns[4].Width = 350;

                if (!dgvList.Columns.Contains("EditColumn"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "EditColumn";
                    editButtonColumn.HeaderText = "";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    editButtonColumn.Width = 50;
                    dgvList.Columns.Add(editButtonColumn);
                }

                clsGlobal.WidthCorrector(dgvList, 30);

            }
        }

        public void LoadData()
        {
            _FillDgv();
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // throw new NotImplementedException();

            if (e.ColumnIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "EditColumn" && e.RowIndex >= 0)
            {
                int personID = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["PersonID"].Value);

                frmAddEditPerson f = new frmAddEditPerson(personID);
                f.ShowDialog();
                LoadData();
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = "";
                clsGlobal.WidthCorrector(dgvList, 30);



                return;
            }
            string Filter = "Name";
            _dtPeople.DefaultView.RowFilter = string.Format($"[{Filter}] like '%{txtSearch.Text.Trim()}%'");
            clsGlobal.WidthCorrector(dgvList, 30);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPerson f = new frmAddEditPerson(-1);
            f.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index < 0 || !dgvList.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a person to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedPersonID;
            if (dgvList.CurrentRow.Cells[0].Value == DBNull.Value || !int.TryParse(dgvList.CurrentRow.Cells[0].Value.ToString(), out selectedPersonID))
            {
                MessageBox.Show("Could not retrieve person ID from selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.UserID == selectedPersonID)
            {
                MessageBox.Show("You cannot delete yourself.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this person with person id = {selectedPersonID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsPeople.DeleteByID(selectedPersonID))
                    {
                        MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error during person deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
