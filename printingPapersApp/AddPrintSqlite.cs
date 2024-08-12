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
    class AddPrintSqlite
    {

        public static List<newPrint> LoadFiles()
        {
            using (IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {
                var result = con.Query<newPrint>("SELECT * FROM PrintingJobs", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void deletePrintJob(string path)
        {
            using (IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {
                con.Open();
                using (var cmd =  con.CreateCommand())
                {
                    cmd.CommandText = "delete from PrintingJobs where FileName=@path";
                    cmd.Parameters.Add(new SQLiteParameter("@path",path));
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public static void insertPrint(newPrint newPrint)
        {
            using (IDbConnection con = new SQLiteConnection(loadConnectionString()))
            {

                con.Execute("insert into PrintingJobs(FileName, NumberOfCopies) values(@fileName, @numberOfCopies)", newPrint);

            }
        }

        private static string loadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
