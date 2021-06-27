using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyHieuThuoc
{
    public partial class fImport : Form
    {
        string PoID = "";
        public fImport()
        {
            InitializeComponent();
        }

        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        private void fImport_Load(object sender, EventArgs e)
        {
            txtPoID.Text = Functions.CreateKey("PO");

            loadMakeToCombobox();

            cbMakeId.SelectedIndex = 0;

            loadMedicineByMakeID(cbMakeId.SelectedValue.ToString());

            string id = cbMakeId.SelectedValue.ToString();

            string query = "SELECT MaNhaSX, TenNhaSX FROM tbl_DMNhaSx WHERE MaNhaSX = '" + id + "'";

            Database db = new Database();

            DataTable data = db.excuteQuery(query);

            txtMakeName.Text = data.Rows[0]["TenNhaSX"].ToString();

            cbMedicineId.SelectedIndex = -1;

            createPO();
        }


        private void createPO()
        {
            Database db = new Database();

            string query = "INSERT INTO tbl_PhieuNhap (soCT, MaNhaSX, NgayCt, Thue, ChietKhau, MaNV) VALUES ( @soCT , @MaNhaSX , @NgayCt , @Thue , @ChietKhau , @MaNV )";

            PoID = txtPoID.Text;

            string makeID = cbMakeId.SelectedValue.ToString();

            DateTime poDate = dtpPODate.Value;

           

            // int tax = Convert.ToInt32(txbThue.Text);

            // string staffID = cbStaffId.SelectedValue.ToString();

            db.excuteNonQuery(query, new object[] {PoID, makeID, poDate, 0, 0, "NV001" });
        }

        private void loadMakeToCombobox()
        {
            Database db = new Database();

            string query = "SELECT MaNhaSX, TenNhaSX FROM tbl_DMNhaSx";

            Functions.FillCombo(query, cbMakeId, "MaNhaSX", "MaNhaSX");
        }

        private void cbMakeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMakeId.IsHandleCreated && cbMakeId.Focused && cbMakeId.SelectedValue != null)
            {
                string id = cbMakeId.SelectedValue.ToString();

                string query = "SELECT MaNhaSX, TenNhaSX FROM tbl_DMNhaSx WHERE MaNhaSX = '" + id + "'";

                Database db = new Database();

                DataTable data = db.excuteQuery(query);

                txtMakeName.Text = data.Rows[0]["TenNhaSX"].ToString();

                loadMedicineByMakeID(id);

                cbMedicineId.SelectedIndex = -1;

                query = "UPDATE tbl_PhieuNhap SET MaNhaSX = @MaNhaSX WHERE soCT = '" + PoID + "'";

                db.excuteNonQuery(query, new object[] { id });
            }
        }


        private void loadMedicineByMakeID(string id)
        {
            Database db = new Database();

            string query = "SELECT MaThuoc, TenThuoc, DonviTinh FROM tbl_Thuoc WHERE MaNhaSX = '" + id + "'";

            Functions.FillCombo(query, cbMedicineId, "MaThuoc", "MaThuoc");
        }

        private void cbMedicineId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedicineId.IsHandleCreated && cbMedicineId.Focused && cbMedicineId.SelectedValue != null)
            {
                string id = cbMedicineId.SelectedValue.ToString();

                string query = "SELECT MaThuoc, TenThuoc, DonviTinh FROM tbl_Thuoc WHERE MaThuoc = '" + id + "'";

                Database db = new Database();

                DataTable data = db.excuteQuery(query);

                txtMedicineName.Text = data.Rows[0]["TenThuoc"].ToString();

                txtUnit.Text = data.Rows[0]["DonviTinh"].ToString();

                txtMedicineName.Text = data.Rows[0]["TenThuoc"].ToString();

            }
        }

        private void addMedicineToPoDetail(string medicineID)
        {
            Database db = new Database();

            string query = "INSERT INTO tbl_CTNhap (soCT, MaThuoc, SoLuongNhap, DonGiaNhap) VALUES ( @soCT , @MaThuoc , @SoLuongNhap , @DonGiaNhap )";

            db.excuteNonQuery(query, new object[] { PoID, medicineID, txtQuantity.Text, txtCost.Text});
        }

        private void updateMedicineQuantity(int quantiy, string medicineID)
        {
            Database db = new Database();

            string query = "UPDATE tbl_CTNhap SET SoLuongNhap = @SoLuongNhap WHERE soCT = '" + txtPoID.Text + "' AND MaThuoc = @MaThuoc ";

            db.excuteNonQuery(query, new object[] { quantiy, medicineID });

        }

        private void deleteMedicineToPoDetail(string medicineID, string poID)
        {
            Database db = new Database();

            string query = "DELETE tbl_CTNhap WHERE soCT = @soCT AND MaThuoc = @MaThuoc ";

            db.excuteNonQuery(query, new object[] { poID, medicineID });
        }

        private int getMedicineQuantityInPO(string medicineid, string poID)
        {
            Database db = new Database();

            string query = "SELECT SoLuongNhap FROM tbl_CTNhap WHERE MaThuoc = @MaThuoc AND soCT = @soCT ";

            DataTable data = db.excuteQuery(query, new object[] { medicineid, poID });

            return Convert.ToInt32(data.Rows[0]["SoLuongNhap"]);
        }

        private int getMedicineInventory(string medicineid)
        {
            Database db = new Database();

            string query = "SELECT SoLuong FROM tbl_Thuoc WHERE MaThuoc = @MaThuoc";

            DataTable data = db.excuteQuery(query, new object[] { medicineid });

            return Convert.ToInt32(data.Rows[0]["SoLuong"]);
        }

        private void setMedicineInventory(int quantiy, string medicineId)
        {
            Database db = new Database();

            string query = "UPDATE tbl_Thuoc SET SoLuong = @SoLuong WHERE MaThuoc = '" + medicineId + "'";

            db.excuteNonQuery(query, new object[] { quantiy });

        }

        private void resetValue()
        {
            cbMedicineId.SelectedIndex = -1;
            txtCost.Text = "";
            txtMedicineName.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            txtAmount.Text = "";
        }

        private void loadDgvCTNhap()
        {
            Database db = new Database();

            string query = "SELECT tbl_Thuoc.MaThuoc, tbl_Thuoc.TenThuoc, tbl_Thuoc.DonviTinh, tbl_CTNhap.SoLuongNhap, tbl_CTNhap.DonGiaNhap, tbl_Thuoc.SoLuong AS [So Luong Ton], (tbl_CTNhap.SoLuongNhap * tbl_CTNhap.DonGiaNhap) AS [Thanh tien]" +
                " FROM tbl_Thuoc LEFT JOIN tbl_CTNhap ON tbl_CTNhap.MaThuoc = tbl_Thuoc.MaThuoc WHERE soCT = '" + PoID + "'";

            dgvCTNhap.DataSource = db.excuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int inventory, quantityPO;

            string idMedicine = cbMedicineId.SelectedValue.ToString();

            addMedicineToPoDetail(idMedicine);

            inventory = getMedicineInventory(idMedicine);

            quantityPO = getMedicineQuantityInPO(idMedicine, PoID);

            setMedicineInventory((inventory + quantityPO), idMedicine);

            resetValue();

            loadDgvCTNhap();

            if (dgvCTNhap.Rows.Count > 0)
            {
                cbMakeId.Enabled = false;
            }

            calculatorTotalAmount();
        }

        // Double Click to delete current record
        private void dgvCTNhap_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql, query;

            query = "SELECT * FROM tbl_CTNhap WHERE soCT = '" + PoID + "'";

            Database db = new Database();

            DataTable tblCTHD = db.excuteQuery(query);

            if (tblCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 

                string idMedicine = dgvCTNhap.CurrentRow.Cells["MaThuoc"].Value.ToString();

                int SoLuongxoa = Convert.ToInt32(dgvCTNhap.CurrentRow.Cells["SoLuongNhap"].Value.ToString());

                deleteMedicineToPoDetail(idMedicine, PoID);

                int oldInventory = getMedicineInventory(idMedicine);

                setMedicineInventory((oldInventory - SoLuongxoa), idMedicine);

                loadDgvCTNhap();

                calculatorTotalAmount();

                if(isBlank() == true)
                {
                    cbMakeId.Enabled = true;
                }
            }
        }

        private Boolean isBlank()
        {
            Database db = new Database();

            string query = "Select COUNT(*) from tbl_CTNhap where soCT = '" + PoID + "'";

            db.excuteQuery(query);

            int record = Convert.ToInt32(db.excuteQuery(query).Rows[0][0]);

            if (record > 0)
            {
                return false;
            }
            else return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = dgvCTNhap.CurrentRow.Index;

            string idMedicine = dgvCTNhap.Rows[i].Cells["MaThuoc"].Value.ToString();

            cbMedicineId.SelectedValue = idMedicine;

            cbMedicineId.Enabled = false;

            txtQuantity.Text = dgvCTNhap.Rows[i].Cells["SoLuongNhap"].Value.ToString();

            txtCost.Text = dgvCTNhap.Rows[i].Cells["DonGiaNhap"].Value.ToString();

            string query = "SELECT MaThuoc, TenThuoc, DonviTinh FROM tbl_Thuoc WHERE MaThuoc = '" + idMedicine + "'";

            Database db = new Database();

            DataTable data = db.excuteQuery(query);

            txtMedicineName.Text = data.Rows[0]["TenThuoc"].ToString();

            txtUnit.Text = data.Rows[0]["DonviTinh"].ToString();

            btnThem.Enabled = false;

            btnEdit.Enabled = false;

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int oldQuantity, newQuantity, newInventory;

            string idMedicine = cbMedicineId.SelectedValue.ToString();

            oldQuantity = getMedicineQuantityInPO(idMedicine, PoID);

            newQuantity = Convert.ToInt32(txtQuantity.Text);

            updateMedicineQuantity(newQuantity, idMedicine);

            newInventory = getMedicineInventory(idMedicine) - oldQuantity + newQuantity;

            setMedicineInventory(newInventory, idMedicine);

            loadDgvCTNhap();

            calculatorTotalAmount();

            btnThem.Enabled = true;

            btnEdit.Enabled = true;

            btnSave.Enabled = false;

            resetValue();

            cbMedicineId.Enabled = true;
        }


        private void calculatorTotalAmount()
        {
            Database db = new Database();

            string query = "SELECT SUM(tbl_CTNhap.SoLuongNhap * tbl_CTNhap.DonGiaNhap) FROM tbl_CTNhap WHERE tbl_CTNhap.soCT = '" + PoID + "'";

            double total;
            if (db.excuteQuery(query).Rows.Count > 0)
            {
                if (db.excuteQuery(query).Rows[0][0].ToString() != "")
                {
                    total = Convert.ToDouble(db.excuteQuery(query).Rows[0][0].ToString());
                }

                else total = 0;

                txtTotalAmount.Text = db.excuteQuery(query).Rows[0][0].ToString();

                txtPayment.Text = txtTotalAmount.Text;
            }

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtCost.Text != "")
            {
                int quantity = Convert.ToInt32(txtQuantity.Text.Trim());

                double cost = Convert.ToDouble(txtCost.Text.Trim());

                txtAmount.Text = (quantity * cost).ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtCost.Text != "")
            {
                int quantity = Convert.ToInt32(txtQuantity.Text.Trim());

                double cost = Convert.ToDouble(txtCost.Text.Trim());

                txtAmount.Text = (quantity * cost).ToString();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                if (txtTax.Text == "")
                {
                    double total = Convert.ToDouble(txtTotalAmount.Text);

                    double discount = Convert.ToDouble(txtDiscount.Text.Trim()) / 100;

                    double payment = (total * (1 - discount));

                    txtPayment.Text = payment.ToString();
                }

                else
                {

                    double total = Convert.ToDouble(txtTotalAmount.Text);

                    double tax = Convert.ToDouble(txtTax.Text.Trim()) / 100;

                    double discount = Convert.ToDouble(txtDiscount.Text.Trim()) / 100;

                    double payment = (total * (1 - discount)) * (1 + tax);

                    txtPayment.Text = payment.ToString();
                }
            }
            else
            {
                txtDiscount.Text = "";
            }

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            if (txtTax.Text != "")
            {
                if (txtDiscount.Text == "")
                {
                    double total = Convert.ToDouble(txtTotalAmount.Text);

                    double tax = Convert.ToDouble(txtTax.Text.Trim()) / 100;

                    double payment = total * (1 + tax);

                    txtPayment.Text = payment.ToString();
                }

                else
                {

                    double total = Convert.ToDouble(txtTotalAmount.Text);

                    double tax = Convert.ToDouble(txtTax.Text.Trim()) / 100;

                    double discount = Convert.ToDouble(txtDiscount.Text.Trim()) / 100;

                    double payment = (total * (1 - discount)) * (1 + tax);

                    txtPayment.Text = payment.ToString();
                }
            } else
            {
                txtTax.Text = "";
            }

        }

        private void btnSavePO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletePO()
        {
            int oldInventory, newInventory, quantityDel;

            Database db = new Database();

            string query = "SELECT MaThuoc, SoLuongNhap FROM tbl_CTNhap WHERE soCT = '" + PoID + "'";

            DataTable tblThuoc = db.excuteQuery(query);

            for (int thuoc = 0; thuoc <= tblThuoc.Rows.Count - 1; thuoc++)
            {
                string id = tblThuoc.Rows[thuoc][0].ToString();
                // Cập nhật lại số lượng cho các mặt hàng
                oldInventory = getMedicineInventory(id);

                quantityDel = Convert.ToInt32(tblThuoc.Rows[thuoc][1].ToString());

                newInventory = oldInventory - quantityDel;

                setMedicineInventory(newInventory, id);
            }

            query = "DELETE FROM tbl_CTNhap WHERE soCT = '" + PoID + "'";

            int count = db.excuteNonQuery(query);

            query = "DELETE FROM tbl_PhieuNhap WHERE soCT = '" + PoID + "'";

            count = db.excuteNonQuery(query);
        }
        private void btnDeletePO_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xoá hoá đơn này không";

            if (dgvCTNhap.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        deletePO();

                        MessageBox.Show("Huỷ hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Huỷ hoá đơn không thành công, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                deletePO();

                this.Close();
            }
        }
    }
}
