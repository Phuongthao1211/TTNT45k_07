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
    public partial class frmKT : Form
    {
        string sCon = "Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True";
        public frmKT()
        {
            InitializeComponent();
        }

        private void frmKT_Load(object sender, EventArgs e)
        {
            dtgvKT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "select * from KI_THI";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            DataTable KT = new DataTable(); SqlDataReader dr = cmd.ExecuteReader(); KT.Load(dr);
            dtgvKT.DataSource = KT;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvKT.CurrentRow.Index; txtMKT.Text =
            dtgvKT.Rows[i].Cells[0].Value.ToString(); txtPT.Text =
            dtgvKT.Rows[i].Cells[1].Value.ToString(); dtGT.Text =
            dtgvKT.Rows[i].Cells[3].Value.ToString(); txtSLTD.Text =
            dtgvKT.Rows[i].Cells[4].Value.ToString(); dtNT.Text =
            dtgvKT.Rows[i].Cells[2].Value.ToString(); txtSLDK.Text =
            dtgvKT.Rows[i].Cells[5].Value.ToString(); txtMKT.Enabled = false;

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "select * from KI_THI where MaKT like '%" + txttukhoa.Text + "%'";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            DataTable KT = new DataTable(); SqlDataReader dr = cmd.ExecuteReader(); KT.Load(dr);
            dtgvKT.DataSource = KT; dtgvKT.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill; con.Close();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sMakt = txtMKT.Text; string sPhongThi = txtPT.Text;
            string sNgayThi = NgayThi.Value.ToString("yyyy-MM-d"); 
            string sGioThi= GioThi.Value.ToString("HH:mm:ss"); 
            string sSoLuongToiDa = txtSLTD.Text;
            string sSoLuongDK = txtSLDK.Text;

            string sQuery = "update KI_THI set PhongThi = @PhongThi , NgayThi = @NgayThi , GioThi = @GioThi , SoLuongToiDa = @SoLuongToiDa, SoLuongDK = @SoLuongDK where MaKT = @MaKT";
            SqlCommand cmd = new SqlCommand(sQuery, con); cmd.Parameters.AddWithValue("@MaKT", sMakt);
            cmd.Parameters.AddWithValue("@PhongThi", sPhongThi); 
            cmd.Parameters.AddWithValue("@NgayThi", sNgayThi); 
            cmd.Parameters.AddWithValue("@GioThi", sGioThi); 
            cmd.Parameters.AddWithValue("@SoluongToiDa", sSoLuongToiDa); 
            cmd.Parameters.AddWithValue("@SoLuongDK", sSoLuongDK); 
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKT.Text = ""; txtPT.Text = ""; txtSLDK.Text = ""; txtSLDK.Text = ""; txtMKT.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuerye = "select * from KI_THI"; SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvKT.DataSource = KT; dtgvKT.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill; con.Close();

        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch 
            {
                MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "insert into KI_THI values (@MaKT, @PhongThi, @NgayThi, @GioThi, @SoLuongToiDa ,0)";
            SqlCommand cmd = new SqlCommand(sQuery, con); 
            cmd.Parameters.AddWithValue("@MaKT", txtMKT.Text); 
            cmd.Parameters.AddWithValue("@PhongThi", txtPT.Text);
            cmd.Parameters.AddWithValue("@NgayThi", NgayThi.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@GioThi", GioThi.Value.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@SoLuongToiDa", txtSLTD.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKT.Text = ""; txtPT.Text = ""; txtSLDK.Text = ""; txtSLTD.Text = ""; txtMKT.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thêm, hãy kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuerye = "select * from KI_THI"; 
            SqlCommand cmde = new SqlCommand(sQuerye, con); 
            DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvKT.DataSource = KT;
            dtgvKT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn xóa kì thi này?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sMaKT = txtMKT.Text;

                string sQuery = "delete DANG_KI where MaKT = @MaKT delete KI_THI where MaKT = @MaKT";
                SqlCommand cmd = new SqlCommand(sQuery, con); 
                cmd.Parameters.AddWithValue("@MaKT", sMaKT); 
                try
                {
                    cmd.ExecuteNonQuery(); 
                    txtMKT.Text = ""; 
                    txtPT.Text = ""; 
                    txtSLDK.Text = ""; 
                    txtSLTD.Text = ""; 
                    txtMKT.Enabled = true;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình xóa dữ liệu, kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sQuerye = "select * from KI_THI"; 
                SqlCommand cmde = new SqlCommand(sQuerye, con); 
                DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgvKT.DataSource = KT; dtgvKT.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }

        }
    }



}


