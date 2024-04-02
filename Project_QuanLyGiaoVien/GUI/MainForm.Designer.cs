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
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhToánTiềnLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucThongTin1 = new QuanLyLichDay.GUI.ucThongTin();
            this.ucThongKeBaoCao1 = new QuanLyLichDay.GUI.ucThongKeBaoCao();
            this.ucTinhTienLuong1 = new QuanLyLichDay.ucTinhTienLuong();
            this.ucXemLichDay1 = new QuanLyLichDay.GUI.ucXemLichDay();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý thời gian dạy";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
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
            this.thốngKêBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.thốngKêBáoCáoToolStripMenuItem_Click);
            // 
            // ucThongTin1
            // 
            this.ucThongTin1.Account = null;
            this.ucThongTin1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ucThongTin1.Location = new System.Drawing.Point(1, 29);
            this.ucThongTin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucThongTin1.Name = "ucThongTin1";
            this.ucThongTin1.Size = new System.Drawing.Size(1100, 604);
            this.ucThongTin1.TabIndex = 4;
            // 
            // ucThongKeBaoCao1
            // 
            this.ucThongKeBaoCao1.Account = null;
            this.ucThongKeBaoCao1.Location = new System.Drawing.Point(0, 27);
            this.ucThongKeBaoCao1.Margin = new System.Windows.Forms.Padding(4);
            this.ucThongKeBaoCao1.Name = "ucThongKeBaoCao1";
            this.ucThongKeBaoCao1.Size = new System.Drawing.Size(1100, 606);
            this.ucThongKeBaoCao1.TabIndex = 3;
            this.ucThongKeBaoCao1.Load += new System.EventHandler(this.ucThongKeBaoCao1_Load);
            // 
            // ucTinhTienLuong1
            // 
            this.ucTinhTienLuong1.Account = null;
            this.ucTinhTienLuong1.Location = new System.Drawing.Point(0, 27);
            this.ucTinhTienLuong1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTinhTienLuong1.Name = "ucTinhTienLuong1";
            this.ucTinhTienLuong1.Size = new System.Drawing.Size(1100, 606);
            this.ucTinhTienLuong1.TabIndex = 2;
            // 
            // ucXemLichDay1
            // 
            this.ucXemLichDay1.Account = null;
            this.ucXemLichDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ucXemLichDay1.CurrentWeek = new System.DateTime(2024, 4, 1, 19, 14, 51, 335);
            this.ucXemLichDay1.Location = new System.Drawing.Point(0, 27);
            this.ucXemLichDay1.Margin = new System.Windows.Forms.Padding(4);
            this.ucXemLichDay1.Name = "ucXemLichDay1";
            this.ucXemLichDay1.Size = new System.Drawing.Size(1100, 606);
            this.ucXemLichDay1.TabIndex = 1;
            this.ucXemLichDay1.Load += new System.EventHandler(this.ucXemLichDay1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.Controls.Add(this.ucThongTin1);
            this.Controls.Add(this.ucThongKeBaoCao1);
            this.Controls.Add(this.ucTinhTienLuong1);
            this.Controls.Add(this.ucXemLichDay1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhToánTiềnLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ucXemLichDay ucXemLichDay1;
        private ucTinhTienLuong ucTinhTienLuong1;
        private ucThongKeBaoCao ucThongKeBaoCao1;
        private ucThongTin ucThongTin1;
    }
}