using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class UserManagment
    {

        public string UserId { get; set; }

        public string UserName { get; set; }
        public string Password{ get; set; }

        public string EmailID { get; set; }

        public string ContactNo { get; set; }

        public string RoleID { get; set; }

        public int IsActive { get; set; }

        public string Remarks { get; set; }

        public string CreatedBy { get; set; }

        public string SellerName { get; set; }

        public bool AddFlag { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public  string AuthenticateUser()
        {
            try
            {
                string strReturn;
                string sql = "select count(1) from user_master where upper(usr_id)=upper(@UserID) and pwd = @PWD and is_active = 1";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "UserId", UserId },{ "PWD", Password }};
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(sql, Params);
                SetUserLastLogin();
                return strReturn;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


        private void SetUserLastLogin()
        {
            try
            {
                string sql = "update user_master set last_login_date = CURRENT_TIMESTAMP where upper(usr_id)=upper(@USER_ID) "; 
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "USER_ID", UserId }};
                DbConnectionFactory dbObj = new DbConnectionFactory();
                dbObj.ExecuteNonQuery(sql, Params);
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public string ManageUserDetails()
        {
                string strReturn;
                string strMsg;
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
                DbConnectionFactory objFactory = new DbConnectionFactory();
                string strSql;
                objFactory.TransConnection();
                objFactory.TransCommand();
                objFactory.TransBegin();
                objFactory.TransAttachCommand();
            try
            {

                if (AddFlag == true)
                {
                    strSql = "select count(1) from user_master where upper(usr_id)=upper(@UserID)";

                    Params.Add("UserID", UserId);

                    strReturn = objFactory.ExecuteScalerQuery(strSql, Params);

                    if (strReturn != "0")
                    {
                        strReturn = logicalError + "User ID already exists, please try different user ID !!! ";
                        objFactory.TransRollback();
                        return strReturn;
                    }

                    // make insert statment

                    strSql  = "insert into user_master(usr_id,usr_name,pwd,email_id,contact_no,role_id," +
                                       "is_active,remarks,created_by,updated_by) values( " +
                                        " upper(@usr_id),@usr_name,@pwd,@email_id,@contact_no,@role_id,@is_active," +
                                        " @remarks,@created_by,@updated_by)";

                    Params.Clear();
                    Params.Add("pwd", Password);
                    Params.Add("created_by", CreatedBy);
                    strMsg = logicalOK + "New user created sucessfully!!! ";
                }
                else
                {
                    // make update statment
                    strSql  = "update user_master set usr_name = @usr_name,email_id = @email_id," +
                                        "contact_no = @contact_no,role_id = @role_id," +
                                       "is_active =@is_active,remarks = @remarks,updated_by = @updated_by " +
                                         " , updated_on = CURRENT_TIMESTAMP  where usr_id = @usr_id";
                    strMsg = logicalOK + "User Information Updated Sucessfully!!! ";
                }
                Params.Add("usr_id", UserId);
                Params.Add("usr_name", UserName);
                Params.Add("email_id", EmailID);
                Params.Add("contact_no", ContactNo);
                Params.Add("role_id", RoleID);
                Params.Add("is_active", IsActive.ToString());
                Params.Add("remarks", Remarks);
                Params.Add("updated_by", CreatedBy);

                objFactory.TransExecuteNonQuery(strSql, Params);

                // add mailer list for new user
                if (AddFlag == true)
                {
                    EmailManagement objEmail = new EmailManagement();
                    objEmail.NewUserId = UserId;
                    objEmail.CreatedBy = CreatedBy;
                    objEmail.bTransactionBound = true;
                    strReturn = objEmail.SetNewUserDefaultMailerList();
                    int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback();
                        return strReturn;
                    }
                }
                strReturn = strMsg;
                objFactory.TransCommit();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                return TechnicalError + e.Message;
            }

        }


        public DataTable GetUserDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select * from vw_User_master where UserID=@UserID";
                Params.Add("UserID", UserId);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public string RestPassword()
        {
            try
            {
                string strMsg;
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                // if adding new user check if user Id Already Exists

                strSql = "update user_master set pwd= @Password" +
                                  " , updated_by = updated_by , updated_on = CURRENT_TIMESTAMP  " +
                                  " where usr_id = @usr_id";
                strMsg = logicalOK + "Password reset Sucessfully!!! ";
                
                Params.Add("usr_id", UserId);
                Params.Add("Password", Password);
                Params.Add("updated_by", CreatedBy);

                DbConnectionFactory dbObj = new DbConnectionFactory();
                dbObj.ExecuteNonQuery(strSql, Params);
                return strMsg;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public string RestMyPassword()
        {
            try
            {

                // call AuthenticateUser
                //if it return 1 is.e. user is autheticated  then 
                // call RestPassword


                // return strReturn;
                return "";
            }
            catch (Exception e)
            {
                return TechnicalError + e.Message;
            }

        }


    }
}
