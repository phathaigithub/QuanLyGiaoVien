using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DAO
{
    public class DataEncoder
    {
        private static DataEncoder instance;

        public static DataEncoder Instance { get => instance == null ? new DataEncoder(): instance; set => instance = value; }

        public string stringHash(string input)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(input);

            return hashedPassword;
        }
        public bool isHashTo(string input, string hashed)
        {
            return BCrypt.Net.BCrypt.Verify(input, hashed);
        }
        public string encodeBase64(string input)
        {
            byte[] utf8_bytes = Encoding.UTF8.GetBytes(input);

            return Convert.ToBase64String(utf8_bytes);
        }
        public string decodeBase64(string encodeString)
        {
            byte[] decoded_bytes = Convert.FromBase64String(encodeString);

            return Encoding.UTF8.GetString(decoded_bytes);
        }
    }
}
