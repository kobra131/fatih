using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class DBHelper
    {
        
        public struct TableNames
        {
            public static readonly string Kitaplar = "Kitaplar";
            public static readonly string Fakulteler = "Fakulteler";
            public static readonly string FakulteBolumleri = "FakulteBolumleri";
            public static readonly string Ogrenciler = "Ogrenciler";
            public static readonly string OgrenciListesiView = "OgrenciListesiView";
            public static readonly string KitapOduncVerme = "KitapOduncVermeler";
            public static readonly string KitapOduncVermeView = "KitapOduncVermeView";
        }

        
        private static void ExecuteAction(Action<SqlConnection> action)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConString"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    action(connection);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }

            }
        }

    
        public static int ExecuteCommand(string sql, params SqlParameter[] parameters)
        {
            int result = -1;

            DBHelper.ExecuteAction(connection =>
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    if (parameters.Any())
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    result = command.ExecuteNonQuery();
                }
            });
            return result;
        }

       
        public static DataTable SqlQueryDataTable(string sql, params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            DBHelper.ExecuteAction(connection =>
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    if (parameters.Any())
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            });
            return table;
        }


        public static T SqlQuery<T>(string sql, params SqlParameter[] parameters)
        {
            return DBHelper.SqlQueryList<T>(sql, parameters).FirstOrDefault();
        }


        public static List<TResult> SqlQueryList<TResult>(string sql, params SqlParameter[] parameters)
        {
            List<TResult> list = new List<TResult>();
            using (var table = DBHelper.SqlQueryDataTable(sql, parameters))
            {
                var columns = table.Columns.Cast<DataColumn>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var row = table.Rows[i];
                    var newEntity = (TResult)Activator.CreateInstance(typeof(TResult));
                    foreach (var prop in newEntity.GetType().GetProperties())
                    {
                        if (columns.Any(a => a.ColumnName == prop.Name))
                        {
                            prop.SetValue(newEntity, row[prop.Name], null);
                        }
                    }
                    list.Add(newEntity);
                }
            }
            return list;
        }

      
        public static string GetInsertQuery(string tableName, IEnumerable<string> fields)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("INSERT INTO {0} ", tableName);
            builder.Append("(");
            builder.Append(string.Join(",", fields));
            builder.Append(") VALUES (");

            int[] fieldNumericArray = new int[fields.Count()];
            for (int i = 0; i < fields.Count(); i++)
            {
                fieldNumericArray[i] = i;
            }
            builder.Append(string.Join(",", fieldNumericArray.Select(s => string.Format("@p{0}", s))));
            builder.Append(")");
            return builder.ToString();

        }
        public static string GetUpdateQuery(string tableName, IEnumerable<string> fields, string whereQurey)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("UPDATE {0} SET ", tableName);
            builder.Append(string.Join(",", fields.Select(s => string.Format("{0}=@p{1}", s, fields.ToList().IndexOf(s)))));
            builder.AppendFormat(" WHERE {0}", whereQurey);
            return builder.ToString();

        }
        public static SqlParameter[] GetSqlParameters(params object[] values)
        {
            SqlParameter[] parameters = new SqlParameter[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                parameters[i] = new SqlParameter(string.Format("@p{0}", i), values[i]);
            }
            return parameters;
        }

        public static DataTable DataTableGetir(string sql)
        {
            {
                DataTable table = new DataTable();
                DBHelper.ExecuteAction(connection =>
                {
                    using (var dap = new SqlDataAdapter(sql, connection))
  {
                                       dap.Fill(table);

                    }
                });
                return table;
            }

        }
         

        public static DataRow DataRowGetir(string sql)
        {

            DataTable dt = DataTableGetir(sql);

            if (dt.Rows.Count == 0)
                return null;
            else
                return dt.Rows[0];
        }
    }
}
