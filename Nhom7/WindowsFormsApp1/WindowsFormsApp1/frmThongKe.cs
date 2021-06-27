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
    public partial class frmThongKe : Form
    {
        string sCon = "Data Source=DESKTOP-GCVU3V9\\SQLEXPRESS;Initial Catalog=QLDANGKYTHI;Integrated Security=True";
        public frmThongKe()
        {
            InitializeComponent();
        }
        
        private void btnSLKT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string TruyVan = "select LEFT(MaKT, 2) Ki_Thi, count(MaKT) So_Luong_Ki_Thi from KI_THI where NgayThi between @from and @to group by LEFT(MaKT, 2)";
            string sFrom = dtFrom.Value.ToString("yyyy-MM-dd");
            string sTo = dtTo.Value.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand(TruyVan, con);

            cmd.Parameters.AddWithValue("@from", sFrom);
            cmd.Parameters.AddWithValue("to", sTo);

            DataTable TK = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            TK.Load(dr); dtgvTK.DataSource = TK;
            dtgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btnSLDK_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string TruyVan = "select LEFT(MaKT, 2) Ki_Thi, count(SoDT) So_Luong_Dang_Ki, sum(LePhi) Tong_Thu from DANG_KI where NgayDK between @from and @to group by LEFT(MaKT, 2)";
            string sFrom = dtFrom.Value.ToString("yyyy-MM-dd");
            string sTo = dtTo.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand(TruyVan, con);

            cmd.Parameters.AddWithValue("@from", sFrom);
            cmd.Parameters.AddWithValue("to", sTo);

            DataTable TK = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            TK.Load(dr); dtgvTK.DataSource = TK;
            dtgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
    }
}
