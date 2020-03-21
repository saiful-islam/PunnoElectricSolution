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
    public partial class NewProduct : Form
    {
        DataOperation objDataOperation;
        OtherOperation objOtherOperation;
        public System.Windows.Forms.Timer tmrDelay;
        public NewProduct()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            objOtherOperation = new OtherOperation();
            LoadCategory();
            tmrDelay = new System.Windows.Forms.Timer();
            tmrDelay.Interval = 1000;
            tmrDelay.Enabled = false;
        }
        public void LoadCategory()
        {
            string strQuery = "EXEC [desktop].[GETCategory]";
            DropDownCategory.DataSource = objDataOperation.GetDataTable(strQuery);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strQuery = "Exec [desktop].[InsertProduct] @sku=" + objOtherOperation.GetTextFromValue( txtSKU.Text.Trim())+ ", @name="+ objOtherOperation.GetTextFromValue(txtName.Text.Trim())+"";
            strQuery += ",@categoryId="+ objOtherOperation.GetNumericFromValue(DropDownCategory.SelectedValue.ToString())+ ", @price="+ objOtherOperation.GetNumericFromValue(txtPrice.Text.Trim())+"";
            strQuery += ",@oldPrice=" + objOtherOperation.GetNumericFromValue(txtOldPrice.Text.Trim()) + ", @wholeSalePrice=" + objOtherOperation.GetNumericFromValue(txtWholesalePrice.Text.Trim()) + "";
            strQuery += ",@prdCost=" + objOtherOperation.GetNumericFromValue(txtCost.Text.Trim()) + ",@qty="+ objOtherOperation.GetNumericFromValue(txtQTY.Text.Trim())+";";

            string result = objDataOperation.ExecuteNonQuery(strQuery);
            if ( result== "1")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        private void txtSKU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSKU.Text.Trim().Length == 1)
                {
                    tmrDelay.Enabled = true;
                    tmrDelay.Start();
                    tmrDelay.Tick += new EventHandler(tmrDelay_Tick);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void tmrDelay_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrDelay.Stop();
                string strCurrentString = txtSKU.Text.Trim().ToString();
                if (strCurrentString != "")
                {
                    //Do something with the barcode entered 
                    //txtSKU.Text = "";
                }
                txtSKU.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtSKU_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strCurrentString = txtSKU.Text.Trim().ToString();
                if (strCurrentString != "")
                {
                    LoadProductbySKU();
                }
                txtSKU.Focus();
            }
        }
        public void LoadProductbySKU()
        {
            string _query = "exec desktop.GETProductsForGrid @SKU='" + txtSKU.Text.Trim() + "'";
            DataTable dt = new DataTable();
            dt = objDataOperation.GetDataTable(_query);
            try
            {
                DropDownCategory.SelectedValue = dt.Rows[0]["CategoryId"].ToString();
                txtSKU.Text = dt.Rows[0]["Sku"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtQTY.Text = dt.Rows[0]["StockQuantity"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                txtOldPrice.Text = dt.Rows[0]["OldPrice"].ToString();
                txtWholesalePrice.Text = dt.Rows[0]["WholesalePrice"].ToString();
                txtCost.Text = dt.Rows[0]["ProductCost"].ToString();
                txtSKU.Enabled = false;
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSKU.Enabled = true;
            txtSKU.Text = "";
            txtName.Text = "";
            txtQTY.Text = "";
            txtPrice.Text = "";
            txtOldPrice.Text = "";
            txtWholesalePrice.Text = "";
            txtCost.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string _query = " update [desktop].[Product] set [Deleted] = 'True' where [SKU]='" + txtSKU.Text.Trim() + "'";
                string result = objDataOperation.ExecuteNonQuery(_query);
                if (result == "1")
                {
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            
        }
    }
}
