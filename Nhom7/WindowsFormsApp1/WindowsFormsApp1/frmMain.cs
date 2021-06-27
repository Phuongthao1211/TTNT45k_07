using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap taikhoan = new frmDangNhap();
            taikhoan.MdiParent = this;
            taikhoan.Show();

        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDK khach = new frmDK();
            khach.MdiParent = this;
            khach.Show();

        }

        private void quảnLíThíSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTS thisinh = new frmTS();
            thisinh.MdiParent = this;
            thisinh.Show();

        }

        private void quảnLíKìThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKT KiThi = new frmKT();
            KiThi.MdiParent = this;
            KiThi.Show();

        }

        private void quảnLíĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDK nguoidung = new frmQLDK();
            nguoidung.MdiParent = this;
            nguoidung.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe danhsach = new frmThongKe();
            danhsach.MdiParent = this;
            danhsach.Show();

        }
    }
}
