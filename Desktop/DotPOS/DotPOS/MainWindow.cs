using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotPOS.Product;
using DotPOS.Sales;
using DotPOS.Report;
using DotPOS.Service;

namespace DotPOS
{
    public partial class MainWindow : Form
    {
        DataOperation objDataOperation;
        public static bool IsProfitAccess=false;
        public MainWindow(string user)
        {
            InitializeComponent();
            lblUserName.Text =  user;
            objDataOperation = new DataOperation();
            LoadUserAccess();
        }

        private void LoadUserAccess()
        {
            salesToolStripMenuItem.Visible = false;
            productToolStripMenuItem.Visible = false;
            reportToolStripMenuItem.Visible = false;
            userManagementToolStripMenuItem.Visible = false;
            orderToolStripMenuItem.Visible = false;
            string _query = " exec [desktop].[SP_Access] @UserName='"+lblUserName.Text+"'";
            DataTable dt = objDataOperation.GetDataTable(_query);
            if(dt.Rows.Count>0)
            {
                if(Convert.ToBoolean(dt.Rows[0]["IsOrderAccess"]))
                {
                    orderToolStripMenuItem.Visible = true;
                }
                if (Convert.ToBoolean(dt.Rows[0]["IsSaleAccess"]))
                {
                    salesToolStripMenuItem.Visible = true;
                }
                if (Convert.ToBoolean(dt.Rows[0]["IsReportAccess"]))
                {
                    reportToolStripMenuItem.Visible = true;
                }
                if (Convert.ToBoolean(dt.Rows[0]["IsUserAccess"]))
                {
                    userManagementToolStripMenuItem.Visible = true;
                }
                if (Convert.ToBoolean(dt.Rows[0]["IsProductAccess"]))
                {
                    productToolStripMenuItem.Visible = true;
                }
                if (Convert.ToBoolean(dt.Rows[0]["IsProfitAccess"]))
                {
                    IsProfitAccess = true;
                }
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleRegister sr = new SaleRegister();
            this.Hide();
            sr.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products objProduct = new Products();
            this.Hide();
            objProduct.ShowDialog();
            this.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports objReports = new Reports();
            this.Hide();
            objReports.ShowDialog();
            this.Show();
        }
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.Users obj = new Security.Users();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.Orders obj = new Order.Orders();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.Customers obj = new Customer.Customers();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }
    }
}
