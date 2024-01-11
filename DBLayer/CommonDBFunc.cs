using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class CommonDBFunc
    {
        public string TableName { get; set; }
        public string CodeColumnName { get; set; }
        public string DisplayColumnName { get; set; }
        public string ShowAddNew { get; set; } = "";

        public string ShowAll { get; set; } = "";
        public string DataFilter { get; set; } = "";

        // Grid Realted fields
        public string InterfaceName { get; set; }
        public string GridName { get; set; }

        public DataTable GetGridHiddenColumn()
        {
            try
            {
                DataTable Dt;
                string sql = " select column_name from grid_master where upper(interface_name) = upper(@InterfaceName) " +
                         " and upper(grid_name) = upper(@GridName) and is_visible = 0 and is_active = 1";
                Dictionary<string, string> Params = new Dictionary<string, string>() { { "InterfaceName", InterfaceName }, { "GridName", GridName } };
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(sql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable GetGridProperties()
        {
            try
            {
                DataTable Dt;
                string sql = " select * from grid_master where upper(interface_name) = upper(@InterfaceName) " +
                         " and upper(grid_name) = upper(@GridName) and is_active = 1";
                Dictionary<string, string> Params = new Dictionary<string, string>() { { "InterfaceName", InterfaceName }, { "GridName", GridName } };
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(sql, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;

            }

        }


        public DataTable GetDropDownList()
        {
            try
            {
                DataTable Dt;
                string strSql;
                
                strSql = "";
                if (ShowAll == "Y")
                {
                    strSql = "select '-99' code , '<All>' Value union";
                }

                if (ShowAddNew == "Y")
                {
                    strSql = "select '-1' code , '<Add New>' Value union";
                }
                strSql = strSql + " select distinct " + CodeColumnName + " Code " +
                         " , " + DisplayColumnName + " Value from  " + TableName +
                         " where 1= 1 ";

                if (DataFilter != "")
                {
                    strSql = strSql + " and " + DataFilter;
                }
                strSql = strSql + " Order by Value" ;

                string sql = strSql;
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(sql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

    }
}
