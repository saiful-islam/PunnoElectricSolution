using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace DotPOS.Sales
{
    public partial class SaleRegister : Form
    {
        DataOperation objDataOperation;
        private double payment=0;
        private int customerId=0;
        public static DataTable dtGVItems = new DataTable();
        public static Dictionary<string, int> listMaximumQty = new Dictionary<string, int>();
        public SaleRegister()
        {
            InitializeComponent();


            Clear();
            objDataOperation = new DataOperation();
            LoadCategory();
            LoadPnael();
            if (dtGVItems.Columns.Count == 0)
            {
                dtGVItems.Columns.Add("Sku");
                dtGVItems.Columns.Add("Name");
                dtGVItems.Columns.Add("Price");
                dtGVItems.Columns.Add("WholeSalePrice");
                dtGVItems.Columns.Add("Quantity");
                dtGVItems.Columns.Add("SubTotal");
                dtGVItems.Columns.Add("WholeSaleSubTotal");
            }
            gvCart.DataSource = dtGVItems;
            gvCart.Columns[0].ReadOnly = true;//sku
            gvCart.Columns[1].ReadOnly = true;//Name
            gvCart.Columns[2].ReadOnly = true;//Price
            gvCart.Columns[3].ReadOnly = true;//WholeSalePrice
            gvCart.Columns[3].Visible = false;//WholeSalePrice
            gvCart.Columns[4].ReadOnly = false;//Quantity
            gvCart.Columns[5].ReadOnly = true;//SubTotal
            gvCart.Columns[6].ReadOnly = true;//WholeSaleSubTotal
            gvCart.Columns[6].Visible = false;//WholeSaleSubTotal
            LoadListMaximumQty();
        }
        public void LoadListMaximumQty()
        {
            listMaximumQty.Clear();
            string _query = "exec [desktop].[GetStockQuantity]";
            DataTable dt = objDataOperation.GetDataTable(_query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMaximumQty.Add(dt.Rows[i]["Sku"].ToString(), Convert.ToInt32(dt.Rows[i]["StockQuantity"]));
            }
        }
        private void LoadPnael()
        {
            pnlProducts.Controls.Clear();
            string _query = "exec desktop.GETProductsForGrid @SKU='" + txtSKU.Text.Trim() + "',@Name='" + txtName.Text.Trim() + "'";
            try
            {
                _query += ",@CategoryID=" + Convert.ToInt32(dropdownCategory.SelectedValue);
            }
            catch (Exception ex)
            {
            }
            DataTable dt = objDataOperation.GetDataTable(_query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Container obj = new Container(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Sku"].ToString(), dt.Rows[i]["Price"].ToString(), dt.Rows[i]["WholesalePrice"].ToString(), dt.Rows[i]["StockQuantity"].ToString());
                pnlProducts.Controls.Add(obj.panelAddToCart);
            }
        }
        private void txtSKU_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPnael();
                txtSKU.Focus();
            }
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPnael();
                txtName.Focus();
            }
        }
        private void LoadCategory()
        {
            string strQuery = "EXEC [desktop].[GETCategory]";
            dropdownCategory.DataSource = objDataOperation.GetDataTable(strQuery);
        }

        private void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPnael();
        }
       
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Trim() != "")
            {
                double discount = 0.00;
                if (txtDiscount.Text.Trim() != "")
                {
                    discount = Convert.ToDouble(lblSubTotal.Text) * (Convert.ToDouble(txtDiscount.Text)/100);
                }
                lblTotal.Text = Math.Ceiling((Convert.ToDouble(lblSubTotal.Text) - discount)).ToString();
            }
        }
        private void Clear()
        {
            dtGVItems.Rows.Clear();
            lblSubTotal.Text = "0.00";
            txtDiscount.Text = "0.00";
            lblTotal.Text = "0.00";
            txtOrderId.Text = "";
            txtOrderId.Enabled = true;
            cbWholeSale.Checked = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            LoadListMaximumQty();
            LoadPnael();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dtGVItems.Rows.Count > 0)
            {
                Order objOrder = new Order(cbWholeSale.Checked, lblSubTotal.Text, lblTotal.Text, txtDiscount.Text.Trim(), txtOrderId.Text.Trim(), lblCustomerName.Text,lblMobile.Text,lblCustomerAddress.Text, payment, customerId);
                this.Hide();
                objOrder.ShowDialog();
                Clear();
                this.Show();
                if (dtGVItems.Rows.Count == 0)
                {
                    btnReset_Click(sender, e);
                    LoadPnael();
                }
            }
        }
        public void calculateTotals()
        {
            double subtotal = 0.00;
            foreach (DataRow row in dtGVItems.Rows)
            {
                try
                {
                    if (!cbWholeSale.Checked)
                    {
                        subtotal += Convert.ToDouble(row["SubTotal"]);
                    }
                    else
                    {
                        subtotal += Convert.ToDouble(row["WholeSaleSubTotal"]);
                    }
                }
                catch { }
            }
            lblSubTotal.Text = subtotal.ToString();

            double discount = 0.00;
            if (txtDiscount.Text.Trim() != "")
            {
                discount = Convert.ToDouble(txtDiscount.Text);
            }
            lblTotal.Text = (subtotal - discount).ToString();
        }
        public static void addToCart(string sku, string name, string price, string WholeSalePrice)
        {
            sku = sku.Split('#')[1].Trim();
            price = price.Split('#')[1].Trim();
            WholeSalePrice = WholeSalePrice.Split('#')[1].Trim();

            string find = "Sku = '" + sku + "'";
            DataRow foundRow = dtGVItems.Select(find).FirstOrDefault();
            if (foundRow == null)
            {
                int maximumQty = listMaximumQty[sku];
                if (maximumQty < 1)
                {
                    MessageBox.Show("Quantity Exceed. Maximum Quantity is # " + maximumQty);
                }
                else
                {
                    DataRow newrow = dtGVItems.NewRow();
                    newrow["sku"] = sku;
                    newrow["name"] = name;
                    newrow["price"] = price;
                    newrow["WholeSalePrice"] = WholeSalePrice;
                    newrow["Quantity"] = 1;
                    newrow["SubTotal"] = price;
                    newrow["WholeSaleSubTotal"] = WholeSalePrice;
                    dtGVItems.Rows.Add(newrow);
                }
            }
            else
            {
                int maximumQty = listMaximumQty[sku];
                if (maximumQty < Convert.ToInt32(foundRow["Quantity"]) + 1)
                {
                    MessageBox.Show("Quantity Exceed. Maximum Quantity is # " + maximumQty);
                    foundRow["Quantity"] = maximumQty;
                }
                else
                {
                    foundRow["Quantity"] = Convert.ToInt32(foundRow["Quantity"]) + 1;
                }
                foundRow["SubTotal"] = Convert.ToDouble(foundRow["price"]) * Convert.ToInt32(foundRow["Quantity"]);
                foundRow["WholeSaleSubTotal"] = Convert.ToDouble(foundRow["WholeSalePrice"]) * Convert.ToInt32(foundRow["Quantity"]);
            }
            dtGVItems.AcceptChanges();
        }
        private void gvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGVItems.Rows[e.RowIndex][e.ColumnIndex].ToString() != "")
            {
                int maximumQty = listMaximumQty[dtGVItems.Rows[e.RowIndex]["Sku"].ToString()];
                if (Convert.ToInt32(dtGVItems.Rows[e.RowIndex][e.ColumnIndex]) > maximumQty)
                {
                    MessageBox.Show("Quantity Exceed. Maximum Quantity is # " + maximumQty);
                    dtGVItems.Rows[e.RowIndex][e.ColumnIndex] = maximumQty;
                }
                dtGVItems.Rows[e.RowIndex]["SubTotal"] = Convert.ToInt32(dtGVItems.Rows[e.RowIndex][e.ColumnIndex]) * Convert.ToDouble(dtGVItems.Rows[e.RowIndex]["price"]);
                dtGVItems.Rows[e.RowIndex]["WholeSaleSubTotal"] = Convert.ToInt32(dtGVItems.Rows[e.RowIndex][e.ColumnIndex]) * Convert.ToDouble(dtGVItems.Rows[e.RowIndex]["WholeSalePrice"]);
                calculateTotals();
                dtGVItems.AcceptChanges();
            }
        }

        private void gvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculateTotals();
        }

        private void cbWholeSale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWholeSale.Checked == true)
            {
                gvCart.Columns[2].Visible = false;//Price
                gvCart.Columns[3].Visible = true;//WholeSalePrice
                gvCart.Columns[5].Visible = false;//WholeSaleSubTotal
                gvCart.Columns[6].Visible = true;//WholeSaleSubTotal
            }
            else
            {
                gvCart.Columns[2].Visible = true;//Price
                gvCart.Columns[3].Visible = false;//WholeSalePrice
                gvCart.Columns[5].Visible = true;//WholeSaleSubTotal
                gvCart.Columns[6].Visible = false;//WholeSaleSubTotal
            }
            calculateTotals();
        }
        private void txtOrderId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string _query = "Exec [desktop].[GetOrderDetails] @OrderId="+txtOrderId.Text.Trim();
                DataTable dt = objDataOperation.GetDataTable(_query);
                if (dt.Rows.Count>0)
                {
                    txtOrderId.Enabled = false;
                    bool IsWholeSale = false;
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataRow newrow = dtGVItems.NewRow();
                        newrow["sku"] = dr["sku"];
                        newrow["name"] = dr["name"];
                        newrow["price"] = dr["price"];
                        newrow["WholeSalePrice"] = dr["WholeSalePrice"];
                        newrow["Quantity"] = dr["Quantity"];
                        newrow["SubTotal"] = dr["SubTotal"];
                        newrow["WholeSaleSubTotal"] = dr["WholeSaleSubTotal"];
                        if (dr["IsWholeSale"].ToString() == "1") IsWholeSale = true;
                        dtGVItems.Rows.Add(newrow);
                        listMaximumQty[dr["sku"].ToString()] = listMaximumQty[dr["sku"].ToString()] + Convert.ToInt32(dr["Quantity"]);

                        lblCustomerName.Text = dr["CustomerName"].ToString();
                        lblMobile.Text = dr["CustomerMobileNo"].ToString();
                        lblCustomerAddress.Text = dr["CustomerAddress"].ToString();
                        payment = Convert.ToDouble(dr["Payment"]);
                        customerId = Convert.ToInt32(dr["CustomerID"]);
                        txtDiscount.Text = dr["OrderDiscount"].ToString();
                    }
                    cbWholeSale.Checked = IsWholeSale;
                    calculateTotals();
                    dtGVItems.AcceptChanges();
                }
            }
        }
        private void gvCart_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calculateTotals();
            dtGVItems.AcceptChanges();
        }
    }
    public class Container
    {
        public Label lblproductName = new Label();
        public Label lblSKU = new Label();
        public Label lblprice = new Label();
        public Label lblWholesalePrice = new Label();
        public Label lblQuantity = new Label();
        public Button btnAddToCart = new Button();
        public FlowLayoutPanel panelAddToCart = new FlowLayoutPanel();

        public Container(string productName, string sku, string price, string WholesalePrice, string Qty)
        {
            panelAddToCart.Height = 200;
            panelAddToCart.Width = 350;

            lblproductName.Text = productName;
            lblproductName.Width = 350;
            panelAddToCart.Controls.Add(lblproductName);

            lblSKU.Text = "SKU # " + sku;
            lblSKU.Width = 350;
            panelAddToCart.Controls.Add(lblSKU);

            lblprice.Text = "Price # " + price;
            lblprice.Width = 350;
            panelAddToCart.Controls.Add(lblprice);

            lblWholesalePrice.Text = "Wholesale # " + WholesalePrice;
            lblWholesalePrice.Width = 350;
            panelAddToCart.Controls.Add(lblWholesalePrice);

            lblQuantity.Text = "Quantity # " + Qty;
            lblQuantity.Width = 350;
            panelAddToCart.Controls.Add(lblQuantity);

            btnAddToCart.Text = "Add";
            btnAddToCart.Height = 50;
            btnAddToCart.Width = 100;
            btnAddToCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            panelAddToCart.Controls.Add(btnAddToCart);

        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            SaleRegister.addToCart(lblSKU.Text.Trim(), lblproductName.Text, lblprice.Text.Trim(), lblWholesalePrice.Text.Trim());
        }

    }
}
