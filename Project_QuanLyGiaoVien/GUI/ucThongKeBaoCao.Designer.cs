namespace QuanLyLichDay.GUI
{
    partial class ucThongKeBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpk_To = new System.Windows.Forms.DateTimePicker();
            this.dtpk_From = new System.Windows.Forms.DateTimePicker();
            this.lb_BaoCaoThongKe = new System.Windows.Forms.Label();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.pn_BaoCao = new System.Windows.Forms.Panel();
            this.btn_XuatDuLieu = new System.Windows.Forms.Button();
            this.btn_HienThiThongTin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ChuaDay = new System.Windows.Forms.TextBox();
            this.lb_ChuaDay = new System.Windows.Forms.Label();
            this.tb_TongGioDay = new System.Windows.Forms.TextBox();
            this.lb_DaDay = new System.Windows.Forms.Label();
            this.lb_TongSoGioDay = new System.Windows.Forms.Label();
            this.lb_Tong = new System.Windows.Forms.Label();
            this.lb_TongThuNhap = new System.Windows.Forms.Label();
            this.tb_DaDay = new System.Windows.Forms.TextBox();
            this.tb_TongThuNhap = new System.Windows.Forms.TextBox();
            this.tb_TongCaDay = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn_ThongKe = new System.Windows.Forms.Panel();
            this.c_Salary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Vang = new System.Windows.Forms.Label();
            this.tb_Vang = new System.Windows.Forms.TextBox();
            this.pn_BaoCao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pn_ThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpk_To
            // 
            this.dtpk_To.CustomFormat = "dd-MM-yyyy";
            this.dtpk_To.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_To.Location = new System.Drawing.Point(120, 116);
            this.dtpk_To.Name = "dtpk_To";
            this.dtpk_To.Size = new System.Drawing.Size(200, 26);
            this.dtpk_To.TabIndex = 2;
            // 
            // dtpk_From
            // 
            this.dtpk_From.CustomFormat = "dd-MM-yyyy";
            this.dtpk_From.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_From.Location = new System.Drawing.Point(120, 67);
            this.dtpk_From.Name = "dtpk_From";
            this.dtpk_From.Size = new System.Drawing.Size(200, 26);
            this.dtpk_From.TabIndex = 3;
            // 
            // lb_BaoCaoThongKe
            // 
            this.lb_BaoCaoThongKe.AutoSize = true;
            this.lb_BaoCaoThongKe.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BaoCaoThongKe.Location = new System.Drawing.Point(97, 23);
            this.lb_BaoCaoThongKe.Name = "lb_BaoCaoThongKe";
            this.lb_BaoCaoThongKe.Size = new System.Drawing.Size(181, 25);
            this.lb_BaoCaoThongKe.TabIndex = 4;
            this.lb_BaoCaoThongKe.Text = "Thống kê dữ liệu";
            this.lb_BaoCaoThongKe.Click += new System.EventHandler(this.lb_BaoCaoThongKe_Click);
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(71, 67);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(33, 19);
            this.lb_From.TabIndex = 5;
            this.lb_From.Text = "Từ:";
            this.lb_From.Click += new System.EventHandler(this.lb_From_Click);
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(67, 122);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(45, 19);
            this.lb_To.TabIndex = 6;
            this.lb_To.Text = "Đến:";
            this.lb_To.Click += new System.EventHandler(this.lb_To_Click);
            // 
            // pn_BaoCao
            // 
            this.pn_BaoCao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_BaoCao.Controls.Add(this.btn_XuatDuLieu);
            this.pn_BaoCao.Controls.Add(this.btn_HienThiThongTin);
            this.pn_BaoCao.Controls.Add(this.panel1);
            this.pn_BaoCao.Controls.Add(this.lb_BaoCaoThongKe);
            this.pn_BaoCao.Controls.Add(this.dtpk_To);
            this.pn_BaoCao.Controls.Add(this.dtpk_From);
            this.pn_BaoCao.Controls.Add(this.lb_To);
            this.pn_BaoCao.Controls.Add(this.lb_From);
            this.pn_BaoCao.Location = new System.Drawing.Point(25, 25);
            this.pn_BaoCao.Name = "pn_BaoCao";
            this.pn_BaoCao.Size = new System.Drawing.Size(400, 556);
            this.pn_BaoCao.TabIndex = 7;
            // 
            // btn_XuatDuLieu
            // 
            this.btn_XuatDuLieu.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatDuLieu.Location = new System.Drawing.Point(225, 491);
            this.btn_XuatDuLieu.Name = "btn_XuatDuLieu";
            this.btn_XuatDuLieu.Size = new System.Drawing.Size(150, 40);
            this.btn_XuatDuLieu.TabIndex = 20;
            this.btn_XuatDuLieu.Text = "Xuất dữ liệu";
            this.btn_XuatDuLieu.UseVisualStyleBackColor = true;
            this.btn_XuatDuLieu.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_HienThiThongTin
            // 
            this.btn_HienThiThongTin.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThiThongTin.Location = new System.Drawing.Point(25, 491);
            this.btn_HienThiThongTin.Name = "btn_HienThiThongTin";
            this.btn_HienThiThongTin.Size = new System.Drawing.Size(150, 40);
            this.btn_HienThiThongTin.TabIndex = 14;
            this.btn_HienThiThongTin.Text = "Hiển thị dữ liệu";
            this.btn_HienThiThongTin.UseVisualStyleBackColor = true;
            this.btn_HienThiThongTin.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lb_Vang);
            this.panel1.Controls.Add(this.tb_Vang);
            this.panel1.Controls.Add(this.tb_ChuaDay);
            this.panel1.Controls.Add(this.lb_ChuaDay);
            this.panel1.Controls.Add(this.tb_TongGioDay);
            this.panel1.Controls.Add(this.lb_DaDay);
            this.panel1.Controls.Add(this.lb_TongSoGioDay);
            this.panel1.Controls.Add(this.lb_Tong);
            this.panel1.Controls.Add(this.lb_TongThuNhap);
            this.panel1.Controls.Add(this.tb_DaDay);
            this.panel1.Controls.Add(this.tb_TongThuNhap);
            this.panel1.Controls.Add(this.tb_TongCaDay);
            this.panel1.Location = new System.Drawing.Point(25, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 300);
            this.panel1.TabIndex = 19;
            // 
            // tb_ChuaDay
            // 
            this.tb_ChuaDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuaDay.Location = new System.Drawing.Point(50, 100);
            this.tb_ChuaDay.Name = "tb_ChuaDay";
            this.tb_ChuaDay.Size = new System.Drawing.Size(75, 26);
            this.tb_ChuaDay.TabIndex = 14;
            // 
            // lb_ChuaDay
            // 
            this.lb_ChuaDay.AutoSize = true;
            this.lb_ChuaDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuaDay.Location = new System.Drawing.Point(50, 78);
            this.lb_ChuaDay.Name = "lb_ChuaDay";
            this.lb_ChuaDay.Size = new System.Drawing.Size(75, 19);
            this.lb_ChuaDay.TabIndex = 15;
            this.lb_ChuaDay.Text = "Chưa dạy";
            this.lb_ChuaDay.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_TongGioDay
            // 
            this.tb_TongGioDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongGioDay.Location = new System.Drawing.Point(75, 180);
            this.tb_TongGioDay.Name = "tb_TongGioDay";
            this.tb_TongGioDay.Size = new System.Drawing.Size(200, 26);
            this.tb_TongGioDay.TabIndex = 10;
            this.tb_TongGioDay.TextChanged += new System.EventHandler(this.tb_TongGioDay_TextChanged);
            // 
            // lb_DaDay
            // 
            this.lb_DaDay.AutoSize = true;
            this.lb_DaDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DaDay.Location = new System.Drawing.Point(147, 78);
            this.lb_DaDay.Name = "lb_DaDay";
            this.lb_DaDay.Size = new System.Drawing.Size(57, 19);
            this.lb_DaDay.TabIndex = 17;
            this.lb_DaDay.Text = "Đã dạy";
            // 
            // lb_TongSoGioDay
            // 
            this.lb_TongSoGioDay.AutoSize = true;
            this.lb_TongSoGioDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSoGioDay.Location = new System.Drawing.Point(73, 158);
            this.lb_TongSoGioDay.Name = "lb_TongSoGioDay";
            this.lb_TongSoGioDay.Size = new System.Drawing.Size(104, 19);
            this.lb_TongSoGioDay.TabIndex = 11;
            this.lb_TongSoGioDay.Text = "Tổng giờ dạy:";
            // 
            // lb_Tong
            // 
            this.lb_Tong.AutoSize = true;
            this.lb_Tong.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tong.Location = new System.Drawing.Point(46, 8);
            this.lb_Tong.Name = "lb_Tong";
            this.lb_Tong.Size = new System.Drawing.Size(90, 19);
            this.lb_Tong.TabIndex = 9;
            this.lb_Tong.Text = "Tổng số ca:";
            this.lb_Tong.Click += new System.EventHandler(this.lb_Tong_Click);
            // 
            // lb_TongThuNhap
            // 
            this.lb_TongThuNhap.AutoSize = true;
            this.lb_TongThuNhap.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongThuNhap.Location = new System.Drawing.Point(71, 228);
            this.lb_TongThuNhap.Name = "lb_TongThuNhap";
            this.lb_TongThuNhap.Size = new System.Drawing.Size(115, 19);
            this.lb_TongThuNhap.TabIndex = 12;
            this.lb_TongThuNhap.Text = "Tổng thu nhập:";
            // 
            // tb_DaDay
            // 
            this.tb_DaDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DaDay.Location = new System.Drawing.Point(138, 100);
            this.tb_DaDay.Name = "tb_DaDay";
            this.tb_DaDay.Size = new System.Drawing.Size(75, 26);
            this.tb_DaDay.TabIndex = 16;
            // 
            // tb_TongThuNhap
            // 
            this.tb_TongThuNhap.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongThuNhap.Location = new System.Drawing.Point(75, 250);
            this.tb_TongThuNhap.Name = "tb_TongThuNhap";
            this.tb_TongThuNhap.Size = new System.Drawing.Size(200, 26);
            this.tb_TongThuNhap.TabIndex = 13;
            this.tb_TongThuNhap.TextChanged += new System.EventHandler(this.tb_TongThuNhap_TextChanged);
            // 
            // tb_TongCaDay
            // 
            this.tb_TongCaDay.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongCaDay.Location = new System.Drawing.Point(50, 30);
            this.tb_TongCaDay.Name = "tb_TongCaDay";
            this.tb_TongCaDay.Size = new System.Drawing.Size(250, 26);
            this.tb_TongCaDay.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(16, 58);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pn_ThongKe
            // 
            this.pn_ThongKe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pn_ThongKe.Controls.Add(this.c_Salary);
            this.pn_ThongKe.Location = new System.Drawing.Point(450, 25);
            this.pn_ThongKe.Name = "pn_ThongKe";
            this.pn_ThongKe.Size = new System.Drawing.Size(625, 556);
            this.pn_ThongKe.TabIndex = 8;
            // 
            // c_Salary
            // 
            chartArea1.Name = "ChartArea1";
            this.c_Salary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c_Salary.Legends.Add(legend1);
            this.c_Salary.Location = new System.Drawing.Point(3, 0);
            this.c_Salary.Name = "c_Salary";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Lương";
            this.c_Salary.Series.Add(series1);
            this.c_Salary.Size = new System.Drawing.Size(625, 556);
            this.c_Salary.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ lương";
            this.c_Salary.Titles.Add(title1);
            this.c_Salary.Click += new System.EventHandler(this.c_Salary_Click);
            // 
            // lb_Vang
            // 
            this.lb_Vang.AutoSize = true;
            this.lb_Vang.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vang.Location = new System.Drawing.Point(241, 78);
            this.lb_Vang.Name = "lb_Vang";
            this.lb_Vang.Size = new System.Drawing.Size(44, 19);
            this.lb_Vang.TabIndex = 19;
            this.lb_Vang.Text = "Vắng";
            this.lb_Vang.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_Vang
            // 
            this.tb_Vang.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Vang.Location = new System.Drawing.Point(225, 100);
            this.tb_Vang.Name = "tb_Vang";
            this.tb_Vang.Size = new System.Drawing.Size(75, 26);
            this.tb_Vang.TabIndex = 18;
            this.tb_Vang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ucThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pn_ThongKe);
            this.Controls.Add(this.pn_BaoCao);
            this.Name = "ucThongKeBaoCao";
            this.Size = new System.Drawing.Size(1100, 606);
            this.Load += new System.EventHandler(this.ucThongKeBaoCao_Load);
            this.pn_BaoCao.ResumeLayout(false);
            this.pn_BaoCao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pn_ThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_Salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpk_To;
        private System.Windows.Forms.DateTimePicker dtpk_From;
        private System.Windows.Forms.Label lb_BaoCaoThongKe;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Panel pn_BaoCao;
        private System.Windows.Forms.Panel pn_ThongKe;
        private System.Windows.Forms.Label lb_Tong;
        private System.Windows.Forms.TextBox tb_TongCaDay;
        private System.Windows.Forms.TextBox tb_TongGioDay;
        private System.Windows.Forms.Label lb_TongSoGioDay;
        private System.Windows.Forms.TextBox tb_TongThuNhap;
        private System.Windows.Forms.Label lb_TongThuNhap;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_Salary;
        private System.Windows.Forms.Button btn_HienThiThongTin;
        private System.Windows.Forms.Label lb_DaDay;
        private System.Windows.Forms.TextBox tb_DaDay;
        private System.Windows.Forms.Label lb_ChuaDay;
        private System.Windows.Forms.TextBox tb_ChuaDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XuatDuLieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Vang;
        private System.Windows.Forms.TextBox tb_Vang;
    }
}
