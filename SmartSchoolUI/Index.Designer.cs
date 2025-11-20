namespace SmartSchoolUI
{
    partial class Index
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
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.textPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
=======
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD

            this.label1.Location = new System.Drawing.Point(162, 34);
            this.label1.Location = new System.Drawing.Point(117, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.label1.Location = new System.Drawing.Point(599, 226);
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
<<<<<<< HEAD
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(94, 131);
            this.textPassword.MaxLength = 8;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(190, 20);
            this.textPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(93, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Enter Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(94, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 24);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
=======
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.studentListToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(377, 311);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";

            this.ClientSize = new System.Drawing.Size(467, 318);
=======
            this.ClientSize = new System.Drawing.Size(1229, 496);
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
<<<<<<< HEAD

=======
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
=======
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
    }
}

