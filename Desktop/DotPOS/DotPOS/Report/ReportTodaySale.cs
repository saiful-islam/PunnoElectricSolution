﻿using DotPOS.Service;
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
    public partial class ReportTodaySale : Form
    {
        DataOperation objDataOperation;
        int totalIndex = 0, totalRowIndex = 0;
        public ReportTodaySale()
        {
            InitializeComponent();
            objDataOperation = new DataOperation();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string _query = "exec desktop.Report_CategoryWiseTodaySale @OrderDate='" + dtpOrderDate.Value.ToString("yyyy-MM-dd") + "'";
            gvTodaySale.DataSource = objDataOperation.GetDataTable(_query);
        }

        private void gvTodaySale_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                if (e.RowIndex < 1 || e.ColumnIndex < 0)
                    return;
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = gvTodaySale.AdvancedCellBorderStyle.Top;
                }
            }
            
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = gvTodaySale[column, row];
            DataGridViewCell cell2 = gvTodaySale[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void gvTodaySale_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == 0)
                    return;
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
            if (e.Value.ToString().Contains(" # Total"))
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
            if (e.Value.ToString().Contains("z # Total"))
            {
                e.CellStyle.BackColor = Color.CornflowerBlue;
                totalRowIndex = e.RowIndex;
                lblTotalCash.Text = gvTodaySale.Rows[e.RowIndex].Cells["Payment"].Value.ToString();
            }
            if (totalRowIndex > 0 && e.RowIndex == totalRowIndex)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.CornflowerBlue;
            }
        }
    }
}
