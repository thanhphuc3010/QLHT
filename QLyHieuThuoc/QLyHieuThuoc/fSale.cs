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
    public partial class fSale : Form
    {
        string invoiceID = "";
        public fSale()
        {
            InitializeComponent();

            invoiceID = CreateKey("HD");
            txtInvoiceId.Text = invoiceID;
            txtInvoiceId.ReadOnly = true;

            loadCustomerList();

            cbCustomerId.SelectedIndex = -1;

            loadStaffList();

            cbStaffId.SelectedIndex = -1;

            loadMedicineList();

            cbMedicineId.SelectedIndex = -1;

            insertInvoiceToDB();

        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = Functions.ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        private void insertInvoiceToDB()
        {
            string query = "INSERT INTO tbl_HDBan (SoHD, NgayHD, HanTT) VALUES ( @SoHD , @NgayHD , @HanTT )";

            Database db = new Database();

            //int tax = Convert.ToInt16(txtTax.Text);

            int row = db.excuteNonQuery(query, new object[] { invoiceID, dptInvoiceDate.Value, dtpDueDate.Value });
        }

        private void txbThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadCustomerList()
        {
            Database db = new Database();

            string query = "SELECT MaKH, TenKH FROM tbl_DMKhachHang";

            Functions.FillCombo(query, cbCustomerId, "MaKH", "TenKH");
        }


        private void loadStaffList()
        {
            Database db = new Database();

            string query = "SELECT MaNV, TenNV FROM tbl_NhanVien";

            Functions.FillCombo(query, cbStaffId, "MaNV", "TenNV");
        }

        private void loadMedicineList()
        {
            Database db = new Database();

            string query = "SELECT MaThuoc, TenThuoc FROM tbl_Thuoc";

            Functions.FillCombo(query, cbMedicineId, "MaThuoc", "TenThuoc");
        }

        private void cbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerId.IsHandleCreated && cbCustomerId.Focused && cbCustomerId.SelectedValue != null)
            {
                string id = cbCustomerId.SelectedValue.ToString();

                string query = "SELECT TenKh, DchiKH, SdtKH, Email FROM tbl_DMKhachHang WHERE MaKH = '" + id + "'";

                Database db = new Database();

                DataTable data = db.excuteQuery(query);

                txtAddress.Text = data.Rows[0]["DchiKH"].ToString();

                txtPhoneNumber.Text = data.Rows[0]["SdtKH"].ToString();

                txtEmail.Text = data.Rows[0]["Email"].ToString();

                updateCustomer(id);

            }
        }

        private void cbMedicineId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedicineId.IsHandleCreated && cbMedicineId.Focused && cbMedicineId.SelectedValue != null)
            {
                string id = cbMedicineId.SelectedValue.ToString();

                string query = "SELECT TenThuoc, DonviTinh, Dongia FROM tbl_Thuoc WHERE MaThuoc = '" + id + "'";

                Database db = new Database();

                DataTable data = db.excuteQuery(query);

                txtUnit.Text = data.Rows[0]["DonviTinh"].ToString();

                txtPrice.Text = data.Rows[0]["Dongia"].ToString();

            }
        }

        private void updateCustomer(string id)
        {
            string query = "UPDATE tbl_HDBan SET MaKH = @MaKH WHERE SoHD = '" + invoiceID + "'";

            Database db = new Database();

            //int tax = Convert.ToInt16(txtTax.Text);

            int row = db.excuteNonQuery(query, new object[] { id });
        }

        private void checkQuantity ()
        {

        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string MedicineID = cbMedicineId.SelectedValue.ToString();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            string query = "INSERT INTO tbl_CTHD (SoHD, MaThuoc, SoLuong, DonGia) VALUES ( @SoHD , @MaThuoc , @SoLuong , @DonGia )";

            Database db = new Database();

            //int tax = Convert.ToInt16(txtTax.Text);

            int row = db.excuteNonQuery(query, new object[] { invoiceID, MedicineID, quantity, price });

            loadDetailInvoice();
        }

        private void loadDetailInvoice()
        {
            string query = "SELECT SoHD, MaThuoc, SoLuong, DonGia, (SoLuong * DonGia) AS N'Thành tiền' FROM tbl_CTHD WHERE SoHD = '" + invoiceID +"'";

            Database db = new Database();

            //int tax = Convert.ToInt16(txtTax.Text);

            dgrMedicineList.DataSource = db.excuteQuery(query);
        }

        private void autoCalAmout()
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double amount, quantity, price;
            if (txtQuantity.Text == "")
                quantity = 0;
            else
                quantity = Convert.ToDouble(txtQuantity.Text);

            if (txtPrice.Text == "")
                price = 0;
            else
                price = Convert.ToDouble(txtPrice.Text);
            amount = quantity * price;
            txtAmount.Text = amount.ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            autoCalAmout();
        }

        private void fSale_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void fSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Bạn có muốn đóng cửa sổ, đóng cửa sổ khi không lưu sẽ không ghi nhận hoá đơn. Bạn đồng ý chứ ?";
            DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_CTHD WHERE SoHD = '" + invoiceID + "'";

                Database db = new Database();

                int count = db.excuteNonQuery(query);

                query = "DELETE FROM tbl_HDBan WHERE SoHD = '" + invoiceID + "'";

                count = db.excuteNonQuery(query);
            } else
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
