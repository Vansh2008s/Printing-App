using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;

namespace printingPapersApp
{
    class SqliteDatAccess
    {
        public static List<Files> LoadFiles()
        {
            using (IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {
                var result = con.Query<Files>("SELECT * FROM Files", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void insertFile(Files f)
        {
            using(IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {
                
                con.Execute("insert into Files(id,FileName,FileCount) values(@id,@FileName,@FileCount)", f);
                
            }
        }

        public static void deleteAll()
        {
            using (IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {
                con.Execute("delete from Files");
                
            }
        }
        private static string loadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
