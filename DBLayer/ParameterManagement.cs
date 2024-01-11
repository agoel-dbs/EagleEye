using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class ParameterManagement
    {

       
        public string ParaGroup { get; set; }

        public string ParaName { get; set; }

        public string ParaCode { get; set; }

        public string  ParaValue { get; set; }
        public int Active { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";
        

        public DataTable GetParameterDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select para_code ParaCode ,param_name Name,Para_value Value,is_active Active"
                    + " from param_master where para_group= @para_group ";

                Params.Add("para_group", ParaGroup);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public string SetParameterDetails()
        {
            DataTable Dt;
            string strSql = "";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            string strMsg;

            try
            {
                // make update statment
                strSql = "update param_master set param_name = @name,para_value = @value,is_active = @active," + 
                                         "created_on = CURRENT_TIMESTAMP  where para_code = @code and para_group =@group";
                strMsg = logicalOK + "Parameter Updated sucessfully!!!" ;


                Params.Add("name", ParaName);
                Params.Add("value", ParaValue);
                Params.Add("code", ParaCode);
                Params.Add("active", Active.ToString());
                Params.Add("group", ParaGroup);
                DbConnectionFactory dbObj = new DbConnectionFactory();
                dbObj.ExecuteNonQuery(strSql, Params);
                return strMsg;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public DataTable RavannaExcludedLines()
        {
            DataTable Dt;
            string strSql ;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            try
            {
                // make update statment
                strSql = "select para_value from param_master where para_group ='RAVANNA_EXCLUDE_LINES'";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable RavannaIncludeLines()
        {
            DataTable Dt;
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            try
            {
                // make update statment
                strSql = "select * from param_master  where PARA_GROUP = 'SOURCE_FILE_LINE_DETAILS' and para_code<> 'START_LINE_FROM' order by PARA_ORDER";
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
