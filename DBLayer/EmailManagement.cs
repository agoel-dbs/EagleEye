using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class EmailManagement
    {
        // login id
        public string UserId { get; set; }

        // user id created by manage user intreface
        public string NewUserId { get; set; }


        public string MailID { get; set; }

        public string MailPWD { get; set; }
        public int SmtpRK { get; set; }


        public string CreatedBy { get; set; }
        public bool bTransactionBound = false;
        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public DataTable GetMailSetting()
        {
            try
            {
                DataTable Dt;
                string strSql;
                strSql = "select mail_id , mail_pwd , t1.smtp_rk , smtp_name," +
                          " smtp_address,ssl_port,auth_required " +
                        " from user_mail_map t1 ,smtp_master t2" +
                        " where t1.smtp_rk = t2.smtp_rk" +
                        " and t1.is_active = 1 and t2.is_active = 1" +
                        " and upper(t1.usr_id) = @UserId";
                Dictionary<string, string> Params = new Dictionary<string, string>();
                Params.Add("UserId", UserId);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        public string SetMailSetting()
        {
            try
            {
                DataTable Dt;
                string strReturn;
                string strSql;
                string strMsg;
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = " select count(1) from user_mail_map where upper(usr_id) = upper(@UserId) and is_active = 1";
                Params.Add("UserId", UserId);
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(strSql, Params);
                if (strReturn == "0")
                {
                    //add new
                    strSql = "insert into user_mail_map(usr_id,mail_id,mail_pwd,smtp_rk," +
                                       "created_by,updated_by) values( " +
                                        " @usr_id,@mail_id,@mail_pwd,@smtp_rk,@created_by,@updated_by)";
                    Params.Clear();
                    Params.Add("usr_id", UserId);
                    Params.Add("created_by", CreatedBy);
                    strMsg = logicalOK + "User Mail settings created sucessfully!!! ";
                }
                else
                {
                    //update

                    strSql = "update user_mail_map set mail_id= @mail_id ,mail_pwd = @mail_pwd ,smtp_rk = @smtp_rk " +
                                      ",updated_by= @updated_by , updated_on = CURRENT_TIMESTAMP where usr_id= @usr_id";
                    strMsg = logicalOK + "User Mail settings created sucessfully!!! ";
                }

                Params.Add("mail_id", MailID);
                Params.Add("mail_pwd", MailPWD);
                Params.Add("smtp_rk", SmtpRK.ToString());
                Params.Add("updated_by", CreatedBy);
                Params.Add("usr_id", UserId);
                dbObj.ExecuteNonQuery(strSql,Params);
                strReturn = strMsg;
                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + e.Message;

            }
        }

        // entry into user mailier list 

        public string SetNewUserDefaultMailerList()
        {
                string strReturn;
                string strSql;
                string ProcessName = "SetNewUserDefaultMailerList";
                DbConnectionFactory objFactory = new DbConnectionFactory();
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
    
            try
            {

                strSql = " insert into user_mailer_list" +
                        "(usr_id,mailer_name,mail_id,created_by,updated_by ,mail_cat) " +
                        " select @NewUserId,mailer_name,mail_id,@UserId,@UserId ,'USER' " +
                        " from user_mailer_list where is_active = 1 and mail_cat = 'ALL'";
                Params.Add ("UserId", CreatedBy);
                Params.Add("NewUserId", NewUserId);

                if (bTransactionBound == false)
                {
                    objFactory.ExecuteNonQuery(strSql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery(strSql, Params);
                }


                strReturn = logicalOK + "Default mail address added";
                return strReturn;
            
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " +  ProcessName + " : " + e.Message;

            }

        }




    }
}
