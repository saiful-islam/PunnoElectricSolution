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
    public partial class ReportDue : Form
    {
        DataOperation objDataOperation;
        public ReportDue()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
            LoadreportDue();
        }

        private void LoadreportDue()
        {
            string _query = "Exec [desktop].[Report_OrderDue]";
            gvDue.DataSource = objDataOperation.GetDataTable(_query);
        }
    }
}
