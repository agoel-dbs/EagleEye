using System;
using System.Collections.Generic;

namespace EagleEye.DBLayer
{
    class AdminTask
    {

        public string ActivityType { get; set; }
        public string ActivityDate { get; set; }
        public string FromDate { get; set; }

        public string CreatedBy { get; set; }
        public string AutoDBBackupTaken()
        {
            string strReturn;
            string ProcessName = "AutoDBBackupTaken";
            try
            {

                string sql = "select count(1) from backup_his where act_status = 'P' " +
                                  "and act_type = @ActivityType and DATE(created_on) >= DATE(@ActivityDate)";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "ActivityType", ActivityType },{ "ActivityDate", ActivityDate }};
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(sql, Params);
                return strReturn;

           }
            catch (Exception e)
            {
                return "Issue with the Process " + ProcessName + " Issue is : " +   e.Message;
            }
        }
        public void SetBackupEntry()
        {

            try
            {
                string sql = "insert into backup_his (act_type,created_by) values (@ActivityType,@CreatedBy) ";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "ActivityType", ActivityType },{ "CreatedBy", CreatedBy }};
                DbConnectionFactory dbObj = new DbConnectionFactory();
                dbObj.ExecuteNonQuery(sql, Params);

            }
            catch (Exception e)
            {
               throw e;
            }
        }
        public string AutoDBBackupToMailID()
        {
            string strReturn;
            string ProcessName = "AutoDBBackupToMailID";
            try
            {
                string sql = "select mail_id from user_mailer_list where mailer_name = 'Data Backup Centre' and mail_cat = 'ALL' ";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(sql, Params);
                return strReturn;

            }
            catch (Exception e)
            {
                return "Issue with the Process " + ProcessName + " Issue is : " + e.Message;
            }
        }
    }
}
