
namespace WindowsFormsApp1
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnSLDK = new System.Windows.Forms.Button();
            this.btnSLKT = new System.Windows.Forms.Button();
            this.dtgvTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(275, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "BẢNG THỐNG KÊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "TỪ NGÀY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐẾN NGÀY:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(145, 103);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(236, 20);
            this.dtFrom.TabIndex = 18;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(504, 103);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(236, 20);
            this.dtTo.TabIndex = 19;
            // 
            // btnSLDK
            // 
            this.btnSLDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLDK.ForeColor = System.Drawing.Color.Blue;
            this.btnSLDK.Location = new System.Drawing.Point(276, 152);
            this.btnSLDK.Name = "btnSLDK";
            this.btnSLDK.Size = new System.Drawing.Size(252, 46);
            this.btnSLDK.TabIndex = 20;
            this.btnSLDK.Text = "SỐ LƯỢNG ĐĂNG KÍ";
            this.btnSLDK.UseVisualStyleBackColor = true;
            this.btnSLDK.Click += new System.EventHandler(this.btnSLDK_Click_1);
            // 
            // btnSLKT
            // 
            this.btnSLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLKT.ForeColor = System.Drawing.Color.Blue;
            this.btnSLKT.Location = new System.Drawing.Point(276, 204);
            this.btnSLKT.Name = "btnSLKT";
            this.btnSLKT.Size = new System.Drawing.Size(252, 46);
            this.btnSLKT.TabIndex = 21;
            this.btnSLKT.Text = "SỐ LƯỢNG KÌ THI";
            this.btnSLKT.UseVisualStyleBackColor = true;
            this.btnSLKT.Click += new System.EventHandler(this.btnSLKT_Click);
            // 
            // dtgvTK
            // 
            this.dtgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTK.Location = new System.Drawing.Point(63, 273);
            this.dtgvTK.Name = "dtgvTK";
            this.dtgvTK.Size = new System.Drawing.Size(677, 216);
            this.dtgvTK.TabIndex = 22;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._48382820_322179758623756_4834527527542194176_n4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.dtgvTK);
            this.Controls.Add(this.btnSLKT);
            this.Controls.Add(this.btnSLDK);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnSLDK;
        private System.Windows.Forms.Button btnSLKT;
        private System.Windows.Forms.DataGridView dtgvTK;
    }
}