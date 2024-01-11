using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class RoleMenuMap
    {
        public string RoleID { get; set; }

        public int Visible { get; set; }

        public int Editable { get; set; }
        public string MenuId { get; set; }
        public string Name { get; set; }
        public int ParentMenu { get; set; }
        public string ParentMenuId { get; set; }
        public string CreatedBy { get; set; }
        public int Key { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public DataTable GetRoleDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select t2.IS_VISIBLE Visible ,t2.IS_EDITABLE Editable, t1.menu_id MenuID,t1.MENU_NAME Name ,case t1.IS_PARENT when 1 then 'Yes' else 'No'  END ParentMenu" +
                        ",t1.PARENT_ID ParentMenuID , " + Global.gIsNull + "(t2.role_menu_rk, -1) RoleMenuMapKey  " + 
                        " from MENU_MASTER t1 left OUTER join (select* from ROLE_MENU_MAP where ROLE_ID = @RoleId)"+
                        " t2 on t1.MENU_ID = t2.MENU_ID order by sort_Order , PARENT_ID ";
                Params.Add("RoleId", RoleID);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public string SetRoleDetails()
        {
            string strReturn;
            string strMsg;
            DataTable Dt;
            string strSql = "";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };


            // if adding new user check if user Id Already Exists
            try
            {
                // make update statment
                if (Key > 0)
                {
                    strSql = "update role_menu_map set is_editable = @Editable , is_visible = @Visible , updated_by =  @CreatedBy, updated_on = CURRENT_TIMESTAMP  where role_menu_rk = @key";
                    Params.Add("key", Key.ToString());
                }
                else
                {
                    strSql = "insert into role_menu_map (role_id,menu_id,is_visible,is_editable,created_by,created_on,updated_by,updated_on) values (@RoleId,@MenuId,@Visible,@Editable,@CreatedBy,CURRENT_TIMESTAMP,@UpdatedBy,CURRENT_TIMESTAMP)";
                    Params.Add("RoleId", RoleID);
                    Params.Add("MenuId", MenuId);
                    Params.Add("UpdatedBy", CreatedBy);
                }
                strMsg = logicalOK;

                Params.Add("Editable", Editable.ToString());
                Params.Add("Visible", Visible.ToString());
                Params.Add("CreatedBy", CreatedBy);
                // cmd.Parameters.AddWithValue("@group", ParaGroup);
                DbConnectionFactory dbObj = new DbConnectionFactory();
                dbObj.ExecuteNonQuery(strSql,Params);
                strReturn = strMsg;
                return strReturn;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
