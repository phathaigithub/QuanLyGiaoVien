using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DTO
{
    public class Account
    {
        private string username;
        private string email;
        public Account(DataRow row)
        {
            username = row["Username"].ToString();
            email = row["User_Email"].ToString();
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
    }
}
