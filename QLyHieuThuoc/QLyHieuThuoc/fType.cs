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
using NSubstitute.Core;

namespace QLyHieuThuoc
{
    public partial class fType : Form
    {
        public fType()
        {
            InitializeComponent();
        }
        SqlConnection con;
        public Boolean isAddFlag = false;
        private void fType_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            loadDataToTextbox();
            disableAllField();
            btnLuu.Enabled = false;
        }

        private void fType_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string query = " SELECT * FROM tbl_DMLoaiThuoc";
            Database db = new Database();
            dmLoaiThuoc.DataSource = db.excuteQuery(query);
        }
        public void loadDataToTextbox()
        {
            int i = dmLoaiThuoc.CurrentRow.Index;
            txbMa.Text = dmLoaiThuoc.Rows[i].Cells["MaThuoc"].Value.ToString();
            txbTen.Text = dmLoaiThuoc.Rows[i].Cells["TenLoaiThuoc"].Value.ToString();

        }

        private void dmLoaiThuoc_MouseUp(object sender, MouseEventArgs e)
        {
            loadDataToTextbox();
        }
        private void disableAllField()
        {
            txbMa.ReadOnly = true;
            txbMa.Enabled = false;
            txbTen.ReadOnly = true;

        }
        private void enableAllField()
        {
            txbMa.ReadOnly = true;
            txbMa.Enabled = false;
            txbTen.ReadOnly = false;

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            enableAllField();
            resetAllFieldsBlank();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            isAddFlag = true;
            txbMa.Text = autoCreateID();
            txbMa.ReadOnly = true;
            disableDgrEvent();
        }
        public void resetAllFieldsBlank()
        {
            txbTen.Text = "";
            txbMa.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableAllField();
            txbMa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            disableDgrEvent(); ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_DMLoaiThuoc WHERE MaThuoc = @MaThuoc, TenLoaiThuoc = @TenLoaiThuoc";
            Database db = new Database();

            int rows = db.excuteNonQuery(query, new object[] { txbMa.Text });
            
            

            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddFlag == true)
            {


                string query = "INSERT INTO tbl_DMLoaiThuoc (MaThuoc, TenLoaiThuoc) VALUES ( @MaThuoc , @TenLoaiThuoc )";

                Database db = new Database();

                if (checkRequired())
                {
                    int rows = db.excuteNonQuery(query, new object[] { txbMa.Text, txbTen.Text });
                    if (rows == 1)
                    {
                        MessageBox.Show("Thêm mới loại thuốc thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    HienThi();

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {


                string query = "UPDATE tbl_DMLoaiThuoc SET TenLoaiThuoc= @TenLoaiThuoc  WHERE MaNhaSX = @MaNhaSX ";




                Database db = new Database();

                int rows = db.excuteNonQuery(query, new object[] { txbMa.Text, txbTen.Text });

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
            if (txbTen.Text == "" )
            {
                return false;
            }
            else return true;
        }
        private void disableDgrEvent()
        {
            dmLoaiThuoc.CellContentClick -= dmLoaiThuoc_CellContentClick;

            dmLoaiThuoc.MouseUp -= dmLoaiThuoc_MouseUp;
        }

        private void dmLoaiThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void enableDgrEvent()
        {
            dmLoaiThuoc.CellContentClick += dmLoaiThuoc_CellContentClick;

            dmLoaiThuoc.MouseUp += dmLoaiThuoc_MouseUp;
        }
        private string autoCreateID()
        {
            string query = "SELECT TOP 1 MaThuoc FROM tbl_DMLaoiThuoc ORDER BY MaNhaSX DESC";
            DataTable data = new DataTable();
            Database db = new Database();
            data = db.excuteQuery(query);

            string lastID = data.Rows[0]["MaNhaSX"].ToString();

            string index = lastID.Substring(2);

            int key = Convert.ToInt16(index) + 1;

            return formatStringNumber(key);
        }
        private string formatStringNumber(int i)
        {
            string result;
            if (i < 10)
            {
                result = "LT" + "000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = "LT" + "00" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = "LT" + "0" + i.ToString().Trim();
            }
            else result = "LT" + i.ToString().Trim();

            return result;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
