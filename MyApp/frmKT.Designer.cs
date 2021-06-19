
namespace MyApp
{
    partial class frmKT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKT));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmakithi = new System.Windows.Forms.TextBox();
            this.txtphongthi = new System.Windows.Forms.TextBox();
            this.txtsoluongtoida = new System.Windows.Forms.TextBox();
            this.txtsoluongdangki = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "MÃ KÌ THI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PHÒNG THI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "NGÀY THI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "GIỜ THI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SỐ LƯỢNG TỐI ĐA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "SỐ LƯỢNG ĐĂNG KÍ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtmakithi
            // 
            this.txtmakithi.Location = new System.Drawing.Point(581, 85);
            this.txtmakithi.Name = "txtmakithi";
            this.txtmakithi.Size = new System.Drawing.Size(293, 22);
            this.txtmakithi.TabIndex = 10;
            // 
            // txtphongthi
            // 
            this.txtphongthi.Location = new System.Drawing.Point(581, 124);
            this.txtphongthi.Name = "txtphongthi";
            this.txtphongthi.Size = new System.Drawing.Size(293, 22);
            this.txtphongthi.TabIndex = 11;
            this.txtphongthi.TextChanged += new System.EventHandler(this.txtphongthi_TextChanged);
            // 
            // txtsoluongtoida
            // 
            this.txtsoluongtoida.Location = new System.Drawing.Point(581, 239);
            this.txtsoluongtoida.Name = "txtsoluongtoida";
            this.txtsoluongtoida.Size = new System.Drawing.Size(293, 22);
            this.txtsoluongtoida.TabIndex = 14;
            this.txtsoluongtoida.TextChanged += new System.EventHandler(this.txtsoluongtoida_TextChanged);
            // 
            // txtsoluongdangki
            // 
            this.txtsoluongdangki.Location = new System.Drawing.Point(581, 280);
            this.txtsoluongdangki.Name = "txtsoluongdangki";
            this.txtsoluongdangki.Size = new System.Drawing.Size(293, 22);
            this.txtsoluongdangki.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(481, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "QUẢN LÍ KÌ THI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Blue;
            this.btnluu.Location = new System.Drawing.Point(386, 324);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(88, 44);
            this.btnluu.TabIndex = 19;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btntaomoi
            // 
            this.btntaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoi.ForeColor = System.Drawing.Color.Blue;
            this.btntaomoi.Location = new System.Drawing.Point(564, 324);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(125, 44);
            this.btntaomoi.TabIndex = 20;
            this.btntaomoi.Text = "TẠO MỚI";
            this.btntaomoi.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Blue;
            this.btnxoa.Location = new System.Drawing.Point(769, 324);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 44);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 202);
            this.dataGridView1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(581, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // frmKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyApp.Properties.Resources.e73b50cf0ec5b9209409368b3430c6011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 638);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoluongdangki);
            this.Controls.Add(this.txtsoluongtoida);
            this.Controls.Add(this.txtphongthi);
            this.Controls.Add(this.txtmakithi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kì thi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmakithi;
        private System.Windows.Forms.TextBox txtphongthi;
        private System.Windows.Forms.TextBox txtsoluongtoida;
        private System.Windows.Forms.TextBox txtsoluongdangki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}