namespace SmartSchoolUI
{
    partial class StdRegister
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtAbc = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtAdharCard = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtStdMob = new System.Windows.Forms.TextBox();
            this.txtParentMob = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtStdEmail = new System.Windows.Forms.TextBox();
            this.txtCast = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1082, 222);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 32);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(1065, 56);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(140, 160);
            this.picPhoto.TabIndex = 1;
            this.picPhoto.TabStop = false;
            // 
            // txtAbc
            // 
            this.txtAbc.Location = new System.Drawing.Point(86, 37);
            this.txtAbc.MaxLength = 12;
            this.txtAbc.Name = "txtAbc";
            this.txtAbc.Size = new System.Drawing.Size(100, 22);
            this.txtAbc.TabIndex = 2;
            this.txtAbc.TextChanged += new System.EventHandler(this.txtAbc_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(87, 113);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(201, 113);
            this.txtMiddleName.MaxLength = 40;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 22);
            this.txtMiddleName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(330, 113);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoOther);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(87, 222);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(330, 67);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(218, 36);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(40, 21);
            this.rdoOther.TabIndex = 1;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "O";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(112, 40);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(37, 21);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "F";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(37, 36);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(40, 21);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "M";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(87, 151);
            this.txtMotherName.MaxLength = 40;
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(100, 22);
            this.txtMotherName.TabIndex = 2;
            // 
            // txtAdharCard
            // 
            this.txtAdharCard.Location = new System.Drawing.Point(317, 37);
            this.txtAdharCard.MaxLength = 12;
            this.txtAdharCard.Name = "txtAdharCard";
            this.txtAdharCard.Size = new System.Drawing.Size(100, 22);
            this.txtAdharCard.TabIndex = 2;
            this.txtAdharCard.TextChanged += new System.EventHandler(this.txtAdharCard_TextChanged);
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(87, 194);
            this.dtpDob.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(111, 22);
            this.dtpDob.TabIndex = 4;
            // 
            // txtStdMob
            // 
            this.txtStdMob.Location = new System.Drawing.Point(227, 342);
            this.txtStdMob.MaxLength = 10;
            this.txtStdMob.Name = "txtStdMob";
            this.txtStdMob.Size = new System.Drawing.Size(100, 22);
            this.txtStdMob.TabIndex = 2;
            this.txtStdMob.TextChanged += new System.EventHandler(this.txtStdMob_TextChanged);
            // 
            // txtParentMob
            // 
            this.txtParentMob.Location = new System.Drawing.Point(70, 342);
            this.txtParentMob.MaxLength = 10;
            this.txtParentMob.Name = "txtParentMob";
            this.txtParentMob.Size = new System.Drawing.Size(100, 22);
            this.txtParentMob.TabIndex = 2;
            this.txtParentMob.TextChanged += new System.EventHandler(this.txtParentMob_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "General Category ",
            "Scheduled Castes (SC) ",
            "Scheduled Tribes (ST) ",
            "Other Backward Classes (OBC) ",
            "Economically Weaker Section (EWS)"});
            this.cmbCategory.Location = new System.Drawing.Point(74, 419);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 5;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Andhra Pradesh ",
            "Arunachal Pradesh",
            "Assam ",
            "Bihar ",
            "Chhattisgarh ",
            "Goa ",
            "Gujarat ",
            "Haryana ",
            "Himachal Pradesh ",
            "Jharkhand ",
            "Karnataka ",
            "Kerala ",
            "Madhya Pradesh ",
            "Maharashtra ",
            "Manipur ",
            "Meghalaya ",
            "Mizoram ",
            "Nagaland ",
            "Odisha ",
            "Punjab ",
            "Rajasthan ",
            "Sikkim ",
            "Tamil Nadu ",
            "Telangana ",
            "Tripura ",
            "Uttar Pradesh ",
            "Uttarakhand ",
            "West Bengal"});
            this.cmbState.Location = new System.Drawing.Point(74, 487);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 24);
            this.cmbState.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(201, 489);
            this.txtCity.MaxLength = 40;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 22);
            this.txtCity.TabIndex = 6;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(381, 489);
            this.txtPin.MaxLength = 6;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(174, 22);
            this.txtPin.TabIndex = 6;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(87, 575);
            this.txtStreet.MaxLength = 255;
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(317, 42);
            this.txtStreet.TabIndex = 6;
            // 
            // txtStdEmail
            // 
            this.txtStdEmail.Location = new System.Drawing.Point(381, 342);
            this.txtStdEmail.MaxLength = 255;
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(100, 22);
            this.txtStdEmail.TabIndex = 2;
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(227, 419);
            this.txtCast.MaxLength = 40;
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(100, 22);
            this.txtCast.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ABC ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adhar Card No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mother Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "DOB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Parents Moile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Students Mobile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Students Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cast";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "State";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Pincode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(84, 555);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Local Street";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1062, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Photo";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(845, 574);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 32);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(705, 574);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(1065, 267);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(140, 22);
            this.txtPath.TabIndex = 9;
            // 
            // StdRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAdharCard);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.txtStdEmail);
            this.Controls.Add(this.txtParentMob);
            this.Controls.Add(this.txtStdMob);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtAbc);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnBrowse);
            this.Name = "StdRegister";
            this.Text = "Student Register";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox txtAbc;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtAdharCard;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtStdMob;
        private System.Windows.Forms.TextBox txtParentMob;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtStdEmail;
        private System.Windows.Forms.TextBox txtCast;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPath;
    }
}