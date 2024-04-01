using QuanLyLichDay.DAO;
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
        DateTime currentWeek;
        public ucXemLichDay()
        {
            InitializeComponent();
            currentWeek = DateTime.Now;
            loadWeek(currentWeek);
            
        }
        public void loadWeek(DateTime day)
        { 
            lb_Week.Text = DateDAO.Instance.mondayOfWeek(day).ToString("dd/MM/yyyy")+ " - " + DateDAO.Instance.sundayOfWeek(day).ToString("dd/MM/yyyy");
        }

        private void btn_PrevWeek_Click(object sender, EventArgs e)
        {
            currentWeek = currentWeek.AddDays(-7);
            loadWeek(currentWeek);
        }

        private void btn_NextWeek_Click(object sender, EventArgs e)
        {
            currentWeek = currentWeek.AddDays(7);
            loadWeek(currentWeek);
        }
    }
}
