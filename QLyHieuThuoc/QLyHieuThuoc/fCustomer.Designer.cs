
namespace QLyHieuThuoc
{
    partial class fCustomer
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
            this.txtKeySearch = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.drgDMKH = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSDTKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDiaChiKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkDVTC = new System.Windows.Forms.CheckBox();
            this.checkKhachLe = new System.Windows.Forms.CheckBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgDMKH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKeySearch);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.drgDMKH);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 595);
            this.panel1.TabIndex = 0;
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.Location = new System.Drawing.Point(23, 276);
            this.txtKeySearch.Multiline = true;
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Size = new System.Drawing.Size(423, 31);
            this.txtKeySearch.TabIndex = 14;
            this.txtKeySearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMaCanTim_KeyUp);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(829, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(721, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 50);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(499, 262);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 50);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(613, 262);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 50);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // drgDMKH
            // 
            this.drgDMKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgDMKH.Location = new System.Drawing.Point(23, 318);
            this.drgDMKH.Name = "drgDMKH";
            this.drgDMKH.RowHeadersWidth = 51;
            this.drgDMKH.RowTemplate.Height = 24;
            this.drgDMKH.Size = new System.Drawing.Size(897, 261);
            this.drgDMKH.TabIndex = 9;
            this.drgDMKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgDMKH_CellContentClick);
            this.drgDMKH.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drgDMKH_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbEmail);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbSDTKH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbDiaChiKH);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(499, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 171);
            this.panel3.TabIndex = 8;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(144, 106);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(277, 25);
            this.txbEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txbSDTKH
            // 
            this.txbSDTKH.Location = new System.Drawing.Point(144, 60);
            this.txbSDTKH.Multiline = true;
            this.txbSDTKH.Name = "txbSDTKH";
            this.txbSDTKH.Size = new System.Drawing.Size(277, 25);
            this.txbSDTKH.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // txbDiaChiKH
            // 
            this.txbDiaChiKH.Location = new System.Drawing.Point(144, 13);
            this.txbDiaChiKH.Multiline = true;
            this.txbDiaChiKH.Name = "txbDiaChiKH";
            this.txbDiaChiKH.Size = new System.Drawing.Size(277, 25);
            this.txbDiaChiKH.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkDVTC);
            this.panel2.Controls.Add(this.checkKhachLe);
            this.panel2.Controls.Add(this.lblCustomerType);
            this.panel2.Controls.Add(this.txbTenKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbMaKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 171);
            this.panel2.TabIndex = 2;
            // 
            // checkDVTC
            // 
            this.checkDVTC.AutoSize = true;
            this.checkDVTC.Location = new System.Drawing.Point(257, 108);
            this.checkDVTC.Name = "checkDVTC";
            this.checkDVTC.Size = new System.Drawing.Size(120, 21);
            this.checkDVTC.TabIndex = 10;
            this.checkDVTC.Text = "Đơn vị tổ chức";
            this.checkDVTC.UseVisualStyleBackColor = true;
            // 
            // checkKhachLe
            // 
            this.checkKhachLe.AutoSize = true;
            this.checkKhachLe.Location = new System.Drawing.Point(144, 108);
            this.checkKhachLe.Name = "checkKhachLe";
            this.checkKhachLe.Size = new System.Drawing.Size(85, 21);
            this.checkKhachLe.TabIndex = 9;
            this.checkKhachLe.Text = "Khách lẻ";
            this.checkKhachLe.UseVisualStyleBackColor = true;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(3, 106);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(131, 20);
            this.lblCustomerType.TabIndex = 8;
            this.lblCustomerType.Text = "Loại khách hàng";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(144, 60);
            this.txbTenKH.Multiline = true;
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(233, 25);
            this.txbTenKH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // txbMaKH
            // 
            this.txbMaKH.Location = new System.Drawing.Point(144, 13);
            this.txbMaKH.Multiline = true;
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(233, 25);
            this.txbMaKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.panel1);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCustomer_FormClosing);
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgDMKH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSDTKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDiaChiKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView drgDMKH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.TextBox txtKeySearch;
        private System.Windows.Forms.CheckBox checkDVTC;
        private System.Windows.Forms.CheckBox checkKhachLe;
        private System.Windows.Forms.Button btnLuu;
    }
}