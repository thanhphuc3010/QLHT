
namespace QLyHieuThuoc
{
    partial class fNSX
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dmNSX = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSdtNSX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDChiNSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenNSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaNSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeySearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmNSX)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dmNSX);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1626, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1225, 168);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 50);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1128, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dmNSX
            // 
            this.dmNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmNSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dmNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dmNSX.Location = new System.Drawing.Point(22, 322);
            this.dmNSX.Name = "dmNSX";
            this.dmNSX.RowHeadersWidth = 51;
            this.dmNSX.RowTemplate.Height = 24;
            this.dmNSX.Size = new System.Drawing.Size(1594, 260);
            this.dmNSX.TabIndex = 3;
            this.dmNSX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dmNSX_CellContentClick);
            this.dmNSX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dmNSX_MouseUp);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1031, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 50);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKeySearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txbemail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txbSdtNSX);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txbDChiNSX);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbTenNSX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbMaNSX);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(161, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 221);
            this.panel2.TabIndex = 2;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(1056, 103);
            this.txbemail.Multiline = true;
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(257, 31);
            this.txbemail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(902, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // txbSdtNSX
            // 
            this.txbSdtNSX.Location = new System.Drawing.Point(1056, 13);
            this.txbSdtNSX.Multiline = true;
            this.txbSdtNSX.Name = "txbSdtNSX";
            this.txbSdtNSX.Size = new System.Drawing.Size(257, 31);
            this.txbSdtNSX.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(902, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // txbDChiNSX
            // 
            this.txbDChiNSX.Location = new System.Drawing.Point(214, 117);
            this.txbDChiNSX.Multiline = true;
            this.txbDChiNSX.Name = "txbDChiNSX";
            this.txbDChiNSX.Size = new System.Drawing.Size(386, 31);
            this.txbDChiNSX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txbTenNSX
            // 
            this.txbTenNSX.Location = new System.Drawing.Point(214, 62);
            this.txbTenNSX.Multiline = true;
            this.txbTenNSX.Name = "txbTenNSX";
            this.txbTenNSX.Size = new System.Drawing.Size(386, 31);
            this.txbTenNSX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhà sản xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbMaNSX
            // 
            this.txbMaNSX.Location = new System.Drawing.Point(214, 3);
            this.txbMaNSX.Multiline = true;
            this.txbMaNSX.Name = "txbMaNSX";
            this.txbMaNSX.Size = new System.Drawing.Size(386, 31);
            this.txbMaNSX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhà sản xuất";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(934, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC NHÀ SẢN XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeySearch.Location = new System.Drawing.Point(214, 187);
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Size = new System.Drawing.Size(386, 31);
            this.txtKeySearch.TabIndex = 18;
            this.txtKeySearch.TextChanged += new System.EventHandler(this.txtKeySearch_TextChanged);
            this.txtKeySearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeySearch_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tìm kiếm: ";
            // 
            // fNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 609);
            this.Controls.Add(this.panel1);
            this.Name = "fNSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fNSX_FormClosing);
            this.Load += new System.EventHandler(this.fNSX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmNSX)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dmNSX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSdtNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDChiNSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKeySearch;
        private System.Windows.Forms.Label label7;
    }
}