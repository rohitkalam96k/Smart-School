using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartSchoolUI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }
            else if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please enter the username");
                return;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter the password");
                return;
            }

            // Simple check (later connect to DB)
            if (Username == "Fahad" && Password == "8080")
            {
                // Hide login form
                this.Hide();

                // Open PrincipalDashboard
                Mainprincipledashboard pd = new Mainprincipledashboard();
                pd.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
