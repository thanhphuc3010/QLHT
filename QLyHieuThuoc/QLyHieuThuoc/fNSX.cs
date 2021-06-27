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
    public partial class fNSX : Form
    {
        public fNSX()
        {
            InitializeComponent();
        }
        SqlConnection con;
        public Boolean isAddFlag = false;

        private void fNSX_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            loadDataToTextbox();
            disableAllField();
            btnLuu.Enabled = false;
        }

        private void fNSX_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string query = " SELECT * FROM tbl_DMNhaSX";
            Database db = new Database();
            dmNSX.DataSource = db.excuteQuery(query);
        }
        private void disableAllField() 
        {
            txbMaNSX.ReadOnly = true;
            txbMaNSX.Enabled = false;
            txbTenNSX.ReadOnly = true;
            txbSdtNSX.ReadOnly = true;
            txbemail.ReadOnly = true;
            txbDChiNSX.ReadOnly = true;
        }
        private void enableAllField()
        {
            txbMaNSX.ReadOnly = true;
            txbMaNSX.Enabled = false;
            txbTenNSX.ReadOnly = false;
            txbSdtNSX.ReadOnly = false;
            txbemail.ReadOnly = false;
            txbDChiNSX.ReadOnly = false;
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
            txbMaNSX.Text = autoCreateID();
            txbMaNSX.ReadOnly = true;
            disableDgrEvent();
        }
        public void resetAllFieldsBlank()
        {
            txbTenNSX.Text = "";
            txbMaNSX.Text = "";
            txbDChiNSX.Text = "";
            txbSdtNSX.Text = "";
            txbemail.Text = "";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableAllField();
            txbMaNSX.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            disableDgrEvent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            string query = "DELETE FROM tbl_DMNhaSX WHERE MaNhaSX = @MaNhaSX";

            Database db = new Database();

            int rows = db.excuteNonQuery(query, new object[] { txbMaNSX.Text });
            
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddFlag == true)
            {
               

                string query = "INSERT INTO tbl_DMNhaSX (MaNhaSX, TenNhaSX, DChiNhaSX, SdtNhaSX, email) VALUES ( @MaNhaSX , @TenNhaSX , @DChiNhaSX , @SdtNhaSX , @email )";

                Database db = new Database();

                if (checkRequired())
                {
                    int rows = db.excuteNonQuery(query, new object[] { txbMaNSX.Text, txbTenNSX.Text, txbDChiNSX.Text, txbSdtNSX.Text, txbemail.Text });
                        if (rows == 1)
                        {
                            MessageBox.Show("Thêm mới nhà sản xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               

                string query = "UPDATE tbl_DMNhaSX SET TenNhaSX = @TenNhaSX  , DChiNhaSX = @DChiNhaSX , SdtNhaSX = @SdtNhaSX , email = @email WHERE MaNhaSX = @MaNhaSX ";

               
                    

                Database db = new Database();

                int rows = db.excuteNonQuery(query, new object[] { txbMaNSX.Text, txbTenNSX.Text, txbDChiNSX.Text, txbSdtNSX.Text, txbemail.Text });

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
            if (txbTenNSX.Text == "" || txbSdtNSX.Text == "")
            {
                return false;
            }
            else return true;
        }
        private void disableDgrEvent()
        {
            dmNSX.CellContentClick -= dmNSX_CellContentClick;

            dmNSX.MouseUp -= dmNSX_MouseUp;
        }

        private void enableDgrEvent()
        {
            dmNSX.CellContentClick += dmNSX_CellContentClick;

            dmNSX.MouseUp += dmNSX_MouseUp;
        }
        public void loadDataToTextbox()
        {
            int i = dmNSX.CurrentRow.Index;
            txbTenNSX.Text = dmNSX.Rows[i].Cells["TenNhaSX"].Value.ToString();
            txbMaNSX.Text = dmNSX.Rows[i].Cells["MaNhaSX"].Value.ToString();
            txbDChiNSX.Text = dmNSX.Rows[i].Cells["DChiNhaSX"].Value.ToString();
            txbSdtNSX.Text = dmNSX.Rows[i].Cells["SdtNhaSX"].Value.ToString();
            txbemail.Text = dmNSX.Rows[i].Cells["email"].Value.ToString();
        }
            

        private string autoCreateID()
            {
            string query = "SELECT TOP 1 MaNhaSX FROM tbl_DMNhaSX ORDER BY MaNhaSX DESC";
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
                result = "SX" + "00" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = "SX" + "0" + i.ToString().Trim();
            }
            
            else result = "SX" + i.ToString().Trim();

            return result;

        }

        private void dmNSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataToTextbox();
        }

        private void dmNSX_MouseUp(object sender, MouseEventArgs e)
        {
            loadDataToTextbox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKeySearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKeySearch_KeyUp(object sender, KeyEventArgs e)
        {
            string query = " SELECT * FROM tbl_DMNhaSX Where MaNhaSX LIKE '%" + txtKeySearch.Text + "%'" + "" +
               " OR TenNhaX LIKE N'%" + txtKeySearch.Text + "%'" + "" +
               " OR DChiNhaSX LIKE N'%" + txtKeySearch.Text + "%'" + "" +
               " OR SdtNhaSX LIKE '%" + txtKeySearch.Text + "%'" + "" +
               " OR email LIKE '%" + txtKeySearch.Text + "%'";
            Database db = new Database();
            dmNSX.DataSource = db.excuteQuery(query);
        }
    }
}