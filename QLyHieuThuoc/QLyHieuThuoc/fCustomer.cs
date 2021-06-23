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
        public Boolean isAddFlag = false;
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
            loadDataToTextbox();
            disableAllField();
            btnLuu.Enabled = false;
        }

        private void fCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void HienThi()
        {
            string query = " SELECT * FROM tbl_DMKhachHang";
            Database db = new Database();
            drgDMKH.DataSource = db.excuteQuery(query);
        }

        private void disableAllField()
        {
            txbMaKH.ReadOnly = true;
            txbMaKH.Enabled = false;
            txbTenKH.ReadOnly = true;
            txbSDTKH.ReadOnly = true;
            txbDiaChiKH.ReadOnly = true;
            txbEmail.ReadOnly = true;
            checkDVTC.AutoCheck = false;
            checkKhachLe.AutoCheck = false;
        }

        private void enableAllField()
        {
            txbMaKH.ReadOnly = false;
            txbMaKH.Enabled = true;
            txbTenKH.ReadOnly = false;
            txbSDTKH.ReadOnly = false;
            txbDiaChiKH.ReadOnly = false;
            txbEmail.ReadOnly = false;
            checkDVTC.AutoCheck = true;
            checkKhachLe.AutoCheck = true;
        }


        public void showByCreatedDate()
        {
            string query = "SELECT * FROM tbl_DMKhachHang ORDER BY CreatedDate DESC";
            Database db = new Database();
            drgDMKH.DataSource = db.excuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enableAllField();
            resetAllFieldsBlank();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            checkKhachLe.Checked = true;
            isAddFlag = true;
            txbMaKH.Text = autoCreateID();
            txbMaKH.ReadOnly = true;
            disableDgrEvent();
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
            enableAllField();
            txbMaKH.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            disableDgrEvent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_DMKhachHang WHERE MaKH = @MaKH ";

            Database db = new Database();

            int rows = db.excuteNonQuery(query, new object[] { txbMaKH.Text });

            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddFlag == true)
            {
                int customerType;

                string query = "INSERT INTO tbl_DMKhachHang (MaKH, TenKh, LoaiDT, DChiKH, SdtKH, Email) VALUES ( @MaKH , @TenKH , @LoaiDT , @DChiKH , @SdtKH , @Email )";
            
                if (isIndividual())
                {
                    customerType = 1;
                }
                else customerType = 0;

                Database db = new Database();

                if (checkRequired())
                {
                    int rows = db.excuteNonQuery(query, new object[] { txbMaKH.Text, txbTenKH.Text, customerType, txbDiaChiKH.Text, txbSDTKH.Text, txbEmail.Text });
                    if (rows == 1)
                    {
                        MessageBox.Show("Thêm mới khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                    {
                        MessageBox.Show("Thêm câu hỏi thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    showByCreatedDate();

                    disableAllField();

                    isAddFlag = false;

                    btnThem.Enabled = true;

                    btnXoa.Enabled = true;

                    btnSua.Enabled = true;

                    btnLuu.Enabled = false;

                    enableDgrEvent();
                } else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else
            {
                int customerType;

                string query = "UPDATE tbl_DMKhachHang SET tenKH = @TenKH , LoaiDT =  @LoaiDT , DChiKH = @DChiKH , SdtKH = @SdtKH , Email = @Email WHERE MaKH = @MaKH ";

                if (isIndividual())
                {
                    customerType = 1;
                }
                else customerType = 0;

                Database db = new Database();

                int rows = db.excuteNonQuery(query, new object[] { txbTenKH.Text, customerType, txbDiaChiKH.Text, txbSDTKH.Text, txbEmail.Text, txbMaKH.Text });

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
            if (txbTenKH.Text == "" || txbSDTKH.Text == "")
            {
                return false;
            }
            else return true;
        }

        private void handleCheckedKL()
        {
            if (checkKhachLe.Checked == true)
            {
                checkDVTC.Checked = false;
            }
            else checkDVTC.Checked = true;
            
        }

        private void handleCheckedDVTC()
        {
            if (checkDVTC.Checked == true)
            {
                checkKhachLe.Checked = false;
            }
            else checkKhachLe.Checked = true;

        }

        private Boolean isIndividual()
        {
            return checkKhachLe.Checked;
        }

        private void disableDgrEvent()
        {
            drgDMKH.CellContentClick -= drgDMKH_CellContentClick;

            drgDMKH.MouseUp -= drgDMKH_MouseUp;
        }

        private void enableDgrEvent()
        {
            drgDMKH.CellContentClick += drgDMKH_CellContentClick;

            drgDMKH.MouseUp += drgDMKH_MouseUp;
        }


        public void loadDataToTextbox()
        {
            int i = drgDMKH.CurrentRow.Index;
            txbTenKH.Text = drgDMKH.Rows[i].Cells["TenKH"].Value.ToString();
            txbMaKH.Text = drgDMKH.Rows[i].Cells["MaKH"].Value.ToString();
            txbDiaChiKH.Text = drgDMKH.Rows[i].Cells["DChiKH"].Value.ToString();
            txbSDTKH.Text = drgDMKH.Rows[i].Cells["SdtKH"].Value.ToString();
            txbEmail.Text = drgDMKH.Rows[i].Cells["Email"].Value.ToString();

            Boolean typeChecked = (drgDMKH.Rows[i].Cells["LoaiDT"].Value != null) ? Convert.ToBoolean(drgDMKH.Rows[i].Cells["LoaiDT"].Value) : true;
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
            loadDataToTextbox();
        }

        

        private void txbMaCanTim_KeyUp(object sender, KeyEventArgs e)
        {
            string query = " SELECT * FROM tbl_DMKhachHang Where MaKH LIKE '%" + txtKeySearch.Text + "%'" + "" +
                " OR TenKh LIKE N'%" + txtKeySearch.Text + "%'" + "" +
                " OR DChiKH LIKE N'%" + txtKeySearch.Text + "%'" + "" +
                " OR SdtKH LIKE '%" + txtKeySearch.Text + "%'" + "" +
                " OR Email LIKE '%" + txtKeySearch.Text + "%'";
            Database db = new Database();
            drgDMKH.DataSource = db.excuteQuery(query);
        }

        private string autoCreateID()
        {
            string query = "SELECT TOP 1 MaKH FROM tbl_DMKhachHang ORDER BY MaKH DESC";
            DataTable data = new DataTable();
            Database db = new Database();
            data = db.excuteQuery(query);

            string lastID = data.Rows[0]["MaKH"].ToString();

            string index = lastID.Substring(2);

            int key = Convert.ToInt16(index) + 1;

            return formatStringNumber(key);
        }

        private string formatStringNumber(int i)
        {
            string result;
            if (i < 10)
            {
                result = "KH" + "000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = "KH" + "00" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = "KH" + "0" + i.ToString().Trim();
            } else result = "KH" + i.ToString().Trim();
            
            return result;

        }
        private void checkKhachLe_CheckedChanged(object sender, EventArgs e)
        {
            handleCheckedKL();
        }

        private void checkDVTC_CheckedChanged(object sender, EventArgs e)
        {
            handleCheckedDVTC();
        }

        private void drgDMKH_MouseUp(object sender, MouseEventArgs e)
        {
            loadDataToTextbox();
        }
    }
}
