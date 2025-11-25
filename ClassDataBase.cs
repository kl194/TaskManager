using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManager
{
    public class ClassDataBase
    {
        #region ExecuteNonQuery
        public int ExecuteNonQuery(string setupProgram, string sSql)
        {
            int n = 0;
            try
            {
                using (SqliteConnection con = new SqliteConnection(string.Format("Data Source={0};", setupProgram)))
                {

                    con.Open();
                    using (SqliteCommand sqlCommand = con.CreateCommand())
                    {
                        sqlCommand.CommandText = sSql;
                        n = sqlCommand.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                n = 0;
            }
            return n;
        }
        #endregion
        #region Execute
        protected T GetObject<T>(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
        public void Execute<T>(string setupProgram, string sSql, ref List<T> listResult)
        {
            string result = "";
            try
            {
                string databaseName = setupProgram;
                SqliteConnection con = new SqliteConnection(string.Format("Data Source={0};", databaseName));
                con.Open();
                SqliteCommand command = new SqliteCommand(sSql, con);
                SqliteDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        result = "";
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            try
                            {
                                result += dataReader.GetString(i) + "|";
                            }
                            catch { result += " |"; }
                        }
                        if (result.Count() > 2) result = result.Remove(result.Count() - 1);
                        if (result != "") listResult.Add(GetObject<T>(result));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion
    }
}
