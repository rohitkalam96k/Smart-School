namespace SmartSchoolUI
{
    partial class StdList
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
            this.panTop = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panTop.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblSearch);
            this.panTop.Controls.Add(this.textBox1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1233, 62);
            this.panTop.TabIndex = 0;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.dgvStudents);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 62);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panMain.Size = new System.Drawing.Size(1233, 596);
            this.panMain.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Enter ABC ID";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(10, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1213, 590);
            this.dgvStudents.TabIndex = 0;
            // 
            // StdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 658);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panTop);
            this.Name = "StdList";
            this.Text = "StdList";
            this.Load += new System.EventHandler(this.StdList_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}