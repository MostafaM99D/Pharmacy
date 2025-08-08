namespace Pharmacy.Medicines
{
    partial class frmAddEditInventory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbMedicineDetails = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ctrlMedicineDetailsWithFilter1 = new Pharmacy.HelperCtrls.ctrlMedicineDetailsWithFilter();
            this.gbInventoryDetails = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.gbMedicineDetails.SuspendLayout();
            this.gbInventoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.gbInventoryDetails);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.gbMedicineDetails);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 566);
            this.panel1.TabIndex = 21;
            // 
            // btnX
            // 
            this.btnX.BorderRadius = 20;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnX.FillColor = System.Drawing.Color.White;
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Image = global::Pharmacy.Properties.Resources.cross;
            this.btnX.ImageSize = new System.Drawing.Size(45, 45);
            this.btnX.Location = new System.Drawing.Point(1331, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 46);
            this.btnX.TabIndex = 20;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(478, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(241, 40);
            this.lblHeader.TabIndex = 62;
            this.lblHeader.Text = "Add New Users";
            // 
            // gbMedicineDetails
            // 
            this.gbMedicineDetails.BorderColor = System.Drawing.Color.Silver;
            this.gbMedicineDetails.Controls.Add(this.ctrlMedicineDetailsWithFilter1);
            this.gbMedicineDetails.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.gbMedicineDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbMedicineDetails.ForeColor = System.Drawing.Color.White;
            this.gbMedicineDetails.Location = new System.Drawing.Point(11, 101);
            this.gbMedicineDetails.Name = "gbMedicineDetails";
            this.gbMedicineDetails.Size = new System.Drawing.Size(823, 386);
            this.gbMedicineDetails.TabIndex = 63;
            this.gbMedicineDetails.Text = "Medicine Details";
            // 
            // ctrlMedicineDetailsWithFilter1
            // 
            this.ctrlMedicineDetailsWithFilter1.ForeColor = System.Drawing.Color.Black;
            this.ctrlMedicineDetailsWithFilter1.Location = new System.Drawing.Point(4, 43);
            this.ctrlMedicineDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlMedicineDetailsWithFilter1.Name = "ctrlMedicineDetailsWithFilter1";
            this.ctrlMedicineDetailsWithFilter1.Size = new System.Drawing.Size(815, 327);
            this.ctrlMedicineDetailsWithFilter1.TabIndex = 0;
            // 
            // gbInventoryDetails
            // 
            this.gbInventoryDetails.BorderColor = System.Drawing.Color.Silver;
            this.gbInventoryDetails.Controls.Add(this.label13);
            this.gbInventoryDetails.Controls.Add(this.label12);
            this.gbInventoryDetails.Controls.Add(this.label11);
            this.gbInventoryDetails.Controls.Add(this.guna2PictureBox1);
            this.gbInventoryDetails.Controls.Add(this.label8);
            this.gbInventoryDetails.Controls.Add(this.label5);
            this.gbInventoryDetails.Controls.Add(this.label2);
            this.gbInventoryDetails.Controls.Add(this.lblInventoryID);
            this.gbInventoryDetails.Controls.Add(this.label6);
            this.gbInventoryDetails.Controls.Add(this.label1);
            this.gbInventoryDetails.Controls.Add(this.dtpExpirationDate);
            this.gbInventoryDetails.Controls.Add(this.txtQuantity);
            this.gbInventoryDetails.Controls.Add(this.txtPurchasePrice);
            this.gbInventoryDetails.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.gbInventoryDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbInventoryDetails.ForeColor = System.Drawing.Color.White;
            this.gbInventoryDetails.Location = new System.Drawing.Point(851, 101);
            this.gbInventoryDetails.Name = "gbInventoryDetails";
            this.gbInventoryDetails.Size = new System.Drawing.Size(508, 386);
            this.gbInventoryDetails.TabIndex = 64;
            this.gbInventoryDetails.Text = "Medicine Inventory Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(120, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 29);
            this.label13.TabIndex = 80;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(190, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 29);
            this.label12.TabIndex = 79;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(180, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 29);
            this.label11.TabIndex = 78;
            this.label11.Text = ":";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(432, 151);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(41, 38);
            this.guna2PictureBox1.TabIndex = 76;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "";
            this.txtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.IconRight = global::Pharmacy.Properties.Resources.reset_password2;
            this.txtPurchasePrice.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPurchasePrice.Location = new System.Drawing.Point(28, 297);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(397, 38);
            this.txtPurchasePrice.TabIndex = 72;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 70;
            this.label8.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Expiration Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.IconRight = global::Pharmacy.Properties.Resources.id_card__1_;
            this.txtQuantity.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtQuantity.Location = new System.Drawing.Point(28, 126);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(397, 38);
            this.txtQuantity.TabIndex = 66;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Quantity";
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryID.ForeColor = System.Drawing.Color.Black;
            this.lblInventoryID.Location = new System.Drawing.Point(280, 52);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(77, 25);
            this.lblInventoryID.TabIndex = 60;
            this.lblInventoryID.Text = "?????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(252, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Med Inv ID";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 20;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::Pharmacy.Properties.Resources.next;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(1179, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 52);
            this.btnNext.TabIndex = 86;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::Pharmacy.Properties.Resources.stop;
            this.btnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancel.Location = new System.Drawing.Point(929, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 52);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Pharmacy.Properties.Resources.diskette1;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(1179, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 52);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.Location = new System.Drawing.Point(28, 207);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(397, 39);
            this.dtpExpirationDate.TabIndex = 81;
            // 
            // frmAddEditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditInventory";
            this.Load += new System.EventHandler(this.frmAddEditMedicineInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMedicineDetails.ResumeLayout(false);
            this.gbInventoryDetails.ResumeLayout(false);
            this.gbInventoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2GroupBox gbMedicineDetails;
        private HelperCtrls.ctrlMedicineDetailsWithFilter ctrlMedicineDetailsWithFilter1;
        private Guna.UI2.WinForms.Guna2GroupBox gbInventoryDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
    }
}