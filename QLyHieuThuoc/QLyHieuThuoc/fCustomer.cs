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
    public partial class fCustomer : Form
    {
        private SqlConnection con;
        public Boolean isAdd = true, isSave = false;
        public fCustomer()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void fCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = " SELECT * FROM tbl_DMKhachHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            drgDMKH.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetAllFieldsBlank();
            btnThem.Text = "Lưu";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void resetAllFieldsBlank()
        {
            txbTenKH.Text = "";
            txbMaKH.Text = "";
            txbDiaChiKH.Text = "";
            txbSDTKH.Text = "";
            txbEmail.Text = "";
            checkKhachLe.Checked = false;
            checkDVTC.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE tbl_DMKhachHang SET MaKH = @MaKH, tenKH = @TenKH,LoaiDT =  @LoaiDT, DChiKH = @DChiKH, SdtKH = @SdtKH,Email = @Email WHERE MaKH = @MaKH  ";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaKH", txbMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txbTenKH.Text);
            //cmd.Parameters.AddWithValue("LoaiDT", txbLoaiDT.Text);
            cmd.Parameters.AddWithValue("DChiKH", txbDiaChiKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txbSDTKH.Text);
            cmd.Parameters.AddWithValue("Email", txbEmail.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM tbl_DMKhachHang WHERE MaKH= @MaKH ";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaKH", txbMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txbTenKH.Text);
            //cmd.Parameters.AddWithValue("LoaiDT", txbLoaiDT.Text);
            cmd.Parameters.AddWithValue("DChiKH", txbDiaChiKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txbSDTKH.Text);
            cmd.Parameters.AddWithValue("Email", txbEmail.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "DELETE FROM tbl_DMKhachHang WHERE MaKH= @MaKH ";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaKH", txbMaCanTim.Text);
            cmd.Parameters.AddWithValue("TenKH", txbTenKH.Text);
            //cmd.Parameters.AddWithValue("LoaiDT", txbLoaiDT.Text);
            cmd.Parameters.AddWithValue("DChiKH", txbDiaChiKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txbSDTKH.Text);
            cmd.Parameters.AddWithValue("Email", txbEmail.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            drgDMKH.DataSource = dt;
        }

        public void loadData()
        {
            int i = drgDMKH.CurrentRow.Index;
            txbTenKH.Text = drgDMKH.Rows[i].Cells["TenKH"].Value.ToString();
            txbMaKH.Text = drgDMKH.Rows[i].Cells["MaKH"].Value.ToString();
            txbDiaChiKH.Text = drgDMKH.Rows[i].Cells["DChiKH"].Value.ToString();
            txbSDTKH.Text = drgDMKH.Rows[i].Cells["SdtKH"].Value.ToString();
            txbEmail.Text = drgDMKH.Rows[i].Cells["Email"].Value.ToString();

            Boolean typeChecked = Convert.ToBoolean(drgDMKH.Rows[i].Cells["LoaiDT"].Value);
            if (typeChecked == true)
            {
                checkKhachLe.Checked = true;
                checkDVTC.Checked = false;
            } else
            {
                checkKhachLe.Checked = false;
                checkDVTC.Checked = true;
            }

        }

        private void drgDMKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        private void cbKhachLe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int customerType;
            string sqlINERT = "INSERT INTO tbl_DMKhachHang VALUES (@MaKH, @TenKH, @LoaiDT, @DChiKH, @SdtKH, @Email)";
            SqlCommand cmd = new SqlCommand(sqlINERT, con);
            cmd.Parameters.AddWithValue("MaKH", txbMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txbTenKH.Text);

            if (checkKhachLe.Checked == true)
            {
                customerType = 1;
            }
            else customerType = 0;

            cmd.Parameters.AddWithValue("LoaiDT", customerType);
            cmd.Parameters.AddWithValue("DChiKH", txbDiaChiKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txbSDTKH.Text);
            cmd.Parameters.AddWithValue("Email", txbEmail.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void drgDMKH_MouseUp(object sender, MouseEventArgs e)
        {
            loadData();
        }
    }
}
