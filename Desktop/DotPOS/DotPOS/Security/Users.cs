using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace DotPOS.Security
{
    public partial class Users : Form
    {
        DataOperation objDataOperation;
        SecurePasswordHasher objHash;
        public Users()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            objHash = new SecurePasswordHasher();
            LoadCategory();
            cbIsActive.Checked = true;
            cbRole.SelectedValue = 2;
            LoadgvUsers();
        }

        private void LoadCategory()
        {
            string strQuery = "SELECT [Id],[Name] FROM [desktop].[Role] where [IsDeleted]='False'";
            cbRole.DataSource = objDataOperation.GetDataTable(strQuery);
        }
        private void LoadgvUsers()
        {
            gvUsers.DataSource = null;
            string strQuery = @"SELECT [UserName]
                              ,[Password]
                              ,u.RoleId
                              ,r.Name as Role
                              ,[IsActive]
                          FROM [desktop].[User] u
                          join [desktop].[Role] r
                          on u.RoleId=r.Id
                          where u.[IsDeleted]='FALSE'";
            gvUsers.DataSource = objDataOperation.GetDataTable(strQuery);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim()=="" || txtUserName.Text.Trim()=="")
            {
                MessageBox.Show("User and Password should not empty");
                return;
            }
            string strQuery = "EXEC [desktop].[InsertUsers] ";
            strQuery += " @userName = '"+txtUserName.Text.Trim()+"'";
            strQuery += " ,@password = '"+objHash.Hash(txtPassword.Text.Trim())+"'";
            strQuery += " ,@roleId ="+ cbRole.SelectedValue;
            strQuery += " ,@isActive ="+cbIsActive.Checked;
            string res = objDataOperation.ExecuteNonQuery(strQuery);
            if ( res== "1")
            {
                btnReset_Click(sender, e);
                LoadgvUsers();
            }
            else
            {
                MessageBox.Show(res);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            cbIsActive.Checked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("User and Password should not empty");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string strQuery = "EXEC [desktop].[InsertUsers] ";
                strQuery += " @userName = '" + txtUserName.Text.Trim() + "'";
                strQuery += " ,@password = '" + txtPassword.Text.Trim() + "'";
                strQuery += " ,@roleId =" + cbRole.SelectedValue;
                strQuery += " ,@isActive =" + cbIsActive.Checked;
                strQuery += " ,@isDelete ='True'";
                string res = objDataOperation.ExecuteNonQuery(strQuery);
                if (res == "1")
                {
                    btnReset_Click(sender, e);
                    LoadgvUsers();
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
        }

        private void gvUsers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            txtUserName.Text = e.Row.Cells["UserName"].Value.ToString();
            cbIsActive.Checked = Convert.ToBoolean( e.Row.Cells["IsActive"].Value);
            cbRole.SelectedValue = Convert.ToInt32( e.Row.Cells["RoleId"].Value);
        }
    }
}
