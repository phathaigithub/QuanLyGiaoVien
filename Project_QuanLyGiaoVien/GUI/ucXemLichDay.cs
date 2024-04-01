using QuanLyLichDay.DAO;
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

namespace QuanLyLichDay.GUI
{
    public partial class ucXemLichDay : UserControl
    {
        DateTime currentWeek = DateTime.Now;
        Account account;

        public Account Account { get => account; set => account = value; }
        public DateTime CurrentWeek { get => currentWeek; set => currentWeek = value; }

        public ucXemLichDay()
        {
            InitializeComponent();
            
        }
        public void loadWeek(DateTime day)
        { 
            lb_Week.Text = DateDAO.Instance.firstDayOfWeek(day).ToString("dd/MM/yyyy")+ " - " + DateDAO.Instance.lastDayOfWeek(day).ToString("dd/MM/yyyy");
            DateTime monday = DateDAO.Instance.firstDayOfWeek(day);
            lb_ThuHai.Text = "Thứ hai\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ThuBa.Text = "Thứ ba\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ThuTu.Text = "Thứ tư\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ThuNam.Text = "Thứ năm\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ThuSau.Text = "Thứ sáu\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ThuBay.Text = "Thứ bảy\n" + "(" + monday.ToString("dd/MM") + ")";
            monday = monday.AddDays(1);
            lb_ChuNhat.Text = "Chủ nhật\n" + "(" + monday.ToString("dd/MM") + ")";
            List<Class> list = ClassDAO.Instance.getClassesByWeekAndUsername(account.Username, currentWeek);
            DateTime firstDay = DateDAO.Instance.firstDayOfWeek(day);
            clearFlpBody();
            for(int i=1; i <= 7; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    bool isAdd = false;
                    foreach (Class c in list)
                    {
                        if (firstDay.ToString("dd/MM").Equals(c.Day.ToString("dd/MM")) && c.Shift == j)
                        {
                            flp_Body.Controls.Add(new CaDay(c));
                            isAdd = true;
                            break;
                        }
                    }
                    if (isAdd)
                        continue;
                    flp_Body.Controls.Add(new CaDay(j));
                }
                firstDay = firstDay.AddDays(1);
            }
            

        }

        private void btn_PrevWeek_Click(object sender, EventArgs e)
        {
            CurrentWeek = CurrentWeek.AddDays(-7);
            loadWeek(CurrentWeek);
        }

        private void btn_NextWeek_Click(object sender, EventArgs e)
        {
            CurrentWeek = CurrentWeek.AddDays(7);
            loadWeek(CurrentWeek);
        }
        private void clearFlpBody()
        {
            flp_Body.Controls.Clear();
        }
    }
}
