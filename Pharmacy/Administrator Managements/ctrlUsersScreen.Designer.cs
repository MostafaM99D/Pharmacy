namespace Pharmacy.Administrator
{
    partial class ctrlUsersScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users Management";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Filter By Username :";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.ColumnHeadersHeight = 4;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.Location = new System.Drawing.Point(54, 263);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.Size = new System.Drawing.Size(1386, 572);
            this.dgvUsersList.TabIndex = 35;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUsersList.ThemeStyle.ReadOnly = true;
            this.dgvUsersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddNew
            // 
            this.btnAddNew.BorderRadius = 20;
            this.btnAddNew.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::Pharmacy.Properties.Resources.new_user;
            this.btnAddNew.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNew.Location = new System.Drawing.Point(1148, 851);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(143, 55);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Pharmacy.Properties.Resources.bin;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(1297, 851);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(143, 55);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Delete";
            this.guna2Button1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::Pharmacy.Properties.Resources.magnifier2;
            this.txtSearch.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearch.Location = new System.Drawing.Point(592, 155);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search.......";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(353, 36);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ctrlUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "ctrlUsersScreen";
            this.Size = new System.Drawing.Size(1490, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersList;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
