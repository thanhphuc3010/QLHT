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
    public partial class fType : Form
    {
        public fType()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void fType_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void fType_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = " SELECT * FROM tbl_DMLoaiThuoc";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dmLoaiThuoc.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINERT = "INSERT INTO tbl_DMLoaiThuoc VALUES (@MaThuoc, @TenLoaiThuoc)";
            SqlCommand cmd = new SqlCommand(sqlINERT, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMa.Text);
            cmd.Parameters.AddWithValue("TenLoaiThuoc", txbTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE tbl_DMLoaiThuoc SET MaThuoc=  @MaThuoc,TenLoaiThuoc =  @TenLoaiThuoc";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMa.Text);
            cmd.Parameters.AddWithValue("TenLoaiThuoc", txbTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM tbl_DMLoaiThuoc WHERE MaThuoc = @MaThuoc, TenLoaiThuoc = @TenLoaiThuoc";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaThuoc", txbMa.Text);
            cmd.Parameters.AddWithValue("TenLoaiThuoc", txbTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
