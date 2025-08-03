namespace Pharmacy.Role
{
    partial class frmAddEditRole
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblRoleID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblRoleID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRoleName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 366);
            this.panel1.TabIndex = 0;
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
            this.btnX.Location = new System.Drawing.Point(651, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 46);
            this.btnX.TabIndex = 19;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(255, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(260, 40);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Add New Person";
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
            this.btnCancel.Location = new System.Drawing.Point(262, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 52);
            this.btnCancel.TabIndex = 88;
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
            this.btnSave.Location = new System.Drawing.Point(504, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 52);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRoleID
            // 
            this.lblRoleID.AutoSize = true;
            this.lblRoleID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleID.Location = new System.Drawing.Point(157, 84);
            this.lblRoleID.Name = "lblRoleID";
            this.lblRoleID.Size = new System.Drawing.Size(68, 29);
            this.lblRoleID.TabIndex = 86;
            this.lblRoleID.Text = "?????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "Role ID";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoleName.DefaultText = "";
            this.txtRoleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleName.IconRight = global::Pharmacy.Properties.Resources.id_card__1_;
            this.txtRoleName.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtRoleName.Location = new System.Drawing.Point(162, 153);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.PlaceholderText = "";
            this.txtRoleName.SelectedText = "";
            this.txtRoleName.Size = new System.Drawing.Size(417, 38);
            this.txtRoleName.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Role Name";
            // 
            // frmAddEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditRole";
            this.Load += new System.EventHandler(this.frmAddEditRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnX;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblRoleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}