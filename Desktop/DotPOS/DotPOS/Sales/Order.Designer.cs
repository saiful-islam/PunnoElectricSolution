namespace DotPOS.Sales
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.gvItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaceOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.dtPickerExpectedPayment = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gvItems
            // 
            this.gvItems.AllowUserToAddRows = false;
            this.gvItems.AllowUserToDeleteRows = false;
            this.gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItems.Location = new System.Drawing.Point(3, 47);
            this.gvItems.Margin = new System.Windows.Forms.Padding(2);
            this.gvItems.Name = "gvItems";
            this.gvItems.ReadOnly = true;
            this.gvItems.RowTemplate.Height = 24;
            this.gvItems.Size = new System.Drawing.Size(563, 301);
            this.gvItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(113, 404);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(263, 23);
            this.txtCustomer.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(113, 434);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 43);
            this.txtAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txtMobile
            // 
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(113, 481);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(263, 23);
            this.txtMobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mobile";
            // 
            // txtPlaceOrder
            // 
            this.txtPlaceOrder.Location = new System.Drawing.Point(476, 546);
            this.txtPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaceOrder.Name = "txtPlaceOrder";
            this.txtPlaceOrder.Size = new System.Drawing.Size(86, 29);
            this.txtPlaceOrder.TabIndex = 10;
            this.txtPlaceOrder.Text = "Place Order";
            this.txtPlaceOrder.UseVisualStyleBackColor = true;
            this.txtPlaceOrder.Click += new System.EventHandler(this.txtPlaceOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(493, 470);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "............................................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discount";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(493, 388);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 25);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sub Total ";
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(358, 546);
            this.txtCancel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(86, 29);
            this.txtCancel.TabIndex = 11;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Items";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(493, 423);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(50, 25);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "0.00";
            // 
            // dtPickerExpectedPayment
            // 
            this.dtPickerExpectedPayment.CustomFormat = "dd-mm-yyyy";
            this.dtPickerExpectedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerExpectedPayment.Location = new System.Drawing.Point(158, 554);
            this.dtPickerExpectedPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerExpectedPayment.Name = "dtPickerExpectedPayment";
            this.dtPickerExpectedPayment.Size = new System.Drawing.Size(157, 23);
            this.dtPickerExpectedPayment.TabIndex = 9;
            this.dtPickerExpectedPayment.Visible = false;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 556);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(138, 15);
            this.lblPaymentDate.TabIndex = 24;
            this.lblPaymentDate.Text = "Expected Payment Date";
            this.lblPaymentDate.Visible = false;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(113, 352);
            this.cbPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(202, 24);
            this.cbPaymentMethod.TabIndex = 2;
            this.cbPaymentMethod.Visible = false;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Payment Method";
            this.label11.Visible = false;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(383, 363);
            this.txtCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(180, 23);
            this.txtCard.TabIndex = 3;
            this.txtCard.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(399, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Order # ";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(488, 11);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(23, 25);
            this.lblOrder.TabIndex = 28;
            this.lblOrder.Text = "0";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(399, 501);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(46, 25);
            this.lblPayment.TabIndex = 21;
            this.lblPayment.Text = "Pay";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(446, 505);
            this.txtCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(116, 23);
            this.txtCash.TabIndex = 8;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Due",
            "Paid"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(112, 514);
            this.cbPaymentStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(202, 24);
            this.cbPaymentStatus.TabIndex = 7;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(12, 516);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(92, 15);
            this.lblPaymentStatus.TabIndex = 19;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(112, 374);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(165, 23);
            this.txtSearchCustomer.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 377);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Find by Customer";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(283, 374);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 23);
            this.btnLoad.TabIndex = 31;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(547, 423);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "%";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 590);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtPickerExpectedPayment);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlaceOrder);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtPlaceOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DateTimePicker dtPickerExpectedPayment;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label10;
    }
}