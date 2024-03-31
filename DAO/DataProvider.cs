using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get => instance == null ? new DataProvider() : instance; 
            private set => instance = value; 
        } 
        private DataProvider() { }

        string conStr = "Data Source = LAPTOP-LQ73NH42\\SQLEXPRESS01;Initial Catalog = QUANLYLICHDAY; Integrated Security = True";


        public DataTable ExcuteQuery(string query, object[] para = null)
        {

            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                sqlCon.Open();

                SqlCommand command = new SqlCommand(query, sqlCon);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) 
                    { 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                sqlCon.Close();

            }

            return dt;
        }
        public int ExcuteNonQuery(string query, object[] para = null)
        {

            int data = 0;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                sqlCon.Open();

                SqlCommand command = new SqlCommand(query, sqlCon);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                sqlCon.Close();

            }
            return data;
        }
        public object ExcuteScalar(string query, object[] para = null)
        {
            object data = 0;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                sqlCon.Open();

                SqlCommand command = new SqlCommand(query, sqlCon);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                sqlCon.Close();

            }
            return data;
        }
    }
}
