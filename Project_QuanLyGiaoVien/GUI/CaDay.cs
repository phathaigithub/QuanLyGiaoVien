using QuanLyLichDay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDay
{
    public partial class CaDay : UserControl
    {
        string className;
        DateTime day;
        int shift;
        string status; // Status có 3 giá trị (Đã dạy, Chưa dạy, Vắng)

        public CaDay(Class lopHoc)
        {
            InitializeComponent();
            if (lopHoc == null)
            {
                lb_ClassName.Text = "[Trống]";
                lb_Status.Text = "Không có";
            }
            else
            {
                this.className = lopHoc.ClassName;
                this.shift = lopHoc.Shift;
                this.day = lopHoc.Day;
                this.status = lopHoc.Status;
                lb_ClassName.Text = className;
                lb_Status.Text = status;
                switch (status)
                {
                    case "Đã dạy": this.BackColor = Color.Green; break;
                    case "Chưa dạy": this.BackColor = Color.Silver; break;
                    case "Vắng": this.BackColor = Color.Red; break;
                }
            }
        }
        public CaDay(int j)
        {

            InitializeComponent();
            lb_ClassName.Text = "[Trống]";
            lb_Status.Text = "Không có";
            this.shift = j;
        }

        private void lb_ClassName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(day.ToString() + " " + shift);
        }
    }
}
