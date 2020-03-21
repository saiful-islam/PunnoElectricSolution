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
    public partial class ReportStock : Form
    {
        DataOperation objDataOperation;
        public ReportStock()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            LoadreportStock();
        }

        private void LoadreportStock()
        {
            string _query = "Exec [desktop].[SP_CategoryWiseStock] 1";
            gvStock.DataSource = objDataOperation.GetDataTable(_query);
        }
    }
}
