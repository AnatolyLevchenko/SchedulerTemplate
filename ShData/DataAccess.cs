using System;
using System.Collections;
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

        public static AuthorizedModel Authorize(string login, string password)
        {
            using (IDbConnection con=new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var model = con.Query<LoginModel>("select Id,Login,Password,Email from Users where Login=@Login", 
                    new { login = new DbString { Value = login } }).FirstOrDefault();
               

                con.Close();

                

                bool authorized= model != null && CalculateMD5Hash(password).Equals(model.Password);
                if(authorized)
                    return new AuthorizedModel(model.Login,model.IsAdmin==1,model.Email);
                return null;
            }
        }

        public static bool Register(LoginModel model)
        {
            if (!model.IsValid)
                throw new Exception("Model is not valid");

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var user = con.Query<LoginModel>("select Login from Users where Login=@Login",
                    new { login = new DbString { Value = model.Login } }).FirstOrDefault();
                if (user != null)
                    throw new Exception("User already exists");
                
              return 1 == con.Execute(@"insert or ignore into Users (Login,Password,IsAdmin,Email) VALUES (@Login,@Password,@IsAdmin,@Email)",
                     new { model.Login, Password = CalculateMD5Hash(model.Password), model.IsAdmin,model.Email }, commandType: CommandType.Text);
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

        public static SmtpModel ReadSmtp()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var model = con.Query<SmtpModel>(
                    "select Smtp,Email,Password,Port,EnableSsl  FROM Smtp ORDER BY ID DESC LIMIT 1").FirstOrDefault();
                con.Close();

                return model;
            }
        }

        public static bool WriteSmtp(SmtpModel model)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                bool result = 1 == con.Execute(@"insert or ignore into Smtp (Smtp,Email,Password,Port,EnableSsl) VALUES (@Smtp,@Email,@Password,@Port,@EnableSsl)",
                           new { model.Smtp, model.Email, model.Password, model.Port, model.EnableSsl }, commandType: CommandType.Text);
                con.Close();
                return result;
            }
        }


        public static List<LoginModel> ReadAllUsers()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var users = con.Query<LoginModel>("select Login,IsAdmin,Email from Users");
                con.Close();
                return users.ToList();
            }
        }

        public static bool ChangeAdmin(string login,bool admin)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var user = con.Query<LoginModel>("select Login,Id from Users where Login=@login", 
                    new { login = new DbString { Value = login } }).FirstOrDefault();
                if(user==null)
                    throw new Exception("User not found");

                int adm = 0;
                if (admin)
                    adm = 1;

                bool result = 1 == con.Execute(@"update Users SET IsAdmin=@admin where Id=@id",
                                  new { admin=adm, user.Id}, commandType: CommandType.Text);
                con.Close();

                return result;
            }
        }

        public static bool ChangeEmail(string login, string value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                var user = con.Query<LoginModel>("select Login,Id from Users where Login=@login",
                    new { login = new DbString { Value = login } }).FirstOrDefault();
                if (user == null)
                    throw new Exception("User not found");


                bool result = 1 == con.Execute(@"update Users SET Email=@Email where Id=@id",
                                  new { Email = value, user.Id }, commandType: CommandType.Text);
                con.Close();

                return result;
            }
        }
    }
}
