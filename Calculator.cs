using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_kq.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);

            txt_kq.Text = "" + (a + b);
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);

            txt_kq.Text = "" + (a - b);
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);

            txt_kq.Text = "" + (a * b);
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            
            if (b == 0)
            {
                txt_kq.Text = "Lỗi";
            }
            else
            {
                txt_kq.Text = "" + (a / b);
            }
        }
    }
}
