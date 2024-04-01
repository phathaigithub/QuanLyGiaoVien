namespace QuanLyLichDay
{
    partial class CaDay
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
            this.lb_ClassName = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_ClassName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_ClassName
            // 
            this.lb_ClassName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ClassName.Location = new System.Drawing.Point(5, 5);
            this.lb_ClassName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_ClassName.Name = "lb_ClassName";
            this.lb_ClassName.Size = new System.Drawing.Size(120, 52);
            this.lb_ClassName.TabIndex = 0;
            this.lb_ClassName.Text = "[Tên lớp]";
            this.lb_ClassName.Click += new System.EventHandler(this.lb_ClassName_Click);
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Chưa dạy",
            "Đã dạy",
            "Vắng"});
            this.cb_Status.Location = new System.Drawing.Point(48, 66);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(76, 21);
            this.cb_Status.TabIndex = 2;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            this.cb_Status.SelectionChangeCommitted += new System.EventHandler(this.cb_Status_SelectionChangeCommitted);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(9, 65);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(33, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(4, 65);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(41, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_ClassName
            // 
            this.tb_ClassName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ClassName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ClassName.Location = new System.Drawing.Point(4, 5);
            this.tb_ClassName.Name = "tb_ClassName";
            this.tb_ClassName.Size = new System.Drawing.Size(120, 27);
            this.tb_ClassName.TabIndex = 5;
            this.tb_ClassName.Visible = false;
            this.tb_ClassName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ClassName_KeyDown);
            // 
            // CaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tb_ClassName);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.lb_ClassName);
            this.Margin = new System.Windows.Forms.Padding(6, 0, 0, 10);
            this.Name = "CaDay";
            this.Size = new System.Drawing.Size(128, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ClassName;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_ClassName;
    }
}
