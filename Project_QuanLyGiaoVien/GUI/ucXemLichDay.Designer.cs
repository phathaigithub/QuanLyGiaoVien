namespace QuanLyLichDay.GUI
{
    partial class ucXemLichDay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pn_DateDisplay = new System.Windows.Forms.Panel();
            this.lb_Week = new System.Windows.Forms.Label();
            this.btn_PrevWeek = new System.Windows.Forms.Button();
            this.btn_NextWeek = new System.Windows.Forms.Button();
            this.flp_Shift = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Ca1 = new System.Windows.Forms.Label();
            this.lb_Ca2 = new System.Windows.Forms.Label();
            this.lb_Ca3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flp_Body = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_DateDisplay.SuspendLayout();
            this.flp_Shift.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_DateDisplay
            // 
            this.pn_DateDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_DateDisplay.Controls.Add(this.btn_NextWeek);
            this.pn_DateDisplay.Controls.Add(this.btn_PrevWeek);
            this.pn_DateDisplay.Controls.Add(this.lb_Week);
            this.pn_DateDisplay.Location = new System.Drawing.Point(0, 0);
            this.pn_DateDisplay.Name = "pn_DateDisplay";
            this.pn_DateDisplay.Size = new System.Drawing.Size(1100, 58);
            this.pn_DateDisplay.TabIndex = 0;
            // 
            // lb_Week
            // 
            this.lb_Week.AutoSize = true;
            this.lb_Week.BackColor = System.Drawing.Color.White;
            this.lb_Week.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Week.Location = new System.Drawing.Point(48, 15);
            this.lb_Week.Name = "lb_Week";
            this.lb_Week.Size = new System.Drawing.Size(237, 26);
            this.lb_Week.TabIndex = 0;
            this.lb_Week.Text = "01/04/2024 - 07/04-2024";
            // 
            // btn_PrevWeek
            // 
            this.btn_PrevWeek.BackColor = System.Drawing.Color.White;
            this.btn_PrevWeek.FlatAppearance.BorderSize = 0;
            this.btn_PrevWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrevWeek.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrevWeek.Location = new System.Drawing.Point(18, 15);
            this.btn_PrevWeek.Name = "btn_PrevWeek";
            this.btn_PrevWeek.Size = new System.Drawing.Size(30, 26);
            this.btn_PrevWeek.TabIndex = 1;
            this.btn_PrevWeek.Text = "<";
            this.btn_PrevWeek.UseVisualStyleBackColor = false;
            this.btn_PrevWeek.Click += new System.EventHandler(this.btn_PrevWeek_Click);
            // 
            // btn_NextWeek
            // 
            this.btn_NextWeek.BackColor = System.Drawing.Color.White;
            this.btn_NextWeek.FlatAppearance.BorderSize = 0;
            this.btn_NextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextWeek.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextWeek.Location = new System.Drawing.Point(285, 15);
            this.btn_NextWeek.Name = "btn_NextWeek";
            this.btn_NextWeek.Size = new System.Drawing.Size(30, 26);
            this.btn_NextWeek.TabIndex = 2;
            this.btn_NextWeek.Text = ">";
            this.btn_NextWeek.UseVisualStyleBackColor = false;
            this.btn_NextWeek.Click += new System.EventHandler(this.btn_NextWeek_Click);
            // 
            // flp_Shift
            // 
            this.flp_Shift.Controls.Add(this.lb_Ca1);
            this.flp_Shift.Controls.Add(this.lb_Ca2);
            this.flp_Shift.Controls.Add(this.lb_Ca3);
            this.flp_Shift.Controls.Add(this.label4);
            this.flp_Shift.Controls.Add(this.label5);
            this.flp_Shift.Location = new System.Drawing.Point(3, 101);
            this.flp_Shift.Name = "flp_Shift";
            this.flp_Shift.Size = new System.Drawing.Size(146, 502);
            this.flp_Shift.TabIndex = 2;
            // 
            // lb_Ca1
            // 
            this.lb_Ca1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.lb_Ca1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ca1.ForeColor = System.Drawing.Color.Black;
            this.lb_Ca1.Location = new System.Drawing.Point(0, 0);
            this.lb_Ca1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lb_Ca1.Name = "lb_Ca1";
            this.lb_Ca1.Size = new System.Drawing.Size(143, 90);
            this.lb_Ca1.TabIndex = 2;
            this.lb_Ca1.Text = "Ca 1\r\n(6h50 - 9h20)";
            this.lb_Ca1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ca2
            // 
            this.lb_Ca2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.lb_Ca2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ca2.Location = new System.Drawing.Point(0, 100);
            this.lb_Ca2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lb_Ca2.Name = "lb_Ca2";
            this.lb_Ca2.Size = new System.Drawing.Size(143, 90);
            this.lb_Ca2.TabIndex = 3;
            this.lb_Ca2.Text = "Ca 2\r\n(9h30-12h00)";
            this.lb_Ca2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ca3
            // 
            this.lb_Ca3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.lb_Ca3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ca3.Location = new System.Drawing.Point(0, 200);
            this.lb_Ca3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lb_Ca3.Name = "lb_Ca3";
            this.lb_Ca3.Size = new System.Drawing.Size(143, 90);
            this.lb_Ca3.TabIndex = 4;
            this.lb_Ca3.Text = "Ca 3\r\n(12h45 - 3h15)";
            this.lb_Ca3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 90);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ca 4\r\n(15h25 - 17h55)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 90);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ca 5\r\n(18h05 - 20h35";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_Body
            // 
            this.flp_Body.Location = new System.Drawing.Point(149, 101);
            this.flp_Body.Name = "flp_Body";
            this.flp_Body.Size = new System.Drawing.Size(951, 502);
            this.flp_Body.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel1.Location = new System.Drawing.Point(149, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 40);
            this.panel1.TabIndex = 4;
            // 
            // ucXemLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_Body);
            this.Controls.Add(this.flp_Shift);
            this.Controls.Add(this.pn_DateDisplay);
            this.Name = "ucXemLichDay";
            this.Size = new System.Drawing.Size(1100, 606);
            this.pn_DateDisplay.ResumeLayout(false);
            this.pn_DateDisplay.PerformLayout();
            this.flp_Shift.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pn_DateDisplay;
        private System.Windows.Forms.Label lb_Week;
        private System.Windows.Forms.Button btn_NextWeek;
        private System.Windows.Forms.Button btn_PrevWeek;
        private System.Windows.Forms.FlowLayoutPanel flp_Shift;
        private System.Windows.Forms.Label lb_Ca1;
        private System.Windows.Forms.Label lb_Ca2;
        private System.Windows.Forms.Label lb_Ca3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flp_Body;
        private System.Windows.Forms.Panel panel1;
    }
}
