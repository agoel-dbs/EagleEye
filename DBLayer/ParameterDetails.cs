using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class ParameterDetails
    {

        public string ParaCode { get; set; }
        public string ParaValue { get; set; }

        public string ParaName { get; set; }

        public int IsActive { get; set; }

        public string ParamGroup { get; set; }

        public bool bTransactionBound = false;

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public string GetParameterValue()
        {
            try
            {
                string strReturn;
                string sql = "select max(Para_value) para_value from param_master where para_code=@ParaCode";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "ParaCode", ParaCode }};
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(sql, Params);
                return strReturn;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public DataTable GetParameterValueAll()
        {
            try
            {
                DataTable Dt;
                string sql = "select Para_value ,para_code from param_master where is_active = 1";
                Dictionary<string, string> Params = new Dictionary<string, string>();
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(sql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string SetParameterValue()
        {

            string strReturn;
            string ProcessName = "SetParameterValue";
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();

            try
            {

                strSql = "update param_master set para_value = @ParaValue where para_code=@ParaCode";
                Params.Add("ParaValue", ParaValue);
                Params.Add("ParaCode", ParaCode);

                if (bTransactionBound == false)
                {
                    objFactory.ExecuteNonQuery(strSql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery(strSql, Params);
                }

            
                strReturn = logicalOK + "Parameter Updated Sucessfully";
                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;
            }

        }

        public DataTable GetParameterList()
        {
            try
            {
                DataTable Dt;
                string sql = "Select para_code ParaCode,Param_name Name,para_value Value , is_active Active" +
                    " from param_master where para_group=@ParaGroup ";
                Dictionary<string, string> Params = new Dictionary<string, string>() { { "ParaCode", ParaCode } };
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(sql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                return null;
            }

        }


    }
}
