
namespace QLyHieuThuoc
{
    partial class fImport
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvCTNhap = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpPODate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPoID = new System.Windows.Forms.TextBox();
            this.txtMakeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMakeId = new System.Windows.Forms.ComboBox();
            this.gbMedicine = new System.Windows.Forms.GroupBox();
            this.cbMedicineId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStaffId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDeletePO = new System.Windows.Forms.Button();
            this.btnSavePO = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhap)).BeginInit();
            this.panel4.SuspendLayout();
            this.gbMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbMedicine);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpPODate);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 668);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvCTNhap);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(0, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1006, 256);
            this.panel5.TabIndex = 19;
            // 
            // dgvCTNhap
            // 
            this.dgvCTNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTNhap.Location = new System.Drawing.Point(19, 26);
            this.dgvCTNhap.Name = "dgvCTNhap";
            this.dgvCTNhap.RowHeadersWidth = 51;
            this.dgvCTNhap.RowTemplate.Height = 24;
            this.dgvCTNhap.Size = new System.Drawing.Size(987, 217);
            this.dgvCTNhap.TabIndex = 19;
            this.dgvCTNhap.DoubleClick += new System.EventHandler(this.dgvCTNhap_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Chi tiết phiếu nhập";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 224);
            this.panel3.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(879, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 41);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(779, 147);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 41);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(679, 147);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 41);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(785, 90);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(189, 31);
            this.txtAmount.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(675, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Thành tiền:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(451, 90);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(189, 31);
            this.txtQuantity.TabIndex = 27;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số lượng: ";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(451, 45);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(189, 31);
            this.txtUnit.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Đơn vị tính:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(104, 90);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.ReadOnly = true;
            this.txtMedicineName.Size = new System.Drawing.Size(224, 31);
            this.txtMedicineName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã thuốc";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(785, 47);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(189, 31);
            this.txtCost.TabIndex = 21;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(675, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 19;
<<<<<<< HEAD
            this.label12.Text = "Giá vốn:";
=======
            this.label12.Text = "Đơn giá";

>>>>>>> parent of 636b571... Hưng commit
            // 
            // dtpPODate
            // 
            this.dtpPODate.CustomFormat = "dd/MM/yyyy";
            this.dtpPODate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPODate.Location = new System.Drawing.Point(483, 34);
            this.dtpPODate.Name = "dtpPODate";
            this.dtpPODate.Size = new System.Drawing.Size(155, 30);
            this.dtpPODate.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbStaffId);
            this.panel4.Controls.Add(this.cbMakeId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtPoID);
            this.panel4.Controls.Add(this.txtMakeName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(19, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 108);
            this.panel4.TabIndex = 2;
            // 
            // txtPoID
            // 
<<<<<<< HEAD
            this.txtPoID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPoID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPoID.Location = new System.Drawing.Point(121, 16);
            this.txtPoID.Name = "txtPoID";
            this.txtPoID.ReadOnly = true;
            this.txtPoID.Size = new System.Drawing.Size(248, 30);
            this.txtPoID.TabIndex = 1;
=======
            this.txbMaThuoc.Location = new System.Drawing.Point(173, 16);
            this.txbMaThuoc.Name = "txbMaThuoc";
            this.txbMaThuoc.Size = new System.Drawing.Size(261, 22);
            this.txbMaThuoc.TabIndex = 1;
           
>>>>>>> parent of 636b571... Hưng commit
            // 
            // txtMakeName
            // 
            this.txtMakeName.Location = new System.Drawing.Point(731, 57);
            this.txtMakeName.Name = "txtMakeName";
            this.txtMakeName.ReadOnly = true;
            this.txtMakeName.Size = new System.Drawing.Size(247, 30);
            this.txtMakeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số chứng từ: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(563, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã nhà sản xuất:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(563, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhà sản xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHIẾU NHẬP HÀNG";
            // 
            // cbMakeId
            // 
            this.cbMakeId.DropDownHeight = 50;
            this.cbMakeId.FormattingEnabled = true;
            this.cbMakeId.IntegralHeight = false;
            this.cbMakeId.ItemHeight = 23;
            this.cbMakeId.Location = new System.Drawing.Point(731, 16);
            this.cbMakeId.Name = "cbMakeId";
            this.cbMakeId.Size = new System.Drawing.Size(247, 31);
            this.cbMakeId.TabIndex = 4;
            this.cbMakeId.SelectedIndexChanged += new System.EventHandler(this.cbMakeId_SelectedIndexChanged);
            // 
            // gbMedicine
            // 
            this.gbMedicine.Controls.Add(this.cbMedicineId);
            this.gbMedicine.Controls.Add(this.label9);
            this.gbMedicine.Controls.Add(this.btnSave);
            this.gbMedicine.Controls.Add(this.label12);
            this.gbMedicine.Controls.Add(this.txtCost);
            this.gbMedicine.Controls.Add(this.btnEdit);
            this.gbMedicine.Controls.Add(this.btnThem);
            this.gbMedicine.Controls.Add(this.label8);
            this.gbMedicine.Controls.Add(this.txtAmount);
            this.gbMedicine.Controls.Add(this.txtMedicineName);
            this.gbMedicine.Controls.Add(this.label13);
            this.gbMedicine.Controls.Add(this.label5);
            this.gbMedicine.Controls.Add(this.txtUnit);
            this.gbMedicine.Controls.Add(this.label6);
            this.gbMedicine.Controls.Add(this.txtQuantity);
            this.gbMedicine.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicine.Location = new System.Drawing.Point(19, 184);
            this.gbMedicine.Name = "gbMedicine";
            this.gbMedicine.Size = new System.Drawing.Size(987, 210);
            this.gbMedicine.TabIndex = 20;
            this.gbMedicine.TabStop = false;
            this.gbMedicine.Text = "Thông tin thuốc";
            // 
            // cbMedicineId
            // 
            this.cbMedicineId.FormattingEnabled = true;
            this.cbMedicineId.Location = new System.Drawing.Point(104, 44);
            this.cbMedicineId.Name = "cbMedicineId";
            this.cbMedicineId.Size = new System.Drawing.Size(224, 33);
            this.cbMedicineId.TabIndex = 36;
            this.cbMedicineId.SelectedIndexChanged += new System.EventHandler(this.cbMedicineId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày nhập:";
            // 
            // cbStaffId
            // 
            this.cbStaffId.FormattingEnabled = true;
            this.cbStaffId.Location = new System.Drawing.Point(121, 57);
            this.cbStaffId.Name = "cbStaffId";
            this.cbStaffId.Size = new System.Drawing.Size(248, 31);
            this.cbStaffId.TabIndex = 4;
            this.cbStaffId.SelectedIndexChanged += new System.EventHandler(this.cbMakeId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(650, 693);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 47;
            this.label17.Text = "Tổng tiền";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(303, 784);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 41);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "In Phiếu Nhập";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDeletePO
            // 
            this.btnDeletePO.Location = new System.Drawing.Point(166, 784);
            this.btnDeletePO.Name = "btnDeletePO";
            this.btnDeletePO.Size = new System.Drawing.Size(116, 41);
            this.btnDeletePO.TabIndex = 56;
            this.btnDeletePO.Text = "Huỷ";
            this.btnDeletePO.UseVisualStyleBackColor = true;
            this.btnDeletePO.Click += new System.EventHandler(this.btnDeletePO_Click);
            // 
            // btnSavePO
            // 
            this.btnSavePO.Location = new System.Drawing.Point(29, 784);
            this.btnSavePO.Name = "btnSavePO";
            this.btnSavePO.Size = new System.Drawing.Size(116, 41);
            this.btnSavePO.TabIndex = 57;
            this.btnSavePO.Text = "Hoàn thành";
            this.btnSavePO.UseVisualStyleBackColor = true;
            this.btnSavePO.Click += new System.EventHandler(this.btnSavePO_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(822, 688);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(189, 30);
            this.txtTotalAmount.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(650, 731);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Thuế";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(822, 726);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(189, 30);
            this.txtTax.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(650, 805);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 51;
            this.label18.Text = "Số tiền thanh toán";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(822, 800);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(189, 30);
            this.txtPayment.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(650, 769);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "Chiết khấu:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(822, 764);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(189, 30);
            this.txtDiscount.TabIndex = 54;
            // 
            // fImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 865);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDeletePO);
            this.Controls.Add(this.btnSavePO);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.panel1);
            this.Name = "fImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập hàng";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.fImport_Load);
=======
>>>>>>> parent of 636b571... Hưng commit
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhap)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbMedicine.ResumeLayout(false);
            this.gbMedicine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPODate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvCTNhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMakeId;
        private System.Windows.Forms.GroupBox gbMedicine;
        private System.Windows.Forms.ComboBox cbMedicineId;
        private System.Windows.Forms.ComboBox cbStaffId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDeletePO;
        private System.Windows.Forms.Button btnSavePO;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}