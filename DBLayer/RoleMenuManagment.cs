using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class RoleMenuManagment
    {
        public string UserId { get; set; }
        public int MenuLevel { get; set; }
        public string ParentID{ get; set; }
        public DataTable GetMenuDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = " select * from ROLE_MENU_MAP t1 ,ROLE_MASTER t2 , MENU_MASTER t3" +
                        " , USER_MASTER t4 where t1.role_id = t2.ROLE_ID and t1.MENU_ID = t3.MENU_ID " +
                        " and t4.ROLE_ID = t2.ROLE_ID and upper(t4.USR_ID) = upper(@UserId) AND IS_VISIBLE = 1" +
                        " and t3.menu_level =@MenuLevel";
                Params.Add("UserId", UserId);
                Params.Add("MenuLevel", MenuLevel.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        public DataTable GetSubMenuDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = " select * from ROLE_MENU_MAP t1 ,ROLE_MASTER t2 , MENU_MASTER t3" +
                        " , USER_MASTER t4 where t1.role_id = t2.ROLE_ID and t1.MENU_ID = t3.MENU_ID " +
                        " and t4.ROLE_ID = t2.ROLE_ID and upper(t4.USR_ID) = upper(@UserId) AND IS_VISIBLE = 1" +
                        " and t3.menu_level =@MenuLevel and parent_id = @ParentID";

                Params.Add("UserId", UserId);
                Params.Add("MenuLevel", MenuLevel.ToString());
                Params.Add("ParentID", ParentID);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


    }
}
