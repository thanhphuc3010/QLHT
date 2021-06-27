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
        public Boolean isAddFlag = false;


        private void fUpdate_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            loadDataToTextbox();
            disableAllField();
            btnLuu.Enabled = false;
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
            string query = " SELECT * FROM tbl_Thuoc";
            Database db = new Database();
            dsThuoc.DataSource = db.excuteQuery(query);
        }
        private void disableAllField()
        {
            txbMaThuoc.ReadOnly = true;
            txbMaThuoc.Enabled = false;
            txbTenThuoc.ReadOnly = true;
            txbHamLuong.ReadOnly = true;
            txbDonVi.ReadOnly = true;
            txbSoLuong.ReadOnly = true;
            txbSoDangKy.ReadOnly = true;
            txbThanhPhan.ReadOnly = true;
            dtNgaySanXuat.Enabled = false;
            txbHanSuDung.ReadOnly = true;
            txbNoiSanXuat.ReadOnly = true;
            txbDonGia.ReadOnly = true;
            txbDongGoi.ReadOnly = true;
            txbNhaSanXuat.ReadOnly = true;
        }
        private void enableAllField()
        {
            txbMaThuoc.ReadOnly = true;
            txbMaThuoc.Enabled = false;
            txbTenThuoc.ReadOnly = false;
            txbHamLuong.ReadOnly = false;
            txbDonVi.ReadOnly = false;
            txbSoLuong.ReadOnly = false;
            txbSoDangKy.ReadOnly = false;
            txbThanhPhan.ReadOnly = false;
            dtNgaySanXuat.Enabled = true;
            txbHanSuDung.ReadOnly = false;
            txbNoiSanXuat.ReadOnly = false;
            txbDonGia.ReadOnly = false;
            txbDongGoi.ReadOnly = false;
            txbNhaSanXuat.ReadOnly = false;
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
            txbMaThuoc.Text = autoCreateID();
            txbMaThuoc.ReadOnly = true;
            disableDgrEvent();

        }
        public void resetAllFieldsBlank()
        {
            txbMaThuoc.Text = "";
            txbTenThuoc.Text = "";
            txbHamLuong.Text = "";
            txbDonVi.Text = "";
            txbSoLuong.Text = "";
            txbSoDangKy.Text = "";
            txbThanhPhan.Text = "";
            dtNgaySanXuat.Text = "";
            txbHanSuDung.Text = "";
            txbNoiSanXuat.Text = "";
            txbHanSuDung.Text = "";
            txbDonGia.Text = "";
            txbDongGoi.Text = "";
            txbNhaSanXuat.Text = "";
        }

   

       

        private void dsThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataToTextbox();
        }
        public void loadData()
        {
            int i = dsThuoc.CurrentRow.Index;
            txbMaThuoc.Text = dsThuoc.Rows[i].Cells["MaThuoc"].Value.ToString();
            txbTenThuoc.Text = dsThuoc.Rows[i].Cells["TenThuoc"].Value.ToString();
            txbHamLuong.Text = dsThuoc.Rows[i].Cells["HamLuong"].Value.ToString();
            txbDonVi.Text = dsThuoc.Rows[i].Cells["DonviTinh"].Value.ToString();
            txbSoLuong.Text = dsThuoc.Rows[i].Cells["SoLuong"].Value.ToString();
            txbSoDangKy.Text = dsThuoc.Rows[i].Cells["SoDK"].Value.ToString();
            txbThanhPhan.Text = dsThuoc.Rows[i].Cells["ThanhPhan"].Value.ToString();
            dtNgaySanXuat.Text = dsThuoc.Rows[i].Cells["NgaySX"].Value.ToString();
            txbHanSuDung.Text = dsThuoc.Rows[i].Cells["HSD"].Value.ToString();
            txbNoiSanXuat.Text = dsThuoc.Rows[i].Cells["NoiSX"].Value.ToString();
            txbDonGia.Text = dsThuoc.Rows[i].Cells["DonGia"].Value.ToString();
            txbDongGoi.Text = dsThuoc.Rows[i].Cells["DongGoi"].Value.ToString();
            txbNhaSanXuat.Text = dsThuoc.Rows[i].Cells["MaNhaSX"].Value.ToString();
        }

        private void dsThuoc_MouseUp(object sender, MouseEventArgs e)
        {
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableAllField();
            txbMaThuoc.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            disableDgrEvent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_Thuoc WHERE MaThuoc = @MaThuoc";

            Database db = new Database();

            int rows = db.excuteNonQuery(query, new object[] { txbTenThuoc.Text });

            HienThi();
        }
        private Boolean checkRequired()
        {
            if (txbTenThuoc.Text == "" || txbDonVi.Text == "" || dtNgaySanXuat.Text =="" || txbHanSuDung.Text =="" )
            {
                return false;
            }
            else return true;
        }
        private void disableDgrEvent()
        {
           dsThuoc.CellContentClick -= dsThuoc_CellContentClick;

            dsThuoc.MouseUp -= dsThuoc_MouseUp;
        }

        private void enableDgrEvent()
        {
            dsThuoc.CellContentClick += dsThuoc_CellContentClick;

            dsThuoc.MouseUp += dsThuoc_MouseUp;
        }
        public void loadDataToTextbox()
        {
            int i = dsThuoc.CurrentRow.Index;
            txbTenThuoc.Text = dsThuoc.Rows[i].Cells["TenThuoc"].Value.ToString();
            txbMaThuoc.Text = dsThuoc.Rows[i].Cells["MaThuoc"].Value.ToString();
            txbHamLuong.Text = dsThuoc.Rows[i].Cells["HamLuong"].Value.ToString();
            txbDonVi.Text = dsThuoc.Rows[i].Cells["DonviTinh"].Value.ToString();
            txbSoLuong.Text = dsThuoc.Rows[i].Cells["SoLuong"].Value.ToString();
            txbSoDangKy.Text = dsThuoc.Rows[i].Cells["SoDK"].Value.ToString();
            txbThanhPhan.Text = dsThuoc.Rows[i].Cells["ThanhPhan"].Value.ToString();
            dtNgaySanXuat.Text = dsThuoc.Rows[i].Cells["NgaySX"].Value.ToString();
            txbHanSuDung.Text = dsThuoc.Rows[i].Cells["HSD"].Value.ToString();
            txbNoiSanXuat.Text = dsThuoc.Rows[i].Cells["NoiSX"].Value.ToString();
            txbDonGia.Text = dsThuoc.Rows[i].Cells["DonGia"].Value.ToString();
            txbDongGoi.Text = dsThuoc.Rows[i].Cells["DongGoi"].Value.ToString();
            txbNhaSanXuat.Text = dsThuoc.Rows[i].Cells["MaNhaSX"].Value.ToString();
        }
        private string autoCreateID()
        {
            string query = "SELECT TOP 1 MaThuoc FROM tbl_Thuoc ORDER BY MaThuoc DESC";
            DataTable data = new DataTable();
            Database db = new Database();
            data = db.excuteQuery(query);

            string lastID = data.Rows[0]["MaThuoc"].ToString();

            string index = lastID.Substring(2);

            int key = Convert.ToInt16(index) + 1;

            return formatStringNumber(key);
        }
        private string formatStringNumber(int i)
        {
            string result;
            if (i < 10)
            {
                result = "T" + "000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = "T" + "00" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = "T" + "0" + i.ToString().Trim();
            }
            else result = "T" + i.ToString().Trim();

            return result;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddFlag == true)
            {


                string query = "INSERT INTO tbl_Thuoc ( MaThuoc, TenThuoc, HamLuong, DonviTinh, SoLuong, SoDK, ThanhPhan, NgaySX, HSD, NoiSX, DonGia, DongGoi, MaNhaSX ) VALUES ( @MaThuoc , @TenThuoc , @HamLuong , @DonviTinh , @SoLuong , @SoDK , @ThanhPhan , @NgaySX , @HSD , @NoiSX , @DonGia , @DongGoi , @MaNhaSX )";

                Database db = new Database();

                if (checkRequired())
                {
                    int rows = db.excuteNonQuery(query, new object[] { txbMaThuoc.Text, txbTenThuoc.Text, txbHamLuong.Text, txbDonVi.Text, txbSoLuong.Text, txbSoDangKy.Text, txbThanhPhan.Text, dtNgaySanXuat.Text, txbHanSuDung.Text, txbNoiSanXuat.Text, txbDonGia.Text, txbDongGoi.Text, txbNhaSanXuat });
                    if (rows == 1)
                    {
                        MessageBox.Show("Thêm thuốc mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                string query = "UPDATE tbl_Thuoc SET TenThuoc = @TenThuoc  , HamLuong = @HamLuong , DonviTinh = @DonviTinh , SoLuong = @SoLuong , SoDK = @SoDK , ThanhPhan = @ThanhPhan , NgaySX = @NgaySX , HSD = @HSD , NoiSX = @NoiSX , DonGia = @DonGia , DongGoi = @DongGoi  WHERE MaThuoc = @MaThuoc ";




                Database db = new Database();

                int rows = db.excuteNonQuery(query, new object[] { txbMaThuoc.Text, txbTenThuoc.Text, txbHamLuong.Text, txbDonVi.Text, txbSoLuong.Text, txbSoDangKy.Text, txbThanhPhan.Text, dtNgaySanXuat.Text, txbHanSuDung.Text, txbNoiSanXuat.Text, txbDonGia.Text, txbDongGoi.Text, txbNhaSanXuat });

                disableAllField();

                HienThi();

                btnThem.Enabled = true;

                btnXoa.Enabled = true;

                btnSua.Enabled = true;

                btnLuu.Enabled = false;

                enableDgrEvent();
            }
        }
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datareport;
            if (comTruong.Text == "Còn hạn sử dụng")
               { 
                string query = "Select TenThuoc, DonviTinh, DonGia, TenNhaSX, HSD FROM tbl_Thuoc Left join tbl_DMNhaSx on tbl_Thuoc.MaNhaSX = tbl_DMNhaSx.MaNhaSX where HSD >= getdate()";
                Database db = new Database();

                datareport = db.excuteQuery(query);

                //SqlDataAdapter da= new SqlDataAdapter();
                //rptNhomThuoc1 rpt = new rptNhomThuoc1();
                
            } else if(comTruong.Text == "Hết hạn sử dụng")
            {
                string query = "Select TenThuoc, DonviTinh, DonGia, TenNhaSX, HSD FROM tbl_Thuoc Left join tbl_DMNhaSx on tbl_Thuoc.MaNhaSX = tbl_DMNhaSx.MaNhaSX where HSD < getdate()";
                Database db = new Database();

                datareport = db.excuteQuery(query);
            }
            else
            {
                MessageBox.Show("Chưa có điều kiện để lọc báo cáo!");
                return;
            }   
            rptNhomThuoc1 rpt = new rptNhomThuoc1();

            rpt.SetDataSource(datareport);

            rpt.DataDefinition.FormulaFields["TinhTrang"].Text = "'" + comTruong.Text + "'";

            frmTinhTrangPrv f = new frmTinhTrangPrv(rpt);

            f.Show();

        } 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dtNgaySanXuat_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> parent of 636b571... Hưng commit
    }




}
