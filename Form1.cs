using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //lay gia trị So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia trị So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //cong
            decimal dKQ = dSo1 + dSo2;
            //hien thi ket qua
            txtKQ.Text = dKQ.ToString();



        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            //lay gia trị So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia trị So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //tru
            decimal dKQ = dSo1 - dSo2;
            //hien thi ket qua
            txtKQ.Text = dKQ.ToString();

        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            //lay gia trị So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia trị So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //nhan
            decimal dKQ = dSo1 * dSo2;
            //hien thi ket qua
            txtKQ.Text = dKQ.ToString();
        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            //lay gia trị So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia trị So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //chia
            decimal dKQ = dSo1 / dSo2;
            //hien thi ket qua
            txtKQ.Text = dKQ.ToString();
        }
    }
}
