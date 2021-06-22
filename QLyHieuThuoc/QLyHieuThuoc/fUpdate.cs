using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLyHieuThuoc
{
    public partial class fUpdate : Form
    {
        public fUpdate()
        {
            InitializeComponent();
        }

        SqlConnection con;

       
        private void fUpdate_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }


        private SqlConnection newSqlconnection(string conString)
        {
            throw new NotImplementedException();
        }


        private void fUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = " SELECT * FROM tbl_Thuoc";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsThuoc.DataSource = dt;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINERT = "INSERT INTO tbl_Thuoc VALUES (@MaThuoc, @TenThuoc, @HamLuong, @DonViTinh, @SoLuong, @SoDK, @ThanhPhan, @NgaySX, @HSD, @NoiSX, @DonGIa, @DongGoi, @MaNhaSX)";
            SqlCommand cmd = new SqlCommand(sqlINERT, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMaThuoc.Text);
            cmd.Parameters.AddWithValue("TenThuoc", txbTenThuoc.Text);
            cmd.Parameters.AddWithValue("HamLuong", txbHamLuong.Text);
            cmd.Parameters.AddWithValue("DonViTinh", txbDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txbSoLuong.Text);
            cmd.Parameters.AddWithValue("SoDK", txbSoDangKy.Text);
            cmd.Parameters.AddWithValue("ThanhPhan", txbThanhPhan.Text);
            cmd.Parameters.AddWithValue("NgaySX", txbNgaySanXuat.Text);
            cmd.Parameters.AddWithValue("HSD", txbHanSuDung.Text);
            cmd.Parameters.AddWithValue("NoiSX", txbNoiSanXuat.Text);
            cmd.Parameters.AddWithValue("DonGia", txbDonGia.Text);
            cmd.Parameters.AddWithValue("DongGoi", txbDongGoi.Text);
            cmd.Parameters.AddWithValue("MaNhaSX", txbNhaSanXuat.Text);
            cmd.ExecuteNonQuery();
            HienThi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE tbl_Thuoc SET MaThuoc=  @MaThuoc,TenThuoc =  @TenThuoc, HamLuong =  @HamLuong,DonViTinh =  @DonViTinh, SoLuong =  @SoLuong, SoDK =  @SoDK, ThanhPhan =  @ThanhPhan, NgaySX = @NgaySX, HSD = @HSD, NoiSX = @NoiSX, DonGia = @DonGIa,DongGoi = @DongGoi, MaNhaSX = @MaNhaSX WHERE MaThuoc = @MaThuoc";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMaThuoc.Text);
            cmd.Parameters.AddWithValue("TenThuoc", txbTenThuoc.Text);
            cmd.Parameters.AddWithValue("HamLuong", txbHamLuong.Text);
            cmd.Parameters.AddWithValue("DonViTinh", txbDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txbSoLuong.Text);
            cmd.Parameters.AddWithValue("SoDK", txbSoDangKy.Text);
            cmd.Parameters.AddWithValue("ThanhPhan", txbThanhPhan.Text);
            cmd.Parameters.AddWithValue("NgaySX", txbNgaySanXuat.Text);
            cmd.Parameters.AddWithValue("HSD", txbHanSuDung.Text);
            cmd.Parameters.AddWithValue("NoiSX", txbNoiSanXuat.Text);
            cmd.Parameters.AddWithValue("DonGia", txbDonGia.Text);
            cmd.Parameters.AddWithValue("DongGoi", txbDongGoi.Text);
            cmd.Parameters.AddWithValue("MaNhaSX", txbNhaSanXuat.Text);
            cmd.ExecuteNonQuery();
            HienThi();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM tbl_Thuoc WHERE MaThuoc = @MaThuoc";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMaThuoc.Text);
            cmd.Parameters.AddWithValue("TenThuoc", txbTenThuoc.Text);
            cmd.Parameters.AddWithValue("HamLuong", txbHamLuong.Text);
            cmd.Parameters.AddWithValue("DonViTinh", txbDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txbSoLuong.Text);
            cmd.Parameters.AddWithValue("SoDK", txbSoDangKy.Text);
            cmd.Parameters.AddWithValue("ThanhPhan", txbThanhPhan.Text);
            cmd.Parameters.AddWithValue("NgaySX", txbNgaySanXuat.Text);
            cmd.Parameters.AddWithValue("HSD", txbHanSuDung.Text);
            cmd.Parameters.AddWithValue("NoiSX", txbNoiSanXuat.Text);
            cmd.Parameters.AddWithValue("DonGia", txbDonGia.Text);
            cmd.Parameters.AddWithValue("DongGoi", txbDongGoi.Text);
            cmd.Parameters.AddWithValue("MaNhaSX", txbNhaSanXuat.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dsThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        
    }
}
