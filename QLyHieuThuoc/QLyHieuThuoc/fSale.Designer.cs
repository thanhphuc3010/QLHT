
namespace QLyHieuThuoc
{
    partial class fSale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgrMedicineList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.cbMedicineId = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStaffId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCustomerId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dptInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbIn = new System.Windows.Forms.Button();
            this.txtSeltment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotalAmout = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMedicineList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dgrMedicineList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 678);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Chi tiết hóa đơn";
            // 
            // dgrMedicineList
            // 
            this.dgrMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMedicineList.Location = new System.Drawing.Point(24, 394);
            this.dgrMedicineList.Name = "dgrMedicineList";
            this.dgrMedicineList.RowHeadersWidth = 51;
            this.dgrMedicineList.RowTemplate.Height = 24;
            this.dgrMedicineList.Size = new System.Drawing.Size(924, 272);
            this.dgrMedicineList.TabIndex = 5;
            this.dgrMedicineList.DoubleClick += new System.EventHandler(this.dgrMedicineList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddMedicine);
            this.panel2.Controls.Add(this.cbMedicineId);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtUnit);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(24, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 121);
            this.panel2.TabIndex = 4;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(735, 65);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(123, 48);
            this.btnAddMedicine.TabIndex = 26;
            this.btnAddMedicine.Text = "Thêm sản phẩm";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // cbMedicineId
            // 
            this.cbMedicineId.FormattingEnabled = true;
            this.cbMedicineId.Location = new System.Drawing.Point(99, 33);
            this.cbMedicineId.Name = "cbMedicineId";
            this.cbMedicineId.Size = new System.Drawing.Size(189, 24);
            this.cbMedicineId.TabIndex = 18;
            this.cbMedicineId.SelectedIndexChanged += new System.EventHandler(this.cbMedicineId_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(441, 65);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(189, 22);
            this.txtPrice.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Đơn giá";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(441, 33);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(189, 22);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số lượng";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(99, 65);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(189, 22);
            this.txtUnit.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Đơn vị tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã Thuốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhập thông tin thuốc";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cbStaffId);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.cbCustomerId);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtpDueDate);
            this.panel4.Controls.Add(this.dptInvoiceDate);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtPhoneNumber);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtInvoiceId);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(24, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 136);
            this.panel4.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(735, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 22);
            this.txtAddress.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(583, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Địa chỉ:";
            // 
            // cbStaffId
            // 
            this.cbStaffId.FormattingEnabled = true;
            this.cbStaffId.Location = new System.Drawing.Point(164, 98);
            this.cbStaffId.Name = "cbStaffId";
            this.cbStaffId.Size = new System.Drawing.Size(189, 24);
            this.cbStaffId.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nhân viên:";
            // 
            // cbCustomerId
            // 
            this.cbCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomerId.FormattingEnabled = true;
            this.cbCustomerId.Location = new System.Drawing.Point(735, 12);
            this.cbCustomerId.Name = "cbCustomerId";
            this.cbCustomerId.Size = new System.Drawing.Size(189, 24);
            this.cbCustomerId.TabIndex = 15;
            this.cbCustomerId.SelectedIndexChanged += new System.EventHandler(this.cbCustomerId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên khách hàng:";
            // 
            // dptInvoiceDate
            // 
            this.dptInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dptInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptInvoiceDate.Location = new System.Drawing.Point(164, 38);
            this.dptInvoiceDate.Name = "dptInvoiceDate";
            this.dptInvoiceDate.Size = new System.Drawing.Size(189, 22);
            this.dptInvoiceDate.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(735, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txbThue_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(583, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(735, 72);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txbThue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Location = new System.Drawing.Point(164, 12);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(189, 22);
            this.txtInvoiceId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(176, 46);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 42);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 42);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbIn);
            this.panel3.Controls.Add(this.txtTotalAmout);
            this.panel3.Controls.Add(this.txtTaxAmount);
            this.panel3.Controls.Add(this.txtTax);
            this.panel3.Controls.Add(this.txtSeltment);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(2, 690);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 114);
            this.panel3.TabIndex = 22;
            // 
            // txbIn
            // 
            this.txbIn.Location = new System.Drawing.Point(305, 46);
            this.txbIn.Name = "txbIn";
            this.txbIn.Size = new System.Drawing.Size(123, 42);
            this.txbIn.TabIndex = 26;
            this.txbIn.Text = "In";
            this.txbIn.UseVisualStyleBackColor = true;
            // 
            // txtSeltment
            // 
            this.txtSeltment.Location = new System.Drawing.Point(809, 83);
            this.txtSeltment.Name = "txtSeltment";
            this.txtSeltment.Size = new System.Drawing.Size(139, 22);
            this.txtSeltment.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(637, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tổng tiền thanh toán:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(645, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Thành tiền:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(736, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(189, 22);
            this.txtAmount.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày đáo hạn";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(164, 70);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(189, 22);
            this.dtpDueDate.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(637, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Thuế (%): ";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(741, 50);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(43, 22);
            this.txtTax.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(637, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Tổng tiền: ";
            // 
            // txtTotalAmout
            // 
            this.txtTotalAmout.Location = new System.Drawing.Point(809, 22);
            this.txtTotalAmout.Name = "txtTotalAmout";
            this.txtTotalAmout.Size = new System.Drawing.Size(139, 22);
            this.txtTotalAmout.TabIndex = 25;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(808, 50);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(140, 22);
            this.txtTaxAmount.TabIndex = 25;
            // 
            // fSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 802);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fSale";
            this.Text = "Hóa đơn bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSale_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fSale_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMedicineList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dptInvoiceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgrMedicineList;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMedicineId;
        private System.Windows.Forms.ComboBox cbStaffId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCustomerId;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSeltment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button txbIn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalAmout;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label19;
    }
}