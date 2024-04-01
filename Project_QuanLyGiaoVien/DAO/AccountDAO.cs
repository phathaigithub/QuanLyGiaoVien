using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichDay.GUI;

namespace QuanLyLichDay.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get => instance == null ? new AccountDAO() : instance;
            set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string email, string password)
        {
            string query = "SELECT * FROM DangNhap WHERE email = '" + email +"' AND password ='"+ password+ "'";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }

        
        
    }
}
