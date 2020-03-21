using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace DotPOS.Order
{
    public partial class Orders : Form
    {
        DataOperation objDataOperation;
        DataTable dtOrderItems = new DataTable();
        DataTable dtOrderPayment = new DataTable();
        DataTable dtCustomer = new DataTable();
        string orderId = "";
        public Orders()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            cbPaymentMethod.SelectedItem = "Cash";
            cbPaymentStatus.SelectedItem = "Due";
            dropdownPaymentStatus.SelectedItem = "Due";
            LoadOrderGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrderGrid();
            clear();
        }
        private void clear()
        {
            gvOrderItems.DataSource = null;
            gvPayment.DataSource = null;
            cbPaymentMethod.SelectedItem = "Cash";
            cbPaymentStatus.SelectedItem = "Due";
            txtCustomer.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            lblPaid.Text = "0.00";
            txtDiscount.Text = "0.00";
            lblTotal.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblDue.Text = "";
            btnPay.Enabled = true;
            txtCash.Text = "0.00";
            gboxOrder.Text = "Order Details";
        }
        private void LoadOrderGrid()
        {
            string _query = "exec [desktop].[GETOrdersForGrid] @paymentStatus='" + dropdownPaymentStatus.SelectedItem.ToString() + "', @OrderId='" + txtOrderId.Text.Trim() + "'";
            DataSet ds = objDataOperation.GetDataSet(_query);
            gvOrders.DataSource = ds.Tables[0];
            dtOrderItems = ds.Tables[1];
            dtOrderPayment = ds.Tables[2];
            dtCustomer = ds.Tables[3];
        }
        private void txtOrderId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadOrderGrid();
                clear();
                txtOrderId.Focus();
            }
        }

        private void gvOrders_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            orderId = e.Row.Cells["Id"].Value.ToString();
            gboxOrder.Text = "Order Details # " + orderId;
            DataTable _dtOrderItems = dtOrderItems.Copy();
            DataRow[] drr = _dtOrderItems.Select("OrderId <> ' " + orderId + " ' ");
            for (int i = 0; i < drr.Length; i++)
                drr[i].Delete();
            _dtOrderItems.AcceptChanges();
            gvOrderItems.DataSource = _dtOrderItems;
            
            //Payment
            DataTable _dtOrderPayment = dtOrderPayment.Copy();
            DataRow[] drr1 = _dtOrderPayment.Select("OrderId <> ' " + orderId + " ' ");
            for (int i = 0; i < drr1.Length; i++)
                drr1[i].Delete();
            _dtOrderPayment.AcceptChanges();
            gvPayment.DataSource = _dtOrderPayment;
            string sumObject = _dtOrderPayment.Compute("Sum(Payment)", string.Empty).ToString();
            lblPaid.Text = sumObject.Trim() == string.Empty ? "0.00" : sumObject;
            txtDiscount.Text = e.Row.Cells["Discount"].Value.ToString();
            lblTotal.Text = e.Row.Cells["Order_Total"].Value.ToString();
            lblSubTotal.Text = (Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(txtDiscount.Text)).ToString();
            lblDue.Text = (Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblPaid.Text)).ToString();

            if (Convert.ToDouble(lblDue.Text) == 0.00)
            {
                btnPay.Enabled = false;
                cbPaymentStatus.SelectedItem = "Paid";
            }
            else
            {
                btnPay.Enabled = true;
                cbPaymentStatus.SelectedItem = "Due";
            }

            //Customer
            DataTable _dtCustomer = dtCustomer.Copy();
            DataRow[] drr2 = _dtCustomer.Select("OrderId <> ' " + orderId + " ' ");
            for (int i = 0; i < drr2.Length; i++)
                drr2[i].Delete();
            _dtCustomer.AcceptChanges();
            txtCustomer.Text = _dtCustomer.Rows[0]["CustomerName"].ToString();
            txtAddress.Text = _dtCustomer.Rows[0]["CustomerAddress"].ToString();
            txtMobile.Text = _dtCustomer.Rows[0]["CustomerMobileNo"].ToString();

            //Profit

            object sumProductCost;
            sumProductCost = _dtOrderItems.Compute("Sum(ProductCost)", string.Empty);
            lblProductCost.Text = sumProductCost.ToString();
            lblProfit.Text= (Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblProductCost.Text)).ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentMethod.Text == "Card")
            {
                txtCard.Visible = true;
            }
            else
            {
                txtCard.Visible = false;
            }
        }

        private void cbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentStatus.Text == "Due")
            {
                lblPaymentDate.Visible = true;
                dtPickerExpectedPayment.Visible = true;
                txtCash.Text = "0.00";
                txtCash.Enabled = true;
            }
            else
            {
                lblPaymentDate.Visible = false;
                dtPickerExpectedPayment.Visible = false;
                txtCash.Text = lblDue.Text;
                txtCash.Enabled = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to " + txtCash.Text + " Taka pay for this order ??",
                                    "Confirm Payment!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (txtCash.Text.Trim() != string.Empty)
                {
                    string _query = "exec [desktop].[InsertOrderPayment] @OrderId='" + orderId + "',@payment=" + txtCash.Text.Trim() + ",@OrderTotal=" + lblTotal.Text + ",@Discount=" + txtDiscount.Text.Trim() + "";
                    if (cbPaymentStatus.Text == "Due" && Convert.ToDecimal(lblDue.Text) != Convert.ToDecimal(txtCash.Text))
                    {
                        _query += ",@ExpectedPaymentDate='" + dtPickerExpectedPayment.Value + "'";
                    }
                    if (cbPaymentMethod.Text == "Card" && txtCard.Text.Trim() != string.Empty)
                    {
                        _query += ",@CardNumber='" + txtCard.Text.Trim() + "'";
                    }
                    else if (cbPaymentMethod.Text == "Card")
                    {
                        MessageBox.Show("Please enter card number");
                        return;
                    }
                    string res = objDataOperation.ExecuteNonQuery(_query);
                    if (res == "1")
                    {
                        btnRefresh_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(res);
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Return order # " + orderId + " ??",
                                    "Confirm Payment!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string _query = "exec [desktop].[OrderReturn] @OrderId=" + orderId;
                string res = objDataOperation.ExecuteNonQuery(_query);
                if (res == "1")
                {
                    btnRefresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double discount;
            double.TryParse(txtDiscount.Text, out discount);
            if (discount > 0)
            {
                lblTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();
                lblDue.Text = (Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblPaid.Text)).ToString();
                lblProfit.Text = (Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblProductCost.Text)).ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string htmlCode=CreateHtmlOrderDetails();
            WebBrowserPrint objPrint = new WebBrowserPrint(htmlCode);
            this.Hide();
            objPrint.ShowDialog();
            this.Show();
        }
        private string CreateHtmlOrderDetails()
        {
            string htmlBody = @"<!DOCTYPE html>
                        <html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
                        <head>
                            <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
                            <meta http-equiv=""X-UA-Compatible"" content=""IE=8"">
                            <title>bcl_424300587.htm</title>
                            <meta name=""generator"" content=""BCL easyConverter SDK 5.0.140"">
                            <style type=""text/css"">
                                body {
                                    margin-top: 0px;
                                    margin-left: 0px;
                                }

                                #page_1 {
                                    position: relative;
                                    overflow: hidden;
                                    margin: 47px 0px 148px 48px;
                                    padding: 0px;
                                    border: none;
                                    width: 745px;
                                }

                                    #page_1 #p1dimg1 {
                                        position: absolute;
                                        top: 4px;
                                        left: 550px;
                                        z-index: -1;
                                        width: 87px;
                                        height: 542px;
                                    }

                                        #page_1 #p1dimg1 #p1img1 {
                                            width: 150px;
                                            height: 50px;
                                        }




                                .ft0 {
                                    font: bold 13px 'Arial';
                                    line-height: 16px;
                                }

                                .ft1 {
                                    font: bold 13px 'Arial';
                                    line-height: 14px;
                                }

                                .ft2 {
                                    font: bold 13px 'Arial';
                                    line-height: 13px;
                                }

                                .ft3 {
                                    font: 1px 'Arial';
                                    line-height: 1px;
                                }

                                .ft4 {
                                    font: 13px 'Arial';
                                    line-height: 16px;
                                }

                                .ft5 {
                                    font: 12px 'Arial';
                                    line-height: 15px;
                                }

                                .ft6 {
                                    font: 11px 'Arial';
                                    line-height: 14px;
                                }

                                .ft7 {
                                    font: 13px 'MS PGothic';
                                    line-height: 13px;
                                }

                                .ft8 {
                                    font: 12px 'MS PGothic';
                                    line-height: 12px;
                                }

                                .ft9 {
                                    font: bold 11px 'MS PGothic';
                                    line-height: 11px;
                                }

                                .ft10 {
                                    font: bold 11px 'Arial';
                                    line-height: 14px;
                                }

                                .ft11 {
                                    font: bold 12px 'Arial';
                                    line-height: 15px;
                                }

                                .ft12 {
                                    font: 16px 'Helvetica';
                                    line-height: 18px;
                                }

                                .ft13 {
                                    font: bold 13px 'MS PGothic';
                                    line-height: 13px;
                                }

                                .p0 {
                                    text-align: left;
                                    padding-left: 3px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                }

                                .p1 {
                                    text-align: left;
                                    padding-left: 3px;
                                    padding-right: 309px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                }

                                .p2 {
                                    text-align: left;
                                    padding-left: 3px;
                                    padding-right: 201px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                }

                                .p3 {
                                    text-align: left;
                                    padding-left: 5px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p4 {
                                    text-align: left;
                                    padding-left: 39px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p5 {
                                    text-align: left;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p6 {
                                    text-align: left;
                                    padding-left: 15px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p7 {
                                    text-align: left;
                                    padding-left: 49px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p8 {
                                    text-align: left;
                                    padding-left: 3px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p9 {
                                    text-align: left;
                                    padding-left: 141px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p10 {
                                    text-align: left;
                                    padding-left: 38px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p11 {
                                    text-align: right;
                                    padding-right: 6px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p12 {
                                    text-align: right;
                                    padding-right: 38px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p13 {
                                    text-align: left;
                                    padding-left: 2px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p14 {
                                    text-align: right;
                                    padding-right: 42px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p15 {
                                    text-align: right;
                                    padding-right: 46px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p16 {
                                    text-align: right;
                                    padding-right: 3px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p17 {
                                    text-align: left;
                                    margin-top: 28px;
                                    margin-bottom: 0px;
                                }

                                .p18 {
                                    text-align: left;
                                    padding-left: 3px;
                                    margin-top: 19px;
                                    margin-bottom: 0px;
                                }

                                .p19 {
                                    text-align: right;
                                    padding-right: 25px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p20 {
                                    text-align: left;
                                    padding-left: 37px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p21 {
                                    text-align: right;
                                    padding-right: 61px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p22 {
                                    text-align: left;
                                    padding-left: 1px;
                                    margin-top: 0px;
                                    margin-bottom: 0px;
                                    white-space: nowrap;
                                }

                                .p23 {
                                    text-align: left;
                                    padding-left: 584px;
                                    margin-top: 3px;
                                    margin-bottom: 0px;
                                }

                                .p24 {
                                    text-align: left;
                                    padding-left: 608px;
                                    margin-top: 3px;
                                    margin-bottom: 0px;
                                }

                                .p25 {
                                    text-align: left;
                                    padding-left: 574px;
                                    margin-top: 2px;
                                    margin-bottom: 0px;
                                }

                                .p26 {
                                    text-align: left;
                                    padding-left: 599px;
                                    margin-top: 3px;
                                    margin-bottom: 0px;
                                }

                                .p27 {
                                    text-align: left;
                                    padding-left: 612px;
                                    margin-top: 3px;
                                    margin-bottom: 0px;
                                }

                                .td0 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 315px;
                                    vertical-align: bottom;
                                }

                                .td1 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 209px;
                                    vertical-align: bottom;
                                }

                                .td2 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 50px;
                                    vertical-align: bottom;
                                }

                                .td3 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 20px;
                                    vertical-align: bottom;
                                }

                                .td4 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 104px;
                                    vertical-align: bottom;
                                }

                                .td5 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 105px;
                                    vertical-align: bottom;
                                }

                                .td6 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 315px;
                                    vertical-align: bottom;
                                }

                                .td7 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 104px;
                                    vertical-align: bottom;
                                }

                                .td8 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 105px;
                                    vertical-align: bottom;
                                }

                                .td9 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 50px;
                                    vertical-align: bottom;
                                }

                                .td10 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 20px;
                                    vertical-align: bottom;
                                }

                                .td11 {
                                    border-left: #000000 1px solid;
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 313px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td12 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 103px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td13 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 104px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td14 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 50px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td15 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 19px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td16 {
                                    border-left: #000000 1px solid;
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 313px;
                                    vertical-align: bottom;
                                }

                                .td17 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 103px;
                                    vertical-align: bottom;
                                }

                                .td18 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 104px;
                                    vertical-align: bottom;
                                }

                                .td19 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 19px;
                                    vertical-align: bottom;
                                }

                                .td20 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 124px;
                                    vertical-align: bottom;
                                }

                                .td21 {
                                    padding: 0px;
                                    margin: 0px;
                                    width: 70px;
                                    vertical-align: bottom;
                                }

                                .td22 {
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 70px;
                                    vertical-align: bottom;
                                }

                                .td23 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 69px;
                                    vertical-align: bottom;
                                    background: #c0c0c0;
                                }

                                .td24 {
                                    border-right: #000000 1px solid;
                                    border-bottom: #000000 1px solid;
                                    padding: 0px;
                                    margin: 0px;
                                    width: 69px;
                                    vertical-align: bottom;
                                }

                                .tr0 {
                                    height: 26px;
                                }

                                .tr1 {
                                    height: 18px;
                                }

                                .tr2 {
                                    height: 19px;
                                }

                                .tr3 {
                                    height: 21px;
                                }

                                .tr4 {
                                    height: 40px;
                                }

                                .tr5 {
                                    height: 45px;
                                }

                                .tr6 {
                                    height: 20px;
                                }

                                .tr7 {
                                    height: 17px;
                                }

                                .tr8 {
                                    height: 23px;
                                }

                                .tr9 {
                                    height: 22px;
                                }

                                .t0 {
                                    width: 698px;
                                    margin-top: 11px;
                                    font: 13px 'Arial';
                                }

                                .t1 {
                                    width: 698px;
                                    margin-top: 12px;
                                    font: 13px 'Arial';
                                }
                            </style>
                        </head>
                        <body>
                            <div id=""page_1"">
                                <div id=""p1dimg1"">
                                    <img src=""data:image/png;base64,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"" id=""p1img1"">
                                </div>";
            htmlBody += @"<p class=""p0 ft0"">Order_D# " + orderId + "</p>";
            htmlBody += @"<p class=""p0 ft0"">Punno Electric Solution</p>
                        <p class=""p1 ft1"">Shop- 249,Kaptan Bazar Complex -1(Ground Floor)</p>
                        <p class=""p2 ft2"">Nawabpur, Gulistan Dhaka-1000. Telephone: +8802-95550806, Cell: 01750015999, 01711192970 </p>
                        <p class=""p2 ft2"">Email: punnoelectricsolution@gmail.com, syed07.rahat@gmail.com</p>
                        <p class=""p0 ft0"">Date:" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "</p>";
            htmlBody += @"<table cellpadding=""0"" cellspacing=""0"" class=""t0"">
                            <tbody>
                                <tr>
                                    <td class=""tr0 td0""><p class=""p3 ft0"">Billing Information:</p></td>
                                    <td class=""tr0 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                                    <td class=""tr0 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                                    <td class=""tr0 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                                </tr>
                                <tr>
                                    <td class=""tr1 td0""><p class=""p6 ft4"">Name: " + txtCustomer.Text.Trim() + "</p></td>";
            htmlBody += @" <td class=""tr1 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p6 ft4"">Phone: " + txtMobile.Text.Trim() + "</p></td>";
            htmlBody += @"
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p6 ft4"">Address: " + txtAddress.Text.Trim() + "</p></td>";
            htmlBody += @"
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr3 td0""><p class=""p6 ft4"">Payment method: " + cbPaymentMethod.Text + "</p></td>";
            htmlBody += @"
                    <td class=""tr3 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr3 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr3 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr5 td0""><p class=""p8 ft0"">Product(s)</p></td>
                    <td class=""tr5 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr6 td6""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td7""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td8""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td9""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td10""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td7""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr7 td11""><p class=""p9 ft4"">Name</p></td>
                    <td class=""tr7 td12""><p class=""p10 ft4"">SKU</p></td>
                    <td class=""tr7 td13""><p class=""p10 ft4"">Price</p></td>
                    <td class=""tr7 td14""><p class=""p11 ft4"">Qty</p></td>
                    <td class=""tr7 td15""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr7 td12""><p class=""p12 ft4"">Total</p></td>
                </tr>";
            foreach (DataGridViewRow r in gvOrderItems.Rows)
            {
                htmlBody += @"<tr>
                                <td class=""tr8 td16""><p class=""p3 ft4"">" + r.Cells["Name"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td17""><p class=""p10 ft4"">" + r.Cells["Sku"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td18""><p class=""p13 ft4""><span class=""ft7"">৳ </span>" + r.Cells["UnitPrice"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td9""><p class=""p14 ft4"">" + r.Cells["Quantity"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td19""><p class=""p5 ft3"">&nbsp;</p></td>";
                htmlBody += @"<td class=""tr8 td17""><p class=""p15 ft5""><span class=""ft8"">৳ </span>" + r.Cells["Price"].Value + "</p></td>";
                htmlBody += @"</tr>";
            }
            htmlBody += @"<tr>
                    <td class=""tr9 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td colspan=""2"" class=""tr9 td20""><p class=""p16 ft4""><nobr>Sub-total:</nobr> <span class=""ft7"">৳ </span>" + lblSubTotal.Text + "</p></td>";
            htmlBody += @"</tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p16 ft4"">Discount: <span class=""ft7"">৳ </span>" + txtDiscount.Text + "</p></td>";
            htmlBody += @"</tr>
                <tr>
                    <td class=""tr1 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td colspan=""2"" class=""tr1 td20""><p class=""p16 ft10"">Order total: <span class=""ft9"">৳ </span>" + lblTotal.Text + "</p></td>";
            double due = Convert.ToDouble(lblTotal.Text) - Convert.ToDouble(txtCash.Text);
            htmlBody += @" </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p16 ft11"">Total Paid: <span class=""ft9"">৳ </span>" + txtCash.Text.Trim() + "</p></td>";
            htmlBody += @"</tr>
                          <tr>
                            <td class=""tr6 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td4""><p class=""p16 ft0"">Due: <span class=""ft9"">৳ </span>" + due + "</p></td>";
            htmlBody += @"</tr>
                        </tbody>
                    </table>";


            htmlBody += "<hr>";

            //2nd part
            htmlBody += @"<p class=""p0 ft0"">Order_D# " + orderId + "</p>";
            htmlBody += @"<p class=""p0 ft0"">Date:" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "</p>";
            htmlBody += @"<table cellpadding=""0"" cellspacing=""0"" class=""t0"">
                            <tbody>
                                <tr>
                                    <td class=""tr0 td0""><p class=""p3 ft0"">Billing Information:</p></td>
                                    <td class=""tr0 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                                    <td class=""tr0 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                                    <td class=""tr0 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                                </tr>
                                <tr>
                                    <td class=""tr1 td0""><p class=""p6 ft4"">Name: " + txtCustomer.Text.Trim() + "</p></td>";
            htmlBody += @" <td class=""tr1 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p6 ft4"">Phone: " + txtMobile.Text.Trim() + "</p></td>";
            htmlBody += @"
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p6 ft4"">Address: " + txtAddress.Text.Trim() + "</p></td>";
            htmlBody += @"
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                
                <tr>
                    <td class=""tr5 td0""><p class=""p8 ft0"">Product(s)</p></td>
                    <td class=""tr5 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr5 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr6 td6""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td7""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td8""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td9""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td10""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr6 td7""><p class=""p5 ft3"">&nbsp;</p></td>
                </tr>
                <tr>
                    <td class=""tr7 td11""><p class=""p9 ft4"">Name</p></td>
                    <td class=""tr7 td12""><p class=""p10 ft4"">SKU</p></td>
                    <td class=""tr7 td13""><p class=""p10 ft4"">Price</p></td>
                    <td class=""tr7 td14""><p class=""p11 ft4"">Qty</p></td>
                    <td class=""tr7 td15""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr7 td12""><p class=""p12 ft4"">Total</p></td>
                </tr>";
            foreach (DataGridViewRow r in gvOrderItems.Rows)
            {
                htmlBody += @"<tr>
                                <td class=""tr8 td16""><p class=""p3 ft4"">" + r.Cells["Name"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td17""><p class=""p10 ft4"">" + r.Cells["Sku"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td18""><p class=""p13 ft4""><span class=""ft7"">৳ </span>" + r.Cells["UnitPrice"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td9""><p class=""p14 ft4"">" + r.Cells["Quantity"].Value + "</p></td>";
                htmlBody += @"<td class=""tr8 td19""><p class=""p5 ft3"">&nbsp;</p></td>";
                htmlBody += @"<td class=""tr8 td17""><p class=""p15 ft5""><span class=""ft8"">৳ </span>" + r.Cells["Price"].Value + "</p></td>";
                htmlBody += @"</tr>";
            }
            htmlBody += @"<tr>
                    <td class=""tr9 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr9 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td colspan=""2"" class=""tr9 td20""><p class=""p16 ft4""><nobr>Sub-total:</nobr> <span class=""ft7"">৳ </span>" + lblSubTotal.Text + "</p></td>";
            htmlBody += @"</tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p16 ft4"">Discount: <span class=""ft7"">৳ </span>" + txtDiscount.Text + "</p></td>";
            htmlBody += @"</tr>
                <tr>
                    <td class=""tr1 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr1 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td colspan=""2"" class=""tr1 td20""><p class=""p16 ft10"">Order total: <span class=""ft9"">৳ </span>" + lblTotal.Text + "</p></td>";
            due = Convert.ToDouble(lblTotal.Text) - Convert.ToDouble(txtCash.Text);
            htmlBody += @" </tr>
                <tr>
                    <td class=""tr2 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                    <td class=""tr2 td4""><p class=""p16 ft11"">Total Paid: <span class=""ft9"">৳ </span>" + txtCash.Text.Trim() + "</p></td>";
            htmlBody += @"</tr>
                          <tr>
                            <td class=""tr6 td0""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td4""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td5""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td2""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td3""><p class=""p5 ft3"">&nbsp;</p></td>
                            <td class=""tr6 td4""><p class=""p16 ft0"">Due: <span class=""ft9"">৳ </span>" + due + "</p></td>";
            htmlBody += @"</tr>
                        </tbody>
                    </table>";

            return htmlBody;
        }
    }
}
