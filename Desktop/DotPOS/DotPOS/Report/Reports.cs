using DotPOS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace DotPOS.Report
{
    public partial class Reports : Form
    {
        DataOperation objDataOperation;
        int totalIndex = 0;
        public Reports()
        {
            InitializeComponent();
            btnCategoryProfit.Visible = MainWindow.IsProfitAccess;
            objDataOperation = new DataOperation();
            LoadTodayCash();
        }
        private void LoadTodayCash()
        {
            string _query = "Exec [desktop].[Report_Cash] @CashDate='" + dtpCashDate.Value.ToString("yyyy-MM-dd") + "'";
            gvCashReceived.DataSource = objDataOperation.GetDataTable(_query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTodaySale_Click(object sender, EventArgs e)
        {
            ReportTodaySale obj = new ReportTodaySale();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void btnCategoryProfit_Click(object sender, EventArgs e)
        {
            ReportProfit obj = new ReportProfit();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTodayCash();
        }

        private void gvCashReceived_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.ToString().Contains("Total"))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.Coral;
                totalIndex = e.RowIndex;
            }
            if (totalIndex > 0 && e.RowIndex == totalIndex)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.Coral;
            }
        }

        private void btnOrderDue_Click(object sender, EventArgs e)
        {
            ReportDue objDue = new ReportDue();
            this.Hide();
            objDue.ShowDialog();
            this.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ReportStock objDue = new ReportStock();
            this.Hide();
            objDue.ShowDialog();
            this.Show();
        }
    }
}
