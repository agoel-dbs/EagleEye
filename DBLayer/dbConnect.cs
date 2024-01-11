using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace EagleEye.DBLayer
{
    class dbConnect
    {
        // We use these three SQLite objects:
        public SQLiteConnection ConnectToDB()
        {
            string strFilePath  = "";
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
                //"Data Source=C:/Users/Rajesh Jangid/Desktop/EagleEye/DataFile/EagleEyeDB.db"
            }
            return new SQLiteConnection(strFilePath);
        }
        public SQLiteCommand CreateCommand(SQLiteConnection pConn, string pStrQuery)
        {
            return new SQLiteCommand(pStrQuery, pConn);

        }

        public SQLiteCommand CreateCommand(SQLiteConnection pConn)
        {
            return new SQLiteCommand(pConn);

        }
        public string ExecuteScalar(SQLiteCommand pCmd)
        {
            return pCmd.ExecuteScalar().ToString();

        }
        public void ExecuteNonQuery(SQLiteCommand pCmd)
        {
            pCmd.ExecuteNonQuery();

        }
        public DataTable GetDataTable(SQLiteCommand pCmd)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(pCmd);
            DataTable Dt = new DataTable();
             dataAdapter.Fill(Dt);
            return Dt;

        }
       
        public void CloseConnection(SQLiteConnection pConn)
        {
            pConn.Close();
        }

        public void OpenConnection(SQLiteConnection pConn)
        {
            pConn.Open();

        }
    }
}
