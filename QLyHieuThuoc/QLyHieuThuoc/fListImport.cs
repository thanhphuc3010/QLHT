using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyHieuThuoc
{
    public partial class fListImport : Form
    {
        private SqlConnection con;
        public fListImport()
        {
            InitializeComponent();
        }

        private void fListImport_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string query = " SELECT tbl_PhieuNhap.SoCT, tbl_PhieuNhap.NgayCt, tbl_PhieuNhap.HanThanhToan, tbl_PhieuNhap.Thue, tbl_PhieuNhap.ChietKhau, tbl_NhanVien.TenNV, tbl_DMNhaSX.TenNhaSX  FROM tbl_PhieuNhap LEFT JOIN tbl_NhanVien  ON tbl_NhanVien.MaNV = tbl_PhieuNhap.MaNV LEFT JOIN tbl_DMNhaSX ON  tbl_PhieuNhap.MaNhaSX = tbl_DMNhaSX.MaNhaSX ";
            Database db = new Database();
            drgListImport.DataSource = db.excuteQuery(query);
        }

        private void fListImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

























        }
    }
}
