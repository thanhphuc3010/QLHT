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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private SqlConnection con;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string user = txbUserName.Text;
                string pass = txbPassWord.Text;
                string sql = "SELECT MaNV, Password FROM tbl_NhanVien WHERE MaNV = '" + user + "' and Password = '" + pass + "'";

                Database db = new Database();

                int row = Convert.ToInt32(db.excuteQuery(sql).Rows.Count);

                if (row > 0)
                {
                   
                    fTableManager f = new fTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                   

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
              
    
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
