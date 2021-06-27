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

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True");
            try
            {
                conn.Open();
                    string tk = txtTK.Text;
                    string mk = txtMK.Text;
                string sql = "select * from nguoidung where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmDK KT = new frmDK();
                    KT.Show();
                    this.Hide();
                }    
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
