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
    
    public partial class fTableManager : Form
    {
        bool isExit = true;
        public fTableManager()
        {
            InitializeComponent();
        }

        private void cậpNhậtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdate f = new fUpdate();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fImport f = new fImport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNSX f = new fNSX();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchLoạiThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fType f = new fType();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSale f = new fSale();

            f.MdiParent = this;

            //f.ShowDialog();

            f.Show();

        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
        private void fTableManager_Load(object sender, EventArgs e)
        {
            
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListSale f = new fListSale();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListImport f = new fListImport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            fLogin f = new fLogin();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
    }
}
