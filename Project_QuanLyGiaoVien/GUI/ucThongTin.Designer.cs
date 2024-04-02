namespace QuanLyLichDay.GUI
{
    partial class ucThongTin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TenGV = new System.Windows.Forms.TextBox();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_CCCD = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_TenGV = new System.Windows.Forms.Label();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_CCCD = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tb_DiaChi);
            this.panel1.Controls.Add(this.tb_SDT);
            this.panel1.Controls.Add(this.tb_CCCD);
            this.panel1.Controls.Add(this.dtp_Ngaysinh);
            this.panel1.Controls.Add(this.rbtn_Nam);
            this.panel1.Controls.Add(this.rbtn_Nu);
            this.panel1.Controls.Add(this.tb_TenGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 386);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(627, 344);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(194, 63);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(627, 210);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(194, 63);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Chỉnh sửa thông tin";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số CCCD:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_TenGV
            // 
            this.tb_TenGV.Location = new System.Drawing.Point(167, 40);
            this.tb_TenGV.Name = "tb_TenGV";
            this.tb_TenGV.Size = new System.Drawing.Size(241, 22);
            this.tb_TenGV.TabIndex = 7;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(262, 103);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(45, 20);
            this.rbtn_Nu.TabIndex = 9;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(167, 103);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(57, 20);
            this.rbtn_Nam.TabIndex = 10;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_Ngaysinh
            // 
            this.dtp_Ngaysinh.Location = new System.Drawing.Point(167, 162);
            this.dtp_Ngaysinh.Name = "dtp_Ngaysinh";
            this.dtp_Ngaysinh.Size = new System.Drawing.Size(241, 22);
            this.dtp_Ngaysinh.TabIndex = 11;
            this.dtp_Ngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tb_CCCD
            // 
            this.tb_CCCD.Location = new System.Drawing.Point(167, 216);
            this.tb_CCCD.Name = "tb_CCCD";
            this.tb_CCCD.Size = new System.Drawing.Size(241, 22);
            this.tb_CCCD.TabIndex = 12;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(167, 274);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(241, 22);
            this.tb_SDT.TabIndex = 13;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(167, 333);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(241, 22);
            this.tb_DiaChi.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lb_DiaChi);
            this.panel2.Controls.Add(this.lb_SDT);
            this.panel2.Controls.Add(this.lb_CCCD);
            this.panel2.Controls.Add(this.lb_NgaySinh);
            this.panel2.Controls.Add(this.lb_GioiTinh);
            this.panel2.Controls.Add(this.lb_TenGV);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(899, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 386);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giảng viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giới tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ngày sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số CCCD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Số điện thoại:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Địa chỉ:";
            // 
            // lb_TenGV
            // 
            this.lb_TenGV.AutoSize = true;
            this.lb_TenGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenGV.Location = new System.Drawing.Point(151, 27);
            this.lb_TenGV.Name = "lb_TenGV";
            this.lb_TenGV.Size = new System.Drawing.Size(76, 22);
            this.lb_TenGV.TabIndex = 21;
            this.lb_TenGV.Text = "Chưa có";
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(151, 85);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(76, 22);
            this.lb_GioiTinh.TabIndex = 22;
            this.lb_GioiTinh.Text = "Chưa có";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(151, 139);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(76, 22);
            this.lb_NgaySinh.TabIndex = 23;
            this.lb_NgaySinh.Text = "Chưa có";
            // 
            // lb_CCCD
            // 
            this.lb_CCCD.AutoSize = true;
            this.lb_CCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CCCD.Location = new System.Drawing.Point(151, 189);
            this.lb_CCCD.Name = "lb_CCCD";
            this.lb_CCCD.Size = new System.Drawing.Size(76, 22);
            this.lb_CCCD.TabIndex = 24;
            this.lb_CCCD.Text = "Chưa có";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(151, 245);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(76, 22);
            this.lb_SDT.TabIndex = 25;
            this.lb_SDT.Text = "Chưa có";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(151, 294);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(76, 22);
            this.lb_DiaChi.TabIndex = 26;
            this.lb_DiaChi.Text = "Chưa có";
            // 
            // ucThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucThongTin";
            this.Size = new System.Drawing.Size(1467, 746);
            this.Load += new System.EventHandler(this.ucThongTin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Ngaysinh;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.TextBox tb_TenGV;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_CCCD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_CCCD;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_TenGV;
    }
}
