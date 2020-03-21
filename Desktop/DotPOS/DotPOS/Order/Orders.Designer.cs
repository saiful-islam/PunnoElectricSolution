namespace DotPOS.Order
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.dropdownPaymentStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.gvOrderItems = new System.Windows.Forms.DataGridView();
            this.gboxOrder = new System.Windows.Forms.GroupBox();
            this.lblProductCost = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gvPayment = new System.Windows.Forms.DataGridView();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtPickerExpectedPayment = new System.Windows.Forms.DateTimePicker();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderItems)).BeginInit();
            this.gboxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdownPaymentStatus
            // 
            this.dropdownPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownPaymentStatus.FormattingEnabled = true;
            this.dropdownPaymentStatus.Items.AddRange(new object[] {
            "Due",
            "Paid"});
            this.dropdownPaymentStatus.Location = new System.Drawing.Point(376, 26);
            this.dropdownPaymentStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownPaymentStatus.Name = "dropdownPaymentStatus";
            this.dropdownPaymentStatus.Size = new System.Drawing.Size(104, 24);
            this.dropdownPaymentStatus.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dropdownPaymentStatus);
            this.groupBox1.Location = new System.Drawing.Point(-2, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(722, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Thistle;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(623, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 37);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Thistle;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(508, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Payment Status";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(65, 26);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(139, 23);
            this.txtOrderId.TabIndex = 3;
            this.txtOrderId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOrderId_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // gvOrders
            // 
            this.gvOrders.AllowUserToAddRows = false;
            this.gvOrders.AllowUserToDeleteRows = false;
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Location = new System.Drawing.Point(15, 85);
            this.gvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.ReadOnly = true;
            this.gvOrders.RowTemplate.Height = 24;
            this.gvOrders.Size = new System.Drawing.Size(380, 227);
            this.gvOrders.TabIndex = 3;
            this.gvOrders.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gvOrders_RowStateChanged);
            // 
            // gvOrderItems
            // 
            this.gvOrderItems.AllowUserToAddRows = false;
            this.gvOrderItems.AllowUserToDeleteRows = false;
            this.gvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderItems.Location = new System.Drawing.Point(4, 21);
            this.gvOrderItems.Margin = new System.Windows.Forms.Padding(2);
            this.gvOrderItems.Name = "gvOrderItems";
            this.gvOrderItems.ReadOnly = true;
            this.gvOrderItems.RowTemplate.Height = 24;
            this.gvOrderItems.Size = new System.Drawing.Size(306, 212);
            this.gvOrderItems.TabIndex = 4;
            // 
            // gboxOrder
            // 
            this.gboxOrder.Controls.Add(this.lblProductCost);
            this.gboxOrder.Controls.Add(this.lblProfit);
            this.gboxOrder.Controls.Add(this.label15);
            this.gboxOrder.Controls.Add(this.txtDiscount);
            this.gboxOrder.Controls.Add(this.btnReturn);
            this.gboxOrder.Controls.Add(this.lblDue);
            this.gboxOrder.Controls.Add(this.label18);
            this.gboxOrder.Controls.Add(this.lblPaid);
            this.gboxOrder.Controls.Add(this.label16);
            this.gboxOrder.Controls.Add(this.label14);
            this.gboxOrder.Controls.Add(this.gvPayment);
            this.gboxOrder.Controls.Add(this.txtCard);
            this.gboxOrder.Controls.Add(this.cbPaymentMethod);
            this.gboxOrder.Controls.Add(this.label11);
            this.gboxOrder.Controls.Add(this.lblPaymentDate);
            this.gboxOrder.Controls.Add(this.dtPickerExpectedPayment);
            this.gboxOrder.Controls.Add(this.txtCash);
            this.gboxOrder.Controls.Add(this.label10);
            this.gboxOrder.Controls.Add(this.cbPaymentStatus);
            this.gboxOrder.Controls.Add(this.label9);
            this.gboxOrder.Controls.Add(this.lblTotal);
            this.gboxOrder.Controls.Add(this.label4);
            this.gboxOrder.Controls.Add(this.label5);
            this.gboxOrder.Controls.Add(this.label6);
            this.gboxOrder.Controls.Add(this.lblSubTotal);
            this.gboxOrder.Controls.Add(this.label7);
            this.gboxOrder.Controls.Add(this.btnPay);
            this.gboxOrder.Controls.Add(this.txtMobile);
            this.gboxOrder.Controls.Add(this.label8);
            this.gboxOrder.Controls.Add(this.txtAddress);
            this.gboxOrder.Controls.Add(this.label12);
            this.gboxOrder.Controls.Add(this.txtCustomer);
            this.gboxOrder.Controls.Add(this.label13);
            this.gboxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOrder.Location = new System.Drawing.Point(15, 331);
            this.gboxOrder.Margin = new System.Windows.Forms.Padding(2);
            this.gboxOrder.Name = "gboxOrder";
            this.gboxOrder.Padding = new System.Windows.Forms.Padding(2);
            this.gboxOrder.Size = new System.Drawing.Size(704, 273);
            this.gboxOrder.TabIndex = 5;
            this.gboxOrder.TabStop = false;
            this.gboxOrder.Text = "Order Details";
            // 
            // lblProductCost
            // 
            this.lblProductCost.AutoSize = true;
            this.lblProductCost.Location = new System.Drawing.Point(288, 237);
            this.lblProductCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCost.Name = "lblProductCost";
            this.lblProductCost.Size = new System.Drawing.Size(16, 17);
            this.lblProductCost.TabIndex = 60;
            this.lblProductCost.Text = "0";
            this.lblProductCost.Visible = false;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(606, 161);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(50, 25);
            this.lblProfit.TabIndex = 59;
            this.lblProfit.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(499, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 22);
            this.label15.TabIndex = 58;
            this.label15.Text = "Profit";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(385, 80);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(102, 23);
            this.txtDiscount.TabIndex = 57;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(526, 196);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 46);
            this.btnReturn.TabIndex = 56;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(381, 141);
            this.lblDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(50, 25);
            this.lblDue.TabIndex = 55;
            this.lblDue.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(284, 141);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 25);
            this.label18.TabIndex = 54;
            this.label18.Text = "Due";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(606, 132);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(50, 25);
            this.lblPaid.TabIndex = 53;
            this.lblPaid.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(497, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 22);
            this.label16.TabIndex = 52;
            this.label16.Text = "Total Paid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(493, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Payment History";
            // 
            // gvPayment
            // 
            this.gvPayment.AllowUserToAddRows = false;
            this.gvPayment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayment.Location = new System.Drawing.Point(496, 19);
            this.gvPayment.Margin = new System.Windows.Forms.Padding(2);
            this.gvPayment.Name = "gvPayment";
            this.gvPayment.ReadOnly = true;
            this.gvPayment.RowTemplate.Height = 24;
            this.gvPayment.Size = new System.Drawing.Size(200, 111);
            this.gvPayment.TabIndex = 5;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(266, 8);
            this.txtCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(221, 23);
            this.txtCard.TabIndex = 30;
            this.txtCard.Visible = false;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(105, 9);
            this.cbPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(155, 24);
            this.cbPaymentMethod.TabIndex = 28;
            this.cbPaymentMethod.Visible = false;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Payment Method";
            this.label11.Visible = false;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(1, 178);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(108, 15);
            this.lblPaymentDate.TabIndex = 49;
            this.lblPaymentDate.Text = "Exp Payment Date";
            this.lblPaymentDate.Visible = false;
            // 
            // dtPickerExpectedPayment
            // 
            this.dtPickerExpectedPayment.CustomFormat = "dd-mm-yyyy";
            this.dtPickerExpectedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerExpectedPayment.Location = new System.Drawing.Point(111, 174);
            this.dtPickerExpectedPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerExpectedPayment.Name = "dtPickerExpectedPayment";
            this.dtPickerExpectedPayment.Size = new System.Drawing.Size(157, 23);
            this.dtPickerExpectedPayment.TabIndex = 37;
            this.dtPickerExpectedPayment.Visible = false;
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(332, 172);
            this.txtCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(116, 23);
            this.txtCash.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Pay";
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Due",
            "Paid"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(102, 142);
            this.cbPaymentStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(155, 24);
            this.cbPaymentStatus.TabIndex = 35;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Payment Status";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(381, 116);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 25);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "............................................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Discount";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(381, 49);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 25);
            this.lblSubTotal.TabIndex = 40;
            this.lblSubTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sub Total ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(365, 198);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(87, 32);
            this.btnPay.TabIndex = 39;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(104, 109);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(155, 23);
            this.txtMobile.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mobile";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(104, 77);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 23);
            this.txtAddress.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Address";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(104, 47);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(155, 23);
            this.txtCustomer.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Customer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvOrderItems);
            this.groupBox3.Location = new System.Drawing.Point(400, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(320, 243);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Items";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gboxOrder);
            this.Controls.Add(this.gvOrders);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Orders";
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderItems)).EndInit();
            this.gboxOrder.ResumeLayout(false);
            this.gboxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox dropdownPaymentStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.DataGridView gvOrderItems;
        private System.Windows.Forms.GroupBox gboxOrder;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpectedPayment;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gvPayment;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblProductCost;
    }
}