using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLyHieuThuoc
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void fStaff_Load(object sender, EventArgs e)
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

        private void fStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
            
        }
        public void HienThi()
        {
            string sqlSELECT = " SELECT * FROM tbl_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            drgDSNV.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINERT = "INSERT INTO tbl_NhanVien VALUES(@MaNV, @TenNV, @DiaChiNV, @SDTNV)";
            SqlCommand cmd = new SqlCommand(sqlINERT, con);
            cmd.Parameters.AddWithValue("MaNV", txbMaNV.Text);
            cmd.Parameters.AddWithValue("TenNV", txbTenNV.Text);
            cmd.Parameters.AddWithValue("DiaChiNV", txbDiaChiNV.Text);
            cmd.Parameters.AddWithValue("SDTNV", txbSDTNV.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE tbl_NhanVien SET MaNV = @MaNV, tenNV = @TenNV, DiaChiNV = @DiaChiNV, SDTNV = @SDTNV WHERE MaNV = @MaNV  ";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaNV", txbMaNV.Text);
            cmd.Parameters.AddWithValue("TenNV", txbTenNV.Text);
            cmd.Parameters.AddWithValue("DiaChiNV", txbDiaChiNV.Text);
            cmd.Parameters.AddWithValue("SDTNV", txbSDTNV.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM tbl_NhanVien WHERE MaNV= @MaNV ";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaNV", txbMaNV.Text);
            cmd.Parameters.AddWithValue("TenNV", txbTenNV.Text);
            cmd.Parameters.AddWithValue("DiaChiNV", txbDiaChiNV.Text);
            cmd.Parameters.AddWithValue("SDTNV", txbSDTNV.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
        public void loadData()
        {
            int i = drgDSNV.CurrentRow.Index;
            txbTenNV.Text = drgDSNV.Rows[i].Cells["TenNV"].Value.ToString();
            txbMaNV.Text = drgDSNV.Rows[i].Cells["MaNV"].Value.ToString();
            txbDiaChiNV.Text = drgDSNV.Rows[i].Cells["DiaChiNV"].Value.ToString();
            txbSDTNV.Text = drgDSNV.Rows[i].Cells["SDTNV"].Value.ToString();

        }

        private void drgDSNV_MouseUp(object sender, MouseEventArgs e)
        {
            loadData();
        }
    }
}
