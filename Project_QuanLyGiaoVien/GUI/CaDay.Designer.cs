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
            this.lb_Status = new System.Windows.Forms.Label();
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
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(22, 57);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(73, 17);
            this.lb_Status.TabIndex = 1;
            this.lb_Status.Text = "[Trạng thái]";
            // 
            // CaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_ClassName);
            this.Margin = new System.Windows.Forms.Padding(6, 0, 0, 10);
            this.Name = "CaDay";
            this.Size = new System.Drawing.Size(128, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ClassName;
        private System.Windows.Forms.Label lb_Status;
    }
}
