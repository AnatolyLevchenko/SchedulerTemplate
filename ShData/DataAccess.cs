using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ShData
{
    public class DataAccess
    {
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
    }
}
