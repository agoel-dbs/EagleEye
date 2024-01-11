using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class BuyerManagement
    {

        public string BuyerRK { get; set; }

        public string BuyerName { get; set; }
        public string Add1 { get; set; } = "";

        public string EmailID { get; set; } = "";

        public string Add2 { get; set; } = "";

        public string City { get; set; } = "";

        public int IsActive { get; set; } 

        public string Remarks { get; set; } = "";

        public string CreatedBy { get; set; } = "";

        public string State { get; set; } = "";
        public string ContactPerson { get; set; } = "";

        public string Gstin { get; set; } = "";
        public bool AddFlag { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public bool bTransactionBound = false;


        public string ManageBuyerDetails()
        {
            string strReturn;
            string strMsg;
            DbConnectionFactory objFactory = new DbConnectionFactory();
            string ProcessName = "ManageBuyerDetails";
            // if adding new user check if user Id Already Exists
            try
            {


                Dictionary<string, string> Params = new Dictionary<string, string>();
                string sql = "";

                if (AddFlag == true)
                {
                    sql = "select count(1) from buyer_master where upper(name)=upper(@BuyerName)";
                    Params.Clear();
                    Params.Add("BuyerName", BuyerName);
                    if (bTransactionBound == false)
                    {
                        strReturn = objFactory.ExecuteScalerQuery(sql, Params);
                    }
                    else
                    {
                        strReturn = objFactory.TransExecuteScalerQuery(sql, Params);
                    }

                    if (strReturn != "0")
                    {
                        strReturn = logicalError + "Account / Buyer already exists, please try different Buyer !!! ";
                        return strReturn;
                    }

                    // make insert statment
                    sql = "insert into buyer_master(name,add1,add2,city,state,contact_person,email_id,gstin_no,is_active," +
                                       "remarks,created_by,updated_by) values( " +
                                        "upper(@name),@add1,@add2,@city,@state,@contact_person,@email_id,upper(@gstin_no),@is_active," +
                                        " @remarks,@created_by,@updated_by)";
                    Params.Clear();
                    Params.Add("created_by", CreatedBy);
                    strMsg = logicalOK + "New buyer created sucessfully!!! ";
                }
                else
                {
                    sql = "update buyer_master set name = upper(@name),add1 = @add1,add2 = @add2," +
                                        "city = @city,state = @state,contact_person = @contact_person," +
                                        "email_id = @email_id,gstin_no = upper(@gstin_no)," +
                                       "is_active =@is_active,remarks = @remarks,updated_by = @updated_by " +
                                         " , updated_on = CURRENT_TIMESTAMP  where buyer_rk = @BuyerRK";
                    Params.Add("BuyerRK", BuyerRK);
                    strMsg = logicalOK + "Buyer Information Updated Sucessfully!!! ";
                }
                Params.Add("name", BuyerName);
                Params.Add("add1", Add1);
                Params.Add("add2", Add2);
                Params.Add("city", City);
                Params.Add("state", State);
                Params.Add("contact_person", ContactPerson);
                Params.Add("email_id", EmailID);
                Params.Add("gstin_no", Gstin);
                Params.Add("is_active", IsActive.ToString());
                Params.Add("remarks", Remarks);
                Params.Add("updated_by", CreatedBy);

                if (bTransactionBound == false)
                {
                    objFactory.ExecuteNonQuery(sql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery(sql, Params);
                }

                strReturn = strMsg;
                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;
            }

        }




        public DataTable GetBuyerDetails()
        {
            try
            {
                DataTable Dt;
                string strSql;
                strSql = "select buyer_rk BuyerRk, Name Name, Add1 Address1, Add2 Address2, "+
                    "City City, State State, Contact_Person ContactPerson, Email_id EmailId,"+
                    "GSTIN_No GSTIN, is_Active Active, Remarks Remarks,"+
                    "Created_by CreatedBy , created_on CreatedOn,"+
                    "Updated_by UpdatedBy , Updated_On UpdatedOn from buyer_master where buyer_rk=@BuyerRk";
                string sql = strSql;
                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "BuyerRk", BuyerRK }};
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
