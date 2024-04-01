using Project_DBManager.DAO;
using QuanLyLichDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDay.DAO
{
    public class ClassDAO
    {
        private static ClassDAO instance;

        public static ClassDAO Instance { get => instance == null ? new ClassDAO() : instance; set => instance = value; }
        public List<Class> getClassesByWeekAndUsername(string username, DateTime day)
        {
            string monday = DateDAO.Instance.firstDayOfWeek(day).ToString("yyyy-MM-dd");
            string sunday= DateDAO.Instance.lastDayOfWeek(day).ToString("yyyy-MM-dd");
            string query = "SELECT Class_Name, Shift_ID, FORMAT(DayOfClass, 'yyyy-MM-dd') as Day, Status " +
                "FROM Users U, (SELECT * from Class Where DayOfClass >= @Monday AND DayOfClass <= @Sunday ) as Class " +
                "WHERE U.User_ID = Class.User_ID and U.Username = @Username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { monday, sunday, username});
            List<Class> classes = new List<Class>();
            foreach(DataRow row in result.Rows)
            {
                classes.Add(new Class(row));
            }
            return classes;
        }
    }
}
