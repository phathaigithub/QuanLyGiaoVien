using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DAO
{
    public class DateDAO
    {
        private static DateDAO instance;

        public static DateDAO Instance 
        { get => instance == null ? new DateDAO() : instance; set => instance = value; }

        public String toHour(DateTime day)
        {
            return day.ToString("HH:MM:ss");
        }
        public DateTime mondayOfWeek(DateTime day)
        {
           
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)day.DayOfWeek + 7) % 7;
            return day.AddDays(-daysUntilMonday);
            
        }
        public DateTime sundayOfWeek(DateTime day)
        {
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)day.DayOfWeek + 7) % 7;
            return day.AddDays(daysUntilSunday);
        }
    }
}
