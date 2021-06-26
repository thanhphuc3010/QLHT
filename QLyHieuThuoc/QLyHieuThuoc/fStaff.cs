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
        public Boolean isAddFlag = false;

        private void fStaff_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            loadDataTotext();
            disableAllField();
            btnLuu.Enabled = false;
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
            string query = " SELECT * FROM tbl_NhanVien";
            Database db = new Database();
            drgDSNV.DataSource = db.excuteQuery(query);

        }
        private void disableAllField()
        {
            txbMaNV.ReadOnly = true;
            txbMaNV.Enabled = false;
            txbTenNV.ReadOnly = true;
            txbSDTNV.ReadOnly = true;          
            txbDiaChiNV.ReadOnly = true;
        }
        private void enableAllField()
        {
            txbMaNV.ReadOnly = true;
            txbMaNV.Enabled = false;
            txbTenNV.ReadOnly = false;
            txbSDTNV.ReadOnly = false;
            txbDiaChiNV.ReadOnly = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            enableAllField();
            resetAllFieldsBlank();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            isAddFlag = true;
            txbMaNV.Text = autoCreateID();
            txbMaNV.ReadOnly = true;
            disableDgrEvent();
        }
        public void resetAllFieldsBlank()
        {
            txbTenNV.Text = "";
            txbMaNV.Text = "";
            txbDiaChiNV.Text = "";
            txbSDTNV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableAllField();
            txbMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            disableDgrEvent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_NhanVien WHERE MaNV = @MaNV";

            Database db = new Database();

            int rows = db.excuteNonQuery(query, new object[] { txbMaNV.Text });

            HienThi();
        }
        public void loadDataTotext()
        {
            int i = drgDSNV.CurrentRow.Index;
            txbTenNV.Text = drgDSNV.Rows[i].Cells["TenNV"].Value.ToString();
            txbMaNV.Text = drgDSNV.Rows[i].Cells["MaNV"].Value.ToString();
            txbDiaChiNV.Text = drgDSNV.Rows[i].Cells["DiaChiNV"].Value.ToString();
            txbSDTNV.Text = drgDSNV.Rows[i].Cells["SDTNV"].Value.ToString();

        }

        private void drgDSNV_MouseUp(object sender, MouseEventArgs e)
        {
            loadDataTotext();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddFlag == true)
            {


                string query = "INSERT INTO tbl_NhanVien(MaNV, TenNV, DiaChiNV, SDTNV) VALUES( @MaNV , @TenNV , @DiaChiNV , @SDTNV ) ";

                Database db = new Database();

                if (checkRequired())
                {
                    int rows = db.excuteNonQuery(query, new object[] { txbMaNV.Text, txbTenNV.Text, txbDiaChiNV.Text, txbSDTNV.Text });
                    if (rows == 1)
                    {
                        MessageBox.Show("Thêm mới nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm câu hỏi thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    disableAllField();

                    isAddFlag = false;

                    btnThem.Enabled = true;

                    btnXoa.Enabled = true;

                    btnSua.Enabled = true;

                    btnLuu.Enabled = false;

                    enableDgrEvent();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {


                string query = "UPDATE tbl_NhanVien SET TenNV = @TenNV  , DiaChiNV = @DiaChiNV , SDTNV = @SDTNV  WHERE MaNV = @MaNV ";




                Database db = new Database();

                int rows = db.excuteNonQuery(query, new object[] { txbMaNV.Text, txbTenNV.Text, txbDiaChiNV, txbSDTNV.Text });

                disableAllField();

                HienThi();

                btnThem.Enabled = true;

                btnXoa.Enabled = true;

                btnSua.Enabled = true;

                btnLuu.Enabled = false;

                enableDgrEvent();
            }
        }
        private Boolean checkRequired()
        {
            if (txbTenNV.Text == "" || txbSDTNV.Text == "")
            {
                return false;
            }
            else return true;
        }
        private void disableDgrEvent()
        {
            drgDSNV.CellContentClick -= drgDSNV_CellContentClick;

            drgDSNV.MouseUp -= drgDSNV_MouseUp;
        }

        private void enableDgrEvent()
        {
            drgDSNV.CellContentClick += drgDSNV_CellContentClick;

            drgDSNV.MouseUp += drgDSNV_MouseUp;
        }
        private string autoCreateID()
        {
            string query = "SELECT TOP 1 MaNV FROM tbl_NhanVien ORDER BY MaNV DESC";
            DataTable data = new DataTable();
            Database db = new Database();
            data = db.excuteQuery(query);

            string lastID = data.Rows[0]["MaNV"].ToString();

            string index = lastID.Substring(2);

            int key = Convert.ToInt16(index) + 1;

            return formatStringNumber(key);
        }
        private string formatStringNumber(int i)
        {
            string result;
            if (i < 10)
            {
                result = "NV" + "000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = "NV" + "00" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = "NV" + "0" + i.ToString().Trim();
            }
            else result = "NV" + i.ToString().Trim();

            return result;

        }

        private void drgDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataTotext();

        }
    }
}
