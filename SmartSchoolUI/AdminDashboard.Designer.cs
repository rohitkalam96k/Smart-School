namespace SmartSchoolUI
{
    partial class AdminDashboard
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
            this.panelStudent = new System.Windows.Forms.Panel();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.BtnAddStaff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAdminDashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStudent.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.panelAdminDashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.DimGray;
            this.panelStudent.Controls.Add(this.BtnAddStudent);
            this.panelStudent.Controls.Add(this.label1);
            this.panelStudent.Location = new System.Drawing.Point(17, 87);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(197, 143);
            this.panelStudent.TabIndex = 0;
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.ForeColor = System.Drawing.Color.White;
            this.BtnAddStudent.Location = new System.Drawing.Point(56, 86);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(75, 33);
            this.BtnAddStudent.TabIndex = 2;
            this.BtnAddStudent.Text = "Add";
            this.BtnAddStudent.UseVisualStyleBackColor = false;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT \r\nREGISTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Dashboard";
            // 
            // panelStaff
            // 
            this.panelStaff.BackColor = System.Drawing.Color.DimGray;
            this.panelStaff.Controls.Add(this.BtnAddStaff);
            this.panelStaff.Controls.Add(this.label3);
            this.panelStaff.Location = new System.Drawing.Point(322, 87);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(200, 143);
            this.panelStaff.TabIndex = 0;
            this.panelStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStaff_Paint);
            // 
            // BtnAddStaff
            // 
            this.BtnAddStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStaff.ForeColor = System.Drawing.Color.White;
            this.BtnAddStaff.Location = new System.Drawing.Point(66, 86);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(75, 33);
            this.BtnAddStaff.TabIndex = 2;
            this.BtnAddStaff.Text = "Add";
            this.BtnAddStaff.UseVisualStyleBackColor = false;
            this.BtnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 72);
            this.label3.TabIndex = 1;
            this.label3.Text = "STAFF\r\nREGISTRATION\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelAdminDashboard
            // 
            this.panelAdminDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAdminDashboard.Controls.Add(this.panel1);
            this.panelAdminDashboard.Controls.Add(this.panelStaff);
            this.panelAdminDashboard.Controls.Add(this.panelStudent);
            this.panelAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelAdminDashboard.Name = "panelAdminDashboard";
            this.panelAdminDashboard.Size = new System.Drawing.Size(565, 443);
            this.panelAdminDashboard.TabIndex = 3;
            this.panelAdminDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdminDashboard_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 49);
            this.panel1.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 443);
            this.Controls.Add(this.panelAdminDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.panelAdminDashboard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Button BtnAddStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAdminDashboard;
        private System.Windows.Forms.Panel panel1;
    }
}