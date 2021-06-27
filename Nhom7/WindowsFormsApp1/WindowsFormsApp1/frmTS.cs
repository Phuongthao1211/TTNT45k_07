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

    public partial class frmTS : Form
    {
        string sCon = "Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True";
        public frmTS()
        {
            InitializeComponent();
        }

        private void frmTS_Load(object sender, EventArgs e)
        {
            dtgvTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "select * from THI_SINH";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            DataTable KT = new DataTable(); SqlDataReader dr = cmd.ExecuteReader(); KT.Load(dr);
            dtgvTS.DataSource = KT;

            con.Close();
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
            string sQuery = "select * from THI_SINH where SoDT like '%" + txttukhoa.Text + "%'";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            DataTable KT = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            KT.Load(dr);
            dtgvTS.DataSource = KT;
            dtgvTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void dtgvTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int i;
            i = dtgvTS.CurrentRow.Index;
            txtSDT.Text = dtgvTS.Rows[i].Cells[0].Value.ToString();
            txtTTS.Text = dtgvTS.Rows[i].Cells[1].Value.ToString();
            txtSCMT.Text = dtgvTS.Rows[i].Cells[2].Value.ToString();
            dtNS.Text = dtgvTS.Rows[i].Cells[3].Value.ToString();
            txtSDT.Enabled = false;

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
                MessageBox.Show("Llỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sHoTen = txtTTS.Text;
            string sSoDT = txtSDT.Text;
            string sSoCMT = txtSCMT.Text;
            string sNgaySinh = dtNS.Value.ToString("yyyy-MM-d");
            string sQuery = "update THI_SINH set NgaySinh = @NgaySinh , HoTen = @HoTen, SoCMT = @SoCMT where SoDT = @SoDT ";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@HoTen", sHoTen);
            cmd.Parameters.AddWithValue("@SoCMT", sSoCMT);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@SoDT", sSoDT);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi cập nhật, kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuerye = "SELECT * from THI_SINH";
            SqlCommand cmde = new SqlCommand(sQuerye, con);
            DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader();
            KT.Load(dr);
            dtgvTS.DataSource = KT;
            dtgvTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa thí sinh này?", "Thông báo", MessageBoxButtons.OKCancel);
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
                string sSoDT = txtSDT.Text;

                string sQuery = "delete THI_SINH where SoDT= @SoDT delete THI_SINH  where SoDT = @SoDT";

                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@SoDT ", sSoDT);
                try
                {
                    cmd.ExecuteNonQuery();
                    txtSDT.Text = "";
                    txtTTS.Text = "";

                    txtSCMT.Text = "";
                    txtSDT.Enabled = true;
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu, kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sQuerye = "select * from THI_SINH";
                SqlCommand cmde = new SqlCommand(sQuerye, con);
                DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgvTS.DataSource = KT;
                dtgvTS.AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();

            }

        }
    }
}

   





