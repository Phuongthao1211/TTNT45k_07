
namespace WindowsFormsApp1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThíSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíKìThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíĐăngKíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKíToolStripMenuItem,
            this.quảnLíThíSinhToolStripMenuItem,
            this.quảnLíKìThiToolStripMenuItem,
            this.quảnLíĐăngKíToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngKíToolStripMenuItem
            // 
            this.đăngKíToolStripMenuItem.Name = "đăngKíToolStripMenuItem";
            this.đăngKíToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.đăngKíToolStripMenuItem.Text = "Đăng kí";
            this.đăngKíToolStripMenuItem.Click += new System.EventHandler(this.đăngKíToolStripMenuItem_Click);
            // 
            // quảnLíThíSinhToolStripMenuItem
            // 
            this.quảnLíThíSinhToolStripMenuItem.Name = "quảnLíThíSinhToolStripMenuItem";
            this.quảnLíThíSinhToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLíThíSinhToolStripMenuItem.Text = "Quản lí thí sinh";
            this.quảnLíThíSinhToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThíSinhToolStripMenuItem_Click);
            // 
            // quảnLíKìThiToolStripMenuItem
            // 
            this.quảnLíKìThiToolStripMenuItem.Name = "quảnLíKìThiToolStripMenuItem";
            this.quảnLíKìThiToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.quảnLíKìThiToolStripMenuItem.Text = "Quản lí kì thi";
            this.quảnLíKìThiToolStripMenuItem.Click += new System.EventHandler(this.quảnLíKìThiToolStripMenuItem_Click);
            // 
            // quảnLíĐăngKíToolStripMenuItem
            // 
            this.quảnLíĐăngKíToolStripMenuItem.Name = "quảnLíĐăngKíToolStripMenuItem";
            this.quảnLíĐăngKíToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLíĐăngKíToolStripMenuItem.Text = "Quản lí đăng kí";
            this.quảnLíĐăngKíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíĐăngKíToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._169949166_278158500436767_6573487535393771961_n1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÍ THI CHỨNG CHỈ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThíSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíKìThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíĐăngKíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}