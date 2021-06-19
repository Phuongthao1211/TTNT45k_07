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
    public partial class frmDK : Form
    {
        public frmDK()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmDK_Load(object sender, EventArgs e)
        {

        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            string shovaten = txthovaten.Text;
            string smakithidangky = txtmakithidangky.Text;
            MessageBox.Show( shovaten + " đăng kí thành công");
        }
    }
}
