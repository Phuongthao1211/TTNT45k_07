
namespace WindowsFormsApp1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NgayThi = new System.Windows.Forms.DateTimePicker();
            this.GioThi = new System.Windows.Forms.DateTimePicker();
            this.txtMKT = new System.Windows.Forms.TextBox();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.txtSLTD = new System.Windows.Forms.TextBox();
            this.txtSLDK = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dtgvKT = new System.Windows.Forms.DataGridView();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKT)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(253, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "QUẢN LÍ KÌ THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "MÃ KÌ THI:";
            // 
            // dtNT
            // 
            this.dtNT.AutoSize = true;
            this.dtNT.BackColor = System.Drawing.Color.Transparent;
            this.dtNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNT.Location = new System.Drawing.Point(142, 159);
            this.dtNT.Name = "dtNT";
            this.dtNT.Size = new System.Drawing.Size(83, 16);
            this.dtNT.TabIndex = 12;
            this.dtNT.Text = "NGÀY THI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "PHÒNG THI:";
            // 
            // dtGT
            // 
            this.dtGT.AutoSize = true;
            this.dtGT.BackColor = System.Drawing.Color.Transparent;
            this.dtGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGT.Location = new System.Drawing.Point(142, 195);
            this.dtGT.Name = "dtGT";
            this.dtGT.Size = new System.Drawing.Size(67, 16);
            this.dtGT.TabIndex = 14;
            this.dtGT.Text = "GIỜ THI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "SỐ LƯỢNG TỐI ĐA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "SỐ LƯỢNG ĐĂNG KÍ:";
            // 
            // NgayThi
            // 
            this.NgayThi.Location = new System.Drawing.Point(325, 155);
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Size = new System.Drawing.Size(236, 20);
            this.NgayThi.TabIndex = 17;
            // 
            // GioThi
            // 
            this.GioThi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.GioThi.Location = new System.Drawing.Point(325, 191);
            this.GioThi.Name = "GioThi";
            this.GioThi.Size = new System.Drawing.Size(117, 20);
            this.GioThi.TabIndex = 18;
            // 
            // txtMKT
            // 
            this.txtMKT.Location = new System.Drawing.Point(325, 80);
            this.txtMKT.Name = "txtMKT";
            this.txtMKT.Size = new System.Drawing.Size(236, 20);
            this.txtMKT.TabIndex = 19;
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(325, 119);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(236, 20);
            this.txtPT.TabIndex = 20;
            // 
            // txtSLTD
            // 
            this.txtSLTD.Location = new System.Drawing.Point(325, 234);
            this.txtSLTD.Name = "txtSLTD";
            this.txtSLTD.Size = new System.Drawing.Size(236, 20);
            this.txtSLTD.TabIndex = 21;
            // 
            // txtSLDK
            // 
            this.txtSLDK.Location = new System.Drawing.Point(326, 275);
            this.txtSLDK.Name = "txtSLDK";
            this.txtSLDK.Size = new System.Drawing.Size(236, 20);
            this.txtSLDK.TabIndex = 22;
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Blue;
            this.btnluu.Location = new System.Drawing.Point(145, 317);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(118, 41);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "CHỈNH SỬA";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoi.ForeColor = System.Drawing.Color.Blue;
            this.btntaomoi.Location = new System.Drawing.Point(291, 317);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(116, 41);
            this.btntaomoi.TabIndex = 24;
            this.btntaomoi.Text = "THÊM";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Blue;
            this.btnxoa.Location = new System.Drawing.Point(442, 317);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(119, 41);
            this.btnxoa.TabIndex = 25;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dtgvKT
            // 
            this.dtgvKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKT.Location = new System.Drawing.Point(101, 433);
            this.dtgvKT.Name = "dtgvKT";
            this.dtgvKT.Size = new System.Drawing.Size(606, 165);
            this.dtgvKT.TabIndex = 26;
            this.dtgvKT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(358, 403);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(236, 20);
            this.txttukhoa.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nhập từ khóa:";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.ForeColor = System.Drawing.Color.Blue;
            this.btntim.Location = new System.Drawing.Point(613, 395);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(94, 32);
            this.btntim.TabIndex = 30;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // frmKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._48382820_322179758623756_4834527527542194176_n3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 618);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.dtgvKT);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtSLDK);
            this.Controls.Add(this.txtSLTD);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.txtMKT);
            this.Controls.Add(this.GioThi);
            this.Controls.Add(this.NgayThi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtGT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kì thi";
            this.Load += new System.EventHandler(this.frmKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dtNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dtGT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NgayThi;
        private System.Windows.Forms.DateTimePicker GioThi;
        private System.Windows.Forms.TextBox txtMKT;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.TextBox txtSLTD;
        private System.Windows.Forms.TextBox txtSLDK;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dtgvKT;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntim;
    }
}