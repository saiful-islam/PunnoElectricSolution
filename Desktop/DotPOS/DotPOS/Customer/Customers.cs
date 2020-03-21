using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotPOS.Customer
{
    public partial class Customers : Form
    {
        DataOperation objDataOperation;
        int customerId = 0;
        public Customers()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            string _query = @"select CustomerID,CustomerName,CustomerAddress,CustomerMobileNo
                              from[desktop].[Customer] where  IsDeleted=0";
            DataTable dt = objDataOperation.GetDataTable(_query);
            dataGridCustomers.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() != "")
            {
                string _query = "";
                if (lblCustomerID.Text =="0")
                {
                    _query = @"insert into [desktop].[Customer]
                            values( (select isnull(max(CustomerID),0)+1
		                            from [desktop].[Customer]),
		        '" + txtCustomerName.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtMobileNo.Text.Trim() + "',0)";
                }
                else
                {
                    _query = @"Update [desktop].[Customer]
                    set CustomerName='"+ txtCustomerName.Text.Trim() + "',CustomerAddress='" + txtAddress.Text.Trim() + "',CustomerMobileNo='" + txtMobileNo.Text.Trim() + "'  where CustomerID="+lblCustomerID.Text;
                }
                
                string res = objDataOperation.ExecuteNonQuery(_query);
                if (res=="1")
                {
                    Reset();
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
        }
        private void Reset()
        {
            lblCustomerID.Text = "0";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
        }

        private void dataGridCustomers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Reset();
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            customerId = Convert.ToInt32(e.Row.Cells["CustomerID"].Value.ToString());

            lblCustomerID.Text = e.Row.Cells["CustomerID"].Value.ToString();
            txtCustomerName.Text = e.Row.Cells["CustomerName"].Value.ToString();
            txtAddress.Text = e.Row.Cells["CustomerAddress"].Value.ToString();
            txtMobileNo.Text = e.Row.Cells["CustomerMobileNo"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() != "")
            {
                string _query = "";
                if (lblCustomerID.Text != "0")
                {
                    _query = @"update  [desktop].[Customer] set IsDeleted=1  where CustomerID=" + lblCustomerID.Text;
                    string res = objDataOperation.ExecuteNonQuery(_query);
                    if (res == "1")
                    {
                        MessageBox.Show("The customer has been deleted");
                        Reset();
                        LoadCustomer();
                    }
                    else
                    {
                        MessageBox.Show(res);
                    }
                }
                
                
            }
        }
    }
}
