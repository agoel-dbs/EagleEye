using System;
using System.Collections.Generic;
using System.Data;


namespace EagleEye.DBLayer
{
    class VendorManagement
    {

        public string VendorRK { get; set; }
        public string VendorName { get; set; }
        public string Add1{ get; set; } = "";
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



        public string ManageVendorDetails()
        {
                string strReturn;
                string strMsg;
                DbConnectionFactory objFactory = new DbConnectionFactory();
                string ProcessName = "ManageVendorDetails";

            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };


            // if adding new user check if user Id Already Exists
            try
            {

                if (AddFlag == true)
                {
                    strSql = "select count(1) from vendor_master where upper(name)=upper(@VendorName)";
                    Params.Clear();
                    Params.Add("VendorName", VendorName);
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
                        strReturn = logicalError + "Vendor already exists, please try different Vendor !!! ";
                        return strReturn;
                    }

                    // make insert statment
                    Params.Clear();
                    strSql = "insert into vendor_master(name,add1,add2,city,state,contact_person,email_id,gstin_no,is_active," +
                                       "remarks,created_by,updated_by) values( " +
                                        "upper(@name),@add1,@add2,@city,@state,@contact_person,@email_id,@gstin_no,@is_active," +
                                        " @remarks,@created_by,@updated_by)";

                    Params.Add("created_by", CreatedBy);
                    strMsg = logicalOK + "New vendor created sucessfully!!! ";
                }
                else
                {
                    // make update statment
                    strSql      = "update vendor_master set name = @name,add1 = @add1,add2 = @add2,city = @city,state = @state,contact_person = @contact_person,email_id = @email_id," +
                                        "gstin_no = @gstin_no," +
                                       "is_active =@is_active,remarks = @remarks,updated_by = @updated_by " +
                                         " , updated_on = CURRENT_TIMESTAMP  where vendor_rk = @VendorRK";
                    strMsg = logicalOK + "Vendor Information Updated Sucessfully!!! ";
                    Params.Clear();

                    Params.Add("VendorRK", VendorRK);
                }
                    Params.Add("name", VendorName);
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
                    objFactory.ExecuteNonQuery(strSql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery(strSql, Params);
                }
                strReturn = strMsg;                
                //objVendor.CloseConnection(pConn);
                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + e.Message;
            }

        }



        public DataTable GetVendorDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
                strSql = "select vendor_rk VendorRk, Name Name, Add1 Address1, Add2 Address2, " +
                "City City, State State, Contact_Person ContactPerson, Email_id EmailId,"+
                "GSTIN_No GSTIN, is_Active Active, Remarks Remarks,"+
                "Created_by CreatedBy , created_on CreatedOn,"+
                "Updated_by UpdatedBy , Updated_On UpdatedOn from VENDOR_MASTER where vendor_rk=@VendorRK";
                Params.Add("VendorRK", VendorRK.ToString());
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
