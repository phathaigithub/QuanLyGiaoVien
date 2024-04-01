namespace QuanLyLichDay.GUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhToánTiềnLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucXemLichDay1 = new QuanLyLichDay.GUI.ucXemLichDay();
            this.ucTinhTienLuong1 = new QuanLyLichDay.ucTinhTienLuong();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.tínhToánTiềnLươngToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinTàiKhoảnToolStripMenuItem,
            this.xemThônToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // xemThôngTinTàiKhoảnToolStripMenuItem
            // 
            this.xemThôngTinTàiKhoảnToolStripMenuItem.Name = "xemThôngTinTàiKhoảnToolStripMenuItem";
            this.xemThôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.xemThôngTinTàiKhoảnToolStripMenuItem.Text = "Xem thông tin tài khoản";
            // 
            // xemThônToolStripMenuItem
            // 
            this.xemThônToolStripMenuItem.Name = "xemThônToolStripMenuItem";
            this.xemThônToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.xemThônToolStripMenuItem.Text = "Xem thông tin hợp đồng";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemLịchDạyToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý thời gian dạy";
            // 
            // xemLịchDạyToolStripMenuItem
            // 
            this.xemLịchDạyToolStripMenuItem.Name = "xemLịchDạyToolStripMenuItem";
            this.xemLịchDạyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.xemLịchDạyToolStripMenuItem.Text = "Xem lịch dạy";
            this.xemLịchDạyToolStripMenuItem.Click += new System.EventHandler(this.xemLịchDạyToolStripMenuItem_Click);
            // 
            // tínhToánTiềnLươngToolStripMenuItem
            // 
            this.tínhToánTiềnLươngToolStripMenuItem.Name = "tínhToánTiềnLươngToolStripMenuItem";
            this.tínhToánTiềnLươngToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.tínhToánTiềnLươngToolStripMenuItem.Text = "Tính toán tiền lương";
            this.tínhToánTiềnLươngToolStripMenuItem.Click += new System.EventHandler(this.tínhToánTiềnLươngToolStripMenuItem_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê & báo cáo";
            // 
            // ucXemLichDay1
            // 
            this.ucXemLichDay1.Account = null;
            this.ucXemLichDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ucXemLichDay1.CurrentWeek = new System.DateTime(2024, 4, 1, 19, 14, 51, 335);
            this.ucXemLichDay1.Location = new System.Drawing.Point(0, 27);
            this.ucXemLichDay1.Name = "ucXemLichDay1";
            this.ucXemLichDay1.Size = new System.Drawing.Size(1100, 606);
            this.ucXemLichDay1.TabIndex = 1;
            this.ucXemLichDay1.Load += new System.EventHandler(this.ucXemLichDay1_Load);
            // 
            // ucTinhTienLuong1
            // 
            this.ucTinhTienLuong1.Account = null;
            this.ucTinhTienLuong1.Location = new System.Drawing.Point(0, 27);
            this.ucTinhTienLuong1.Name = "ucTinhTienLuong1";
            this.ucTinhTienLuong1.Size = new System.Drawing.Size(1100, 606);
            this.ucTinhTienLuong1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.Controls.Add(this.ucTinhTienLuong1);
            this.Controls.Add(this.ucXemLichDay1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhToánTiềnLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchDạyToolStripMenuItem;
        private ucXemLichDay ucXemLichDay1;
        private ucTinhTienLuong ucTinhTienLuong1;
    }
}