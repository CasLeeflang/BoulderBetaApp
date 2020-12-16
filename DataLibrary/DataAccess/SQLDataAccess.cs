using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataLibrary.Models;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        //Loading in Connection String
        public static string GetConnectionString()
        {
            //Does not return connectionstring
            return "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BoulderBeta_db; Integrated Security = True; Connect Timeout = 60; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                //sql query is loaded into list with type T
                return cnn.Query<T>(sql).ToList();
            }
            
        }

        public static T LoadDataNotList<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                
                return (T)cnn.Query<T>(sql);
            }

        }
        //Save one model using sql statement
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int DeleteData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql);
            }
        }

        public static List<T> LoadSearchData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }

        }

    }
}
