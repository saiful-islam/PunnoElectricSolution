using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DotPOS.Service;

namespace DotPOS.Product
{
    public partial class Products : Form
    {
        DataOperation objDataOperation;
        public Products()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            LoadCategory();
            LoadProductGrid();
        }
        public void LoadCategory()
        {
            string strQuery = "EXEC [desktop].[GETCategory]";
            dropdownCategory.DataSource = objDataOperation.GetDataTable(strQuery);
        }
        private void LoadProductGrid()
        {
            string _query = "exec desktop.GETProductsForGrid @SKU='" + txtSKU.Text.Trim() + "',@Name='" + txtName.Text.Trim() + "'";
            try
            {
                _query += ",@CategoryID=" + Convert.ToInt32(dropdownCategory.SelectedValue);
            }
            catch (Exception ex)
            {
            }
            GVProduct.DataSource = objDataOperation.GetDataTable(_query);
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct objProd = new NewProduct();
            this.Hide();
            objProd.ShowDialog();
            objProd.Dispose();
            this.Show();
            LoadProductGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProductGrid();
        }
    }
}
