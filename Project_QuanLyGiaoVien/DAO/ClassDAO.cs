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
            string monday = DateDAO.Instance.mondayOfWeek(day).ToString("dd-MM-yyyy") ;
            string sunday= DateDAO.Instance.sundayOfWeek(day).ToString("dd-MM-yyyy");
            string query = "SELECT Course_Name, Shift_ID, FORMAT(DayOfClass, 'dd-MM-yyyy') as Day " +
                            "FROM Course C, Users U, (SELECT * from Class Where DayOfClass > @monday AND DayOfClass < @sunday) as Class" +
                            "WHERE C.User_ID = U.User_ID AND C.Course_ID = Class.Course_ID and U.Username = @Username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, monday, sunday }) ;
            List<Class> classes = new List<Class>();
            foreach(DataRow row in result.Rows)
            {
                classes.Add(new Class(row));
            }
            return classes;
        }
    }
}
