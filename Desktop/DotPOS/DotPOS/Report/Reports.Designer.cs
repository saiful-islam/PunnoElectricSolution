namespace DotPOS.Report
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.button1 = new System.Windows.Forms.Button();
            this.btnTodaySale = new System.Windows.Forms.Button();
            this.btnCategoryProfit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvCashReceived = new System.Windows.Forms.DataGridView();
            this.dtpCashDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOrderDue = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTodaySale
            // 
            this.btnTodaySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodaySale.Location = new System.Drawing.Point(24, 42);
            this.btnTodaySale.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodaySale.Name = "btnTodaySale";
            this.btnTodaySale.Size = new System.Drawing.Size(289, 84);
            this.btnTodaySale.TabIndex = 1;
            this.btnTodaySale.Text = " Today Sale";
            this.btnTodaySale.UseVisualStyleBackColor = true;
            this.btnTodaySale.Click += new System.EventHandler(this.btnTodaySale_Click);
            // 
            // btnCategoryProfit
            // 
            this.btnCategoryProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryProfit.Location = new System.Drawing.Point(24, 152);
            this.btnCategoryProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoryProfit.Name = "btnCategoryProfit";
            this.btnCategoryProfit.Size = new System.Drawing.Size(289, 84);
            this.btnCategoryProfit.TabIndex = 2;
            this.btnCategoryProfit.Text = "Profit";
            this.btnCategoryProfit.UseVisualStyleBackColor = true;
            this.btnCategoryProfit.Click += new System.EventHandler(this.btnCategoryProfit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvCashReceived);
            this.groupBox1.Controls.Add(this.dtpCashDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(346, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(395, 565);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash";
            // 
            // gvCashReceived
            // 
            this.gvCashReceived.AllowUserToAddRows = false;
            this.gvCashReceived.AllowUserToDeleteRows = false;
            this.gvCashReceived.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvCashReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCashReceived.Location = new System.Drawing.Point(8, 110);
            this.gvCashReceived.Margin = new System.Windows.Forms.Padding(2);
            this.gvCashReceived.Name = "gvCashReceived";
            this.gvCashReceived.ReadOnly = true;
            this.gvCashReceived.RowTemplate.Height = 24;
            this.gvCashReceived.Size = new System.Drawing.Size(382, 446);
            this.gvCashReceived.TabIndex = 8;
            this.gvCashReceived.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvCashReceived_CellFormatting);
            // 
            // dtpCashDate
            // 
            this.dtpCashDate.Location = new System.Drawing.Point(108, 31);
            this.dtpCashDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCashDate.Name = "dtpCashDate";
            this.dtpCashDate.Size = new System.Drawing.Size(284, 26);
            this.dtpCashDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cash Date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(268, 60);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOrderDue
            // 
            this.btnOrderDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDue.Location = new System.Drawing.Point(24, 258);
            this.btnOrderDue.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderDue.Name = "btnOrderDue";
            this.btnOrderDue.Size = new System.Drawing.Size(289, 84);
            this.btnOrderDue.TabIndex = 5;
            this.btnOrderDue.Text = "Order Due";
            this.btnOrderDue.UseVisualStyleBackColor = true;
            this.btnOrderDue.Click += new System.EventHandler(this.btnOrderDue_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(24, 367);
            this.btnStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(289, 84);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 609);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnOrderDue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCategoryProfit);
            this.Controls.Add(this.btnTodaySale);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashReceived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTodaySale;
        private System.Windows.Forms.Button btnCategoryProfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpCashDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCashReceived;
        private System.Windows.Forms.Button btnOrderDue;
        private System.Windows.Forms.Button btnStock;
    }
}