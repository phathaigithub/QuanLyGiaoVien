namespace QuanLyLichDay
{
    partial class OTPAuthorizeForm
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
            this.pn_NhapOTP = new System.Windows.Forms.Panel();
            this.tb_OTP = new System.Windows.Forms.TextBox();
            this.lb_NhapOTP = new System.Windows.Forms.Label();
            this.lb_YourOTP = new System.Windows.Forms.Label();
            this.btn_KiemTraOTP = new System.Windows.Forms.Button();
            this.btn_GuiLaiOTP = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.pn_NhapOTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_NhapOTP
            // 
            this.pn_NhapOTP.BackColor = System.Drawing.Color.White;
            this.pn_NhapOTP.Controls.Add(this.tb_OTP);
            this.pn_NhapOTP.Location = new System.Drawing.Point(272, 221);
            this.pn_NhapOTP.Name = "pn_NhapOTP";
            this.pn_NhapOTP.Size = new System.Drawing.Size(257, 40);
            this.pn_NhapOTP.TabIndex = 1;
            // 
            // tb_OTP
            // 
            this.tb_OTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_OTP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_OTP.Location = new System.Drawing.Point(9, 8);
            this.tb_OTP.Margin = new System.Windows.Forms.Padding(30);
            this.tb_OTP.Name = "tb_OTP";
            this.tb_OTP.Size = new System.Drawing.Size(237, 24);
            this.tb_OTP.TabIndex = 1;
            this.tb_OTP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_OTP_KeyDown);
            // 
            // lb_NhapOTP
            // 
            this.lb_NhapOTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NhapOTP.AutoSize = true;
            this.lb_NhapOTP.BackColor = System.Drawing.Color.White;
            this.lb_NhapOTP.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_NhapOTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_NhapOTP.Location = new System.Drawing.Point(277, 184);
            this.lb_NhapOTP.Name = "lb_NhapOTP";
            this.lb_NhapOTP.Size = new System.Drawing.Size(95, 24);
            this.lb_NhapOTP.TabIndex = 24;
            this.lb_NhapOTP.Text = "Nhập OTP";
            // 
            // lb_YourOTP
            // 
            this.lb_YourOTP.BackColor = System.Drawing.Color.White;
            this.lb_YourOTP.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YourOTP.ForeColor = System.Drawing.Color.Green;
            this.lb_YourOTP.Location = new System.Drawing.Point(116, 77);
            this.lb_YourOTP.Name = "lb_YourOTP";
            this.lb_YourOTP.Size = new System.Drawing.Size(555, 49);
            this.lb_YourOTP.TabIndex = 25;
            this.lb_YourOTP.Text = "Mã OTP đã được gửi qua Email!";
            this.lb_YourOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_KiemTraOTP
            // 
            this.btn_KiemTraOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.btn_KiemTraOTP.FlatAppearance.BorderSize = 0;
            this.btn_KiemTraOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTraOTP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTraOTP.ForeColor = System.Drawing.Color.White;
            this.btn_KiemTraOTP.Location = new System.Drawing.Point(393, 286);
            this.btn_KiemTraOTP.Name = "btn_KiemTraOTP";
            this.btn_KiemTraOTP.Size = new System.Drawing.Size(136, 34);
            this.btn_KiemTraOTP.TabIndex = 26;
            this.btn_KiemTraOTP.Text = "Kiểm tra OTP";
            this.btn_KiemTraOTP.UseVisualStyleBackColor = false;
            this.btn_KiemTraOTP.Click += new System.EventHandler(this.btn_KiemTraOTP_Click);
            // 
            // btn_GuiLaiOTP
            // 
            this.btn_GuiLaiOTP.BackColor = System.Drawing.Color.Silver;
            this.btn_GuiLaiOTP.FlatAppearance.BorderSize = 0;
            this.btn_GuiLaiOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuiLaiOTP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuiLaiOTP.ForeColor = System.Drawing.Color.Black;
            this.btn_GuiLaiOTP.Location = new System.Drawing.Point(281, 286);
            this.btn_GuiLaiOTP.Name = "btn_GuiLaiOTP";
            this.btn_GuiLaiOTP.Size = new System.Drawing.Size(100, 34);
            this.btn_GuiLaiOTP.TabIndex = 27;
            this.btn_GuiLaiOTP.Text = "Gửi lại OTP";
            this.btn_GuiLaiOTP.UseVisualStyleBackColor = false;
            this.btn_GuiLaiOTP.Click += new System.EventHandler(this.btn_GuiLaiOTP_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.BackColor = System.Drawing.Color.White;
            this.lb_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(246, 140);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(272, 22);
            this.lb_Email.TabIndex = 28;
            this.lb_Email.Text = "Email:";
            this.lb_Email.Click += new System.EventHandler(this.label1_Click);
            // 
            // OTPAuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(209)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.btn_GuiLaiOTP);
            this.Controls.Add(this.btn_KiemTraOTP);
            this.Controls.Add(this.lb_YourOTP);
            this.Controls.Add(this.pn_NhapOTP);
            this.Controls.Add(this.lb_NhapOTP);
            this.Name = "OTPAuthorizeForm";
            this.Text = "OTPAuthorize";
            this.Load += new System.EventHandler(this.OTPAuthorizeForm_Load);
            this.pn_NhapOTP.ResumeLayout(false);
            this.pn_NhapOTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_NhapOTP;
        private System.Windows.Forms.TextBox tb_OTP;
        private System.Windows.Forms.Label lb_NhapOTP;
        private System.Windows.Forms.Label lb_YourOTP;
        private System.Windows.Forms.Button btn_KiemTraOTP;
        private System.Windows.Forms.Button btn_GuiLaiOTP;
        private System.Windows.Forms.Label lb_Email;
    }
}