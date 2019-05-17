using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Dapper;
using ShData.Models;

namespace ShData
{
    public class DataAccess
    {
        private const string Salt = "SAlt@@";
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void CreateSchema(string sql)
        {
            using (IDbConnection con=new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                con.Execute(sql);


            }
        }

        public static bool Authorize(string login, string password)
        {
            using (IDbConnection con=new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var model = con.Query<LoginModel>("select Id,Login,Password from Users where Login=@Login", 
                    new { login = new DbString { Value = login } }).FirstOrDefault();



                return model != null && CalculateMD5Hash(password).Equals(model.Password);
            }
        }


        private static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Unicode.GetBytes(input+Salt);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }


    }
}
