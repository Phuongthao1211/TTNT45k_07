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
    public partial class frmQLDK : Form
    {
        string sCon = "Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True";
        public frmQLDK()
        {
            InitializeComponent();
        }

        private void frmQLDK_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
            }

            string sQuery = "select * from DANG_KI";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            DataTable KT = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            KT.Load(dr);
            dtgvDK.DataSource = KT;
            dtgvDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                MessageBox.Show("Lỗi khi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "select * from DANG_KI where SoDT like '%" + txttukhoa.Text + "%'";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            DataTable KT = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            KT.Load(dr);
            dtgvDK.DataSource = KT;
            dtgvDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa kì thi này?", "Thông báo", MessageBoxButtons.OKCancel);
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

                string sQuery = "delete DANG_KI where SoDT= @SoDT delete DANG_KI  where SoDT = @SoDT";

                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@SoDT ", sSoDT);
                try
                {
                    cmd.ExecuteNonQuery();
                    txtSDT.Text = "";
                    txtMKT.Text = "";

                    txtLP.Text = "";
                    txtSDT.Enabled = true;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu, kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sQuerye = "select * from DANG_KI";
                SqlCommand cmde = new SqlCommand(sQuerye, con);
                DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgvDK.DataSource = KT;
                dtgvDK.AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();

            


            }
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

            string sMaKT = txtMKT.Text;
            string sSDT = txtSDT.Text;
            string sLP = txtLP.Text;
            string sNgayDK = dtngaydk.Value.ToString("yyyy-MM-d");
            string sQuery = "update DANG_KI set NgayDK = @NgayDK, LePhi = @LePhi where SoDT = @SoDT and MaKT = @MaKT";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@NgayDK", sNgayDK);
            cmd.Parameters.AddWithValue("@MaKT", sMaKT);
            cmd.Parameters.AddWithValue("@LePhi", sLP);
            cmd.Parameters.AddWithValue("@SoDT", sSDT);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string sQuerye = "select * from DANG_KI";
            SqlCommand cmde = new SqlCommand(sQuerye, con);
            DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader();
            KT.Load(dr); dtgvDK.DataSource = KT;
            dtgvDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();



        }

        private void dtgvDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvDK.CurrentRow.Index;
            txtSDT.Text =
            dtgvDK.Rows[i].Cells[0].Value.ToString();
            txtMKT.Text =
           dtgvDK.Rows[i].Cells[1].Value.ToString();
            dtngaydk.Text =
            dtgvDK.Rows[i].Cells[2].Value.ToString();
            txtLP.Text =
           dtgvDK.Rows[i].Cells[3].Value.ToString();
            txtSDT.Enabled = false;
            txtMKT.Enabled = false;
        }
    }
}
    

