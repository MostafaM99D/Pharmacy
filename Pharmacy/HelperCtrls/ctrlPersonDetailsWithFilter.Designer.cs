namespace Pharmacy.HelperCtrls
{
    partial class ctrlPersonDetailsWithFilter
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Filter By Person ID :";
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
            this.txtSearch.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearch.Location = new System.Drawing.Point(238, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "                 PersonID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(312, 36);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(9, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 4);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "First Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = ":";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(169, 109);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 25);
            this.lblFirstName.TabIndex = 57;
            this.lblFirstName.Text = "?????";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(450, 224);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(77, 25);
            this.lblPhoneNumber.TabIndex = 58;
            this.lblPhoneNumber.Text = "?????";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(450, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 25);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "?????";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(169, 265);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 25);
            this.lblAddress.TabIndex = 60;
            this.lblAddress.Text = "?????";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(169, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 25);
            this.lblLastName.TabIndex = 61;
            this.lblLastName.Text = "?????";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Pharmacy.Properties.Resources.magnifier3;
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(594, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 36);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = global::Pharmacy.Properties.Resources.new_user;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewPerson.Location = new System.Drawing.Point(646, 3);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(46, 36);
            this.btnAddNewPerson.TabIndex = 44;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // ctrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearch);
            this.Name = "ctrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(694, 337);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
    }
}
