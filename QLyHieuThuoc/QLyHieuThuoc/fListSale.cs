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
    public partial class fListSale : Form
    {
        private SqlConnection con;
        public fListSale()
        {
            InitializeComponent();
        }

        private void fListSale_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
           
            
        }
        public void HienThi()
        {
            string query = "SELECT tbl_DMKhachHang.TenKh, tbl_HDBan.SoHD, tbl_HDBan.NgayHD, tbl_HDBan.Thue, tbl_NhanVien.TenNV, tbl_NhanVien.MaNV FROM tbl_HDBan LEFT JOIN tbl_NhanVien ON tbl_NhanVien.MaNV = tbl_HDBan.MaNV LEFT JOIN tbl_DMKhachHang ON tbl_HDBan.MaKH  = tbl_DMKhachHang.MaKH";
            Database db = new Database();
            drgListSale.DataSource = db.excuteQuery(query);
        }

        private void fListSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
