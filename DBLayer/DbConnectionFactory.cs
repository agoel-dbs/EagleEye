using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Data.SQLite;

namespace EagleEye.DBLayer
{
    public class DbConnectionFactory
    {
        // We use these three SQLite objects:
        public static SQLiteCommand objSqlitecommand { get; set; }
        public static SqlCommand objSqlcommand { get; set; }
        public static SQLiteConnection objSqliteConn { get; set; }
        public static SqlConnection objSqlConn { get; set; }
        public static SQLiteTransaction objSqliteTrans { get; set; }
        public static SqlTransaction objSqlTrans { get; set; }





        static string DBType = "SL";
        string DBstring = ConfigurationManager.AppSettings.Get("SQL_SERVER_CONNECTION_STRING");
        public DbConnectionFactory()
        {
            if (ConfigurationManager.AppSettings.Get("APP_RUN_MODE").ToUpper() == "SINGLE")
            { DBType = "SL"; }
            else
            { DBType = "SQL"; }

        }
        private string SqliteConnectionString()
        {
            string strFilePath = "";
            if (ConfigurationManager.AppSettings.Get("CONFIG_DB_PATH").Trim() == "Y")
            {

                strFilePath = "Data Source=" + ConfigurationManager.AppSettings.Get("DB_PATH").Trim();
            }
            else
            {
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // or: Directory.GetCurrentDirectory() gives the same result
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                strFilePath = "Data Source=" + projectDirectory.Replace("\\", "/") + "/DataFile/EagleEyeDB.db";
            }
            return strFilePath;
        }
        public string ExecuteScalerQuery(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            if (DBType == "SQL")
            {
                strReturn = SqlServerExecuteScaler(sql, values);
            }
            else
            {
                strReturn = SqliteExecuteScaler(sql, values);
            }
            return strReturn;
        }
        private string SqlServerExecuteScaler(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            SqlConnection conn = new SqlConnection(DBstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                strReturn = cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return strReturn;
        }
        private string SqliteExecuteScaler(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            SQLiteConnection conn = new SQLiteConnection(SqliteConnectionString());
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                cmd.Prepare();
                strReturn = cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return strReturn;
        }
        public void ExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            if (DBType == "SQL")
            {
                SqlServerExecuteNonQuery(sql, values);
            }
            else
            {
                SqliteExecuteNonQuery(sql, values);
            }
        }
        private void SqlServerExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            SqlConnection conn = new SqlConnection(DBstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        
        public string SqlServerStoredProcExecuteNonQuery(string sProcedureName, Dictionary<string, string> values,string pOutputParameterName )
        {
            SqlConnection conn = new SqlConnection(DBstring);
            try
            {
                string strReturn;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sProcedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
               }
    
                if (pOutputParameterName != "")
                {
                    cmd.Parameters.Add("@" + pOutputParameterName, SqlDbType.VarChar, 5000);
                    cmd.Parameters["@" + pOutputParameterName].Direction = ParameterDirection.Output;
                }

                cmd.ExecuteNonQuery();

                if (pOutputParameterName != "")
                {
                    strReturn =  cmd.Parameters["@" + pOutputParameterName].Value.ToString();
                }
                else
                {
                    strReturn = "Process executed sucessfully !!!!";
                }

                return strReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }


        private void SqliteExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            SQLiteConnection conn = new SQLiteConnection(SqliteConnectionString());
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable AdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dtReturn = null;
            if (DBType == "SQL")
            {
                dtReturn = SqlServerAdapterQuery(sql, values);
            }
            else
            {
                dtReturn = SqliteAdapterQuery(sql, values);
            }
            return dtReturn;
        }
        private DataTable SqlServerAdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DBstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        private DataTable SqliteAdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = new SQLiteConnection(SqliteConnectionString());
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                cmd.Prepare();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Transaction----

        /// <summary>
        /// SQLite Transaction object
        /// </summary>
        /// 

        public void TransConnection()
        {

            if (DBType == "SQL")
            {
                SqlTransConnection();
            }
            else
            {
                SqliteTransConnection();
            }

        }
        public void TransCommand()
        {
            if (DBType == "SQL")
            {
                SqlTransCommand();
            }
            else
            {
                SqliteTransCommand();
            }
        }
        public void TransExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            if (DBType == "SQL")
            {
                SqlTransExecuteNonQuery(sql, values);
            }
            else
            {
                SqliteTransExecuteNonQuery(sql, values);
            }
        }
        public string TransExecuteScalerQuery(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            if (DBType == "SQL")
            {
                strReturn = SqlTransExecuteScalar(sql, values);
            }
            else
            {
                strReturn = SqliteTransExecuteScalar(sql, values);
            }
            return strReturn;
        }

        public DataTable TransAdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dtReturn = null;
            if (DBType == "SQL")
            {
                dtReturn = SqlTransAdapterQuery(sql, values);
            }
            else
            {
                dtReturn = SqliteTransAdapterQuery(sql, values);
            }
            return dtReturn;
        }


        public void TransCloseConnection()
        {
            if (DBType == "SQL")
            {
                SqlTransClose();


            }
            else
            {
                SqliteTransClose();
            }
        }
        public void TransBegin()
        {
            if (DBType == "SQL")
            {
                SqlTranstion();
            }
            else
            {
                SqliteTranstion();
            }
        }
        public void TransAttachCommand()
        {
            if (DBType == "SQL")
            {
                SqlTranstionAttachCommand();
            }
            else
            {
                SqliteTranstionAttachCommand();
            }
        }
        public void TransRollback()
        {
            if (DBType == "SQL")
            {
                SqlRollback();
            }
            else
            {
                SqliteRollback();
            }
        }
        public void TransCommit()
        {
            if (DBType == "SQL")
            {
                SqlCommit();
            }
            else
            {
                SqliteCommit();
            }
        }

        public static bool TransConnectionState()
        {
            if (DBType == "SQL")
            {
                if (objSqlConn.State != ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            else
            {
                if (objSqliteConn.State != ConnectionState.Open)
                    return true;
                else
                    return false;
            }
        }

        public static bool TransConnectionNullCheck()
        {
            if (DBType == "SQL")
            {
                if (objSqlConn != null)
                    return true;
                else
                    return false;
            }
            else
            {
                if (objSqliteConn != null)
                    return true;
                else
                    return false;
            }
        }

        private void SqliteTransConnection()
        {
            objSqliteConn = new SQLiteConnection(SqliteConnectionString());
            try
            {
                objSqliteConn.Open();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SqliteTransCommand()
        {
            try
            {
                objSqlitecommand = new SQLiteCommand(objSqliteConn);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SqliteTransExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            try
            {
                objSqlitecommand.CommandText = sql;
                objSqlitecommand.Parameters.Clear();
                foreach (KeyValuePair<string, string> value in values)
                {
                    objSqlitecommand.Parameters.AddWithValue("@" + value.Key, value.Value);
                }

                objSqlitecommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string SqliteTransExecuteScalar(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            try
            {
                objSqlitecommand.CommandText = sql;
                objSqlitecommand.Parameters.Clear();

                foreach (KeyValuePair<string, string> value in values)
                {
                    objSqlitecommand.Parameters.AddWithValue("@" + value.Key, value.Value);
                }

                strReturn = objSqlitecommand.ExecuteScalar().ToString();
                return strReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SqliteTransClose()
        {
            objSqliteConn.Close();
            objSqliteConn = null;
            objSqlitecommand = null;
            objSqliteTrans = null;
        }
        private void SqliteTranstion()
        {
            objSqliteTrans = objSqliteConn.BeginTransaction();
        }
        private void SqliteTranstionAttachCommand()
        {
            objSqlitecommand.Transaction = objSqliteTrans;
        }
        private void SqliteRollback()
        {
            objSqliteTrans.Rollback();
        }
        private void SqliteCommit()
        {
            objSqliteTrans.Commit();
        }

        private DataTable SqliteTransAdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dt = new DataTable();
            try
            {
                objSqlitecommand.CommandText = sql;
                objSqlitecommand.Parameters.Clear();
                SQLiteCommand cmd = new SQLiteCommand(sql, objSqliteConn);
                foreach (KeyValuePair<string, string> value in values)
                {
                    cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                cmd.Prepare();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        // Sql Server

        private void SqlTransConnection()
        {
            objSqlConn = new SqlConnection(DBstring);
            try
            {
                objSqlConn.Open();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SqlTransCommand()
        {
            try
            {
                objSqlcommand = new SqlCommand();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SqlTransExecuteNonQuery(string sql, Dictionary<string, string> values)
        {
            try
            {
                objSqlcommand.Connection = objSqlConn;
                objSqlcommand.CommandText = sql;
                objSqlcommand.Parameters.Clear();

                foreach (KeyValuePair<string, string> value in values)
                {
                    objSqlcommand.Parameters.AddWithValue("@" + value.Key, value.Value);
                }

                objSqlcommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string SqlTransExecuteScalar(string sql, Dictionary<string, string> values)
        {
            string strReturn = "";
            try
            {
                objSqlcommand.Connection = objSqlConn;
                objSqlcommand.CommandText = sql;
                objSqlcommand.Parameters.Clear();
                foreach (KeyValuePair<string, string> value in values)
                {
                    objSqlcommand.Parameters.AddWithValue("@" + value.Key, value.Value);
                }

                strReturn = objSqlcommand.ExecuteScalar().ToString();
                return strReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private DataTable SqlTransAdapterQuery(string sql, Dictionary<string, string> values)
        {
            DataTable dt = new DataTable();
            try
            {
                objSqlcommand.CommandText = sql;
                SqlCommand cmd = new SqlCommand(sql, objSqlConn);
                objSqlcommand.Parameters.Clear();
                foreach (KeyValuePair<string, string> value in values)
                {
                    objSqlcommand.Parameters.AddWithValue("@" + value.Key, value.Value);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        private void SqlTransClose()
        {
            objSqlConn.Close();
            objSqlConn = null;
            objSqlcommand = null;
            objSqlTrans = null;
        }
        private void SqlTranstion()
        {
            objSqlTrans = objSqlConn.BeginTransaction();
        }
        private void SqlTranstionAttachCommand()
        {
            objSqlcommand.Transaction = objSqlTrans;
        }
        private void SqlRollback()
        {
            objSqlTrans.Rollback();
        }
        private void SqlCommit()
        {
            objSqlTrans.Commit();
        }


    }
}
