using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace DotPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement();
            if (user.IsValidUser(txtUser.Text.Trim(), txtPass.Text.Trim()))
            {
                this.Hide();
                MainWindow main = new MainWindow(txtUser.Text.Trim());
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("User or Password is incorrect. Please enter valid user and password.");
            }

        }
        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
