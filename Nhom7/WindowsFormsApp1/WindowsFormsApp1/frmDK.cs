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
    public partial class frmDK : Form
    {
        string sCon = "Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True";
        public frmDK()
        {
            InitializeComponent();
        }

        private void frmDK_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {

                MessageBox.Show("LỖI KẾT NỐI!");
            }
            string sQuerye = "select * from KI_THI";

            SqlCommand cmde = new SqlCommand(sQuerye, con); 
            DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dataGridViewKT.DataSource = KT; 
            dataGridViewKT.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill; con.Close();
        }



        private void dtgvKT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a, b, c;
            a = dataGridViewKT.CurrentRow.Index; b =
            Convert.ToInt32(dataGridViewKT.Rows[a].Cells[4].Value.ToString()); c =
            Convert.ToInt32(dataGridViewKT.Rows[a].Cells[5].Value.ToString());

            if (b == c)
            {
                MessageBox.Show("LỚP ĐẦY, MỜI CHỌN LẠI!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                txtMKT.Text =
                dataGridViewKT.Rows[a].Cells[0].Value.ToString();
                MessageBox.Show("ĐÃ CHỌN MÃ KÌ THI: " + txtMKT.Text + ".", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }

           catch 
            {
                MessageBox.Show("LỖI KẾT NỐI!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sCheck = "Select * from THI_SINH where SoDT = '" + txtSDT.Text + "'";
             SqlCommand cmdC = new SqlCommand(sCheck, con); 
            SqlDataReader dtr = cmdC.ExecuteReader();
            if (dtr.Read() == true)
            {
                txtHVT.Text = dtr["HoTen"].ToString(); txtSCMT.Text = dtr["SoCMT"].ToString(); NgaySinh.Text = dtr["NgaySinh"].ToString();
                MessageBox.Show("THI SINH ĐÃ TỒN TẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void btndangki_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch 
            {
                MessageBox.Show("LỖI KẾT NỐI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sHoTen = txtHVT.Text; 
            string sSoDT = txtSDT.Text; 
            string sSoCMT = txtSCMT.Text;
            string sMaKT = txtMKT.Text; 
            string sLePhi = txtLP.Text;
            string sNgaySinh = NgaySinh.Value.ToString("yyyy-MM-d");
            string sNgayDK = NgayDangKi.Value.ToString("yyyy-MM-d");
            string sQuery2 = "insert into DANG_KI values (@SoDT, @MaKT, @NgayDK, @LePhi)";
            string sQuery = "insert into THI_SINH values (@SoDT, @HoTen, @SoCMT, @NgaySinh)";
            string Squery3 = "update KI_THI set SoLuongDK = SoLuongDK + 1 where MaKT = @MaKT";
            string sQuery4 = "update THI_SINH set HoTen = @HoTen, SoCMT = @SoCMT, NgaySinh = @NgaySinh where SoDT = @SoDT";
            SqlCommand cmd = new SqlCommand(sQuery, con); 
            SqlCommand cmd1 = new SqlCommand(sQuery2, con); 
            SqlCommand cmd2 = new SqlCommand(Squery3, con);
            SqlCommand cmd3 = new SqlCommand(sQuery4, con);
            cmd.Parameters.AddWithValue("@SoDT", sSoDT);
            cmd.Parameters.AddWithValue("@HoTen", sHoTen);
            cmd.Parameters.AddWithValue("@SoCMT", sSoCMT);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd1.Parameters.AddWithValue("@SoDT", sSoDT); 
            cmd1.Parameters.AddWithValue("@MaKT", sMaKT); 
            cmd1.Parameters.AddWithValue("@NgayDK", sNgayDK); 
            cmd1.Parameters.AddWithValue("@LePhi", sLePhi); 
            cmd2.Parameters.AddWithValue("@MaKT", sMaKT); 
            cmd3.Parameters.AddWithValue("@SoDT", sSoDT); 
            cmd3.Parameters.AddWithValue("@HoTen", sHoTen);
            cmd3.Parameters.AddWithValue("@SoCMT", sSoCMT);
            cmd3.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            string sCheck = "Select * from THI_SINH where SoDT = '" + txtSDT.Text + "'";
            SqlCommand cmdC = new SqlCommand(sCheck, con); 
            SqlDataReader dtr = cmdC.ExecuteReader();
            if (dtr.Read() == true)
            {
                try
                {
                    dtr.Close();
                    cmd1.ExecuteNonQuery(); 
                    cmd2.ExecuteNonQuery(); 
                    cmd3.ExecuteNonQuery(); 
                    MessageBox.Show("ĐĂNG KÍ THÀNH CÔNG!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSCMT.Text = ""; 
                    txtHVT.Text = ""; 
                    txtLP.Text = ""; 
                    txtMKT.Text = ""; 
                    txtSDT.Text = "";
                }
                catch
                {
                    MessageBox.Show("LỖI! KIỂM TRA LẠI THÔNG TIN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                try
                {
                    dtr.Close(); cmd.ExecuteNonQuery(); 
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công!!!",

                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSCMT.Text = ""; txtHVT.Text = ""; txtLP.Text = ""; txtMKT.Text = ""; txtSDT.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string sQuerye = "select * from KI_THI";
            SqlCommand cmde = new SqlCommand(sQuerye, con); 
            DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dataGridViewKT.DataSource = KT; dataGridViewKT.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill; 
            con.Close();

        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            txtSCMT.Text = "";
            txtHVT.Text = "";
            txtLP.Text = "";
            txtMKT.Text = "";
            txtSDT.Text = "";
        }
    }

}






