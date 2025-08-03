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

namespace Pharmacy.Medicines
{
    public partial class frmAddEditCategory : Form
    {

        private int _CategoryID;
        private clsCategories _Category;

        public frmAddEditCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;

            if (CategoryID == -1)
            {
                lblHeader.Text = "ADD NEW CATEGORY";
            }
            else
            {
                lblHeader.Text = $"UPDATE CATEGORY WITH [{CategoryID}]";
            }
        }

        public void PerformLaunchData()
        {
            if (_CategoryID != -1)
            {
                _Category = clsCategories.Find(_CategoryID);
                if (_Category != null)
                {
                    lblCategoryID.Text = _Category.CategoryID.ToString();
                    txtCategoryName.Text = _Category.CategoryName;
                }
                else
                {
                    MessageBox.Show("This category was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            else
            {
                _Category = new clsCategories();
                lblCategoryID.Text = "N/A";
            }
        }

        private bool _Validate()
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                MessageBox.Show("Category Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return false;
            }
            if (clsCategories.Find(txtCategoryName.Text.Trim()) != null)
            {
                MessageBox.Show("Category Name Is Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
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

            _Category.CategoryName = txtCategoryName.Text.Trim();

            try
            {
                if (_Category.Save())
                {
                    _CategoryID = _Category.CategoryID;
                    MessageBox.Show($"Category with ID = {_Category.CategoryID} saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblHeader.Text = $"UPDATE CATEGORY WITH [{_CategoryID}]";

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error during saving category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            PerformLaunchData();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

