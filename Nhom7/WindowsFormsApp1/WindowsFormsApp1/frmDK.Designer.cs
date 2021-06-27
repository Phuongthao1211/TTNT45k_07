
namespace WindowsFormsApp1
{
    partial class frmDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHVT = new System.Windows.Forms.TextBox();
            this.txtSCMT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMKT = new System.Windows.Forms.TextBox();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.NgayDangKi = new System.Windows.Forms.DateTimePicker();
            this.btndangki = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridViewKT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỌ VÀ TÊN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SỐ CMT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SỐ ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY SINH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "MÃ KÌ THI ĐĂNG KÝ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "LỆ PHÍ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "NGÀY ĐĂNG KÍ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(216, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "ĐĂNG KÍ THI CHỨNG CHỈ";
            // 
            // txtHVT
            // 
            this.txtHVT.Location = new System.Drawing.Point(319, 98);
            this.txtHVT.Name = "txtHVT";
            this.txtHVT.Size = new System.Drawing.Size(237, 20);
            this.txtHVT.TabIndex = 8;
            // 
            // txtSCMT
            // 
            this.txtSCMT.Location = new System.Drawing.Point(319, 139);
            this.txtSCMT.Name = "txtSCMT";
            this.txtSCMT.Size = new System.Drawing.Size(237, 20);
            this.txtSCMT.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(319, 175);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(237, 20);
            this.txtSDT.TabIndex = 10;
            // 
            // txtMKT
            // 
            this.txtMKT.Location = new System.Drawing.Point(319, 240);
            this.txtMKT.Name = "txtMKT";
            this.txtMKT.Size = new System.Drawing.Size(237, 20);
            this.txtMKT.TabIndex = 11;
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(319, 276);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(237, 20);
            this.txtLP.TabIndex = 12;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(319, 201);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(237, 20);
            this.NgaySinh.TabIndex = 13;
            // 
            // NgayDangKi
            // 
            this.NgayDangKi.Location = new System.Drawing.Point(319, 310);
            this.NgayDangKi.Name = "NgayDangKi";
            this.NgayDangKi.Size = new System.Drawing.Size(237, 20);
            this.NgayDangKi.TabIndex = 14;
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.Blue;
            this.btndangki.Location = new System.Drawing.Point(174, 352);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(124, 41);
            this.btndangki.TabIndex = 15;
            this.btndangki.Text = "ĐĂNG KÍ";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Blue;
            this.btnxoa.Location = new System.Drawing.Point(381, 352);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(124, 41);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // dataGridViewKT
            // 
            this.dataGridViewKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKT.Location = new System.Drawing.Point(82, 399);
            this.dataGridViewKT.Name = "dataGridViewKT";
            this.dataGridViewKT.Size = new System.Drawing.Size(603, 164);
            this.dataGridViewKT.TabIndex = 17;
            // 
            // frmDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._48382820_322179758623756_4834527527542194176_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.dataGridViewKT);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.NgayDangKi);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txtLP);
            this.Controls.Add(this.txtMKT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtSCMT);
            this.Controls.Add(this.txtHVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.Load += new System.EventHandler(this.frmDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKT)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHVT;
        private System.Windows.Forms.TextBox txtSCMT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMKT;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.DateTimePicker NgayDangKi;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dataGridViewKT;
    }
}

