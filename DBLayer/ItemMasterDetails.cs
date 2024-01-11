using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.DBLayer
{
    class ItemMasterDetails
    {

        public string ItemRK { get; set; }
        public string ExpenseKey { get; set; }
        public string ExpenseDesc { get; set; }
        public string DefaultValue { get; set; }

        public string ExpImpact { get; set; }
        public string ExpGroup { get; set; }

        public string UserEditable { get; set; }

        public int IsActive { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public bool AddFlag { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public bool bTransactionBound = false;



        public string ManageExpenseDetails()
        {
            string strReturn;
            string strMsg;
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };

            DbConnectionFactory objFactory = new DbConnectionFactory();

            // if adding new user check if user Id Already Exists
            try
            {

                if (AddFlag == true)
                {
                    strSql = "select count(1) from expense_master where upper(expense_key)=upper(@ExpenseKey) " +
                            "   or upper(expense_desc)  = upper(@ExpenseDesc) ";

                    Params.Add("ExpenseKey", ExpenseKey);
                    Params.Add("ExpenseDesc", ExpenseDesc);

                    if (bTransactionBound == false)
                    {
                        strReturn = objFactory.ExecuteScalerQuery(strSql, Params);
                    }
                    else
                    {
                        strReturn = objFactory.TransExecuteScalerQuery(strSql, Params);
                    }

                    if (strReturn != "0")
                    {
                        strReturn = logicalError + "The expense ID already exists, please try different ID !!! ";
                        return strReturn;
                    }

                    // make insert statment

                    strSql = "insert into expense_master(expense_key,expense_desc,default_value,exp_impact,user_editable,exp_group," +
                                       " is_active,remarks,created_by,updated_by) values( " +
                                        "upper(@ExpenseKey),@ExpenseDesc ,@DefaultValue,@ExpImpact, @UserEditable,@ExpGroup,@is_active," +
                                        " @remarks,@created_by,@updated_by)";

                    Params.Clear();
                    Params.Add("created_by", CreatedBy);
                    Params.Add("ExpenseKey", ExpenseKey);
                    strMsg = logicalOK + "New expense heade created sucessfully!!! ";
                }
                else
                {
                    // make update statment
                    strSql = "update expense_master set expense_desc = @ExpenseDesc,default_value = @DefaultValue,exp_impact = @ExpImpact," +
                                        " user_editable = @UserEditable,exp_group = @ExpGroup, " +
                                       "is_active =@is_active,remarks = @remarks,updated_by = @updated_by " +
                                         " , updated_on = CURRENT_TIMESTAMP  where expense_rk = @ExpenseRK";
                    strMsg = logicalOK + "Expense Information Updated Sucessfully!!! ";
                    Params.Add("ExpenseRK", ItemRK);
                }
                Params.Add("ExpenseDesc", ExpenseDesc);
                Params.Add("DefaultValue", DefaultValue);
                Params.Add("ExpImpact", ExpImpact);
                Params.Add("UserEditable", UserEditable);
                Params.Add("ExpGroup", ExpGroup);
                Params.Add("is_active", IsActive.ToString());
                Params.Add("remarks", Remarks);
                Params.Add("updated_by", CreatedBy);

                if (bTransactionBound == false)
                {
                    objFactory.ExecuteNonQuery(strSql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery(strSql, Params);
                }

                strReturn = strMsg;
                //objExpense.CloseConnection(pConn);
                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + e.Message;
            }

        }



        public DataTable GetItemDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select * from vw_item_master_sale where ItemRk = @ItemRK";
                Params.Add("ItemRK", ItemRK);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                return null;
            }

        }


    }
}
