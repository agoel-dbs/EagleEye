 using EagleEye.Lib;
using System;
using System.Collections.Generic;

namespace EagleEye.DBLayer
{


    class StartupData
    {


        public string BuyerName { get; set; }

        public string VendorName { get; set; }

        public string Add1 { get; set; }

        public string EmailID { get; set; }

        public string Add2 { get; set; }

        public string City { get; set; }

        public int IsActive { get; set; }

        public string Remarks { get; set; }

        public string CreatedBy { get; set; }

        public string State { get; set; }
        public string ContactPerson { get; set; }

        public decimal TotalAmtPayable { get; set; }
        public string TranDate { get; set; }

        public string TranSource { get; set; }

        public string Gstin { get; set; }

        public string TransactionSubHead { get; set; }

        // scripts


        public string Sql { get; set; }
        public string MdbChanges { get; set; }

        private bool AddFlag { get; set; }



        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public string PostCustomerOutstanding()
        {
            string strReturn;
            string strMsg;
            int BuyerRk;


            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            objFactory.TransCommand();
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            //SQLiteTransaction myTrans;

            // Start a local transaction
            //myTrans = pConn.BeginTransaction();
            // Assign transaction object for a pending local transaction
            //cmd.Transaction = myTrans;

            try
            {
                string sql = "select isnull(max(buyer_rk),-1) from buyer_master where upper(name)=upper(@BuyerName)";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                {{ "BuyerName", BuyerName.ToString() }};
                strReturn = objFactory.TransExecuteScalerQuery(sql, Params);
                BuyerRk = Convert.ToInt32(strReturn);

                //first create a buyer

                BuyerManagement objBuyer = new BuyerManagement();
                objBuyer.BuyerName = BuyerName;
                objBuyer.Add1 = Add1;
                objBuyer.Add2 = Add2;
                objBuyer.City = City;
                objBuyer.State = State;
                objBuyer.Gstin = Gstin;
                objBuyer.IsActive = 1;
                objBuyer.Remarks = "Start-up data";
                objBuyer.CreatedBy = CreatedBy;
                objBuyer.bTransactionBound = true;
                if (BuyerRk > 0)
                {
                    objBuyer.AddFlag = false;
                }
                else
                {
                    objBuyer.AddFlag = true;
                }


                strReturn = objBuyer.ManageBuyerDetails();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();//cmd.Transaction.Rollback();
                    return strReturn;
                }

                // get the buyerrk 

                if (BuyerRk < 0)
                {
                    sql = "select max(buyer_rk) from buyer_master where upper(name)=upper(@BuyerName)";
                    Params.Clear();
                    Params.Add("BuyerName", BuyerName.ToString());

                    //cmd.CommandText = "select max(buyer_rk) from buyer_master where upper(name)=upper(@BuyerName)";
                    //Params.Add("@BuyerName", BuyerName.ToString());
                    //cmd.Prepare();
                    strReturn = objFactory.TransExecuteScalerQuery(sql, Params);//   objStartup.ExecuteScalar(cmd);
                    BuyerRk = Convert.ToInt32(strReturn);
                }
                //// insert data into party ledger account one for Sale

                if (TotalAmtPayable != 0)
                {
                    CompanyLedger objLedger = new CompanyLedger();
                    objLedger.BuyerRk = BuyerRk;
                    objLedger.TranAmount = TotalAmtPayable;
                    objLedger.TranDate = TranDate.ToString();
                    objLedger.TranSource = TranSource;
                    objLedger.SourceRK = -1;
                    objLedger.Remarks = Remarks;
                    objLedger.EventDetails = "Customer Outstandng Balance";
                    objLedger.CreatedBy = CreatedBy;
                    objLedger.bTransactionBound = true;
                    strReturn = objLedger.PostInvoiceEntry();

                    InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback();
                        return strReturn;
                    }
                }

                objFactory.TransCommit();
                strReturn = logicalOK + "Outstanding Posted Sucessfully!!! ";
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                return TechnicalError + e.Message;

            }
            finally
            {
                objFactory.TransCloseConnection();
            }

        }





        public string ExecuteDbScripts()
        {
            string strReturn;
            string strMsg;
            int LogRk;
            string strSQL;
            string strVersion;
            DbConnectionFactory objFactory = new DbConnectionFactory();
            // Start a local transaction
            objFactory.TransConnection();
            objFactory.TransCommand();
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            Dictionary<string, string> Params = new Dictionary<string, string>() { };

            try
            {
                ParameterDetails objParam = new ParameterDetails();
                objParam.ParaCode = "VER";
                strVersion = objParam.GetParameterValue();
                strSQL = "insert into db_change_log (change_statment,release_version,mdb_change," +
                                   "created_by,updated_by)" +
                                   " values (" +
                                   " @Sql,@Version,@MdbChanges,@CreatedBy,@CreatedBy ) ";

                Params.Add("Sql", Sql);
                Params.Add("MdbChanges", MdbChanges);
                Params.Add("Version", strVersion);
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSQL, Params);

                // get log rk

                strSQL = "select max(log_rk) from db_change_log";
                Params.Clear();
                LogRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSQL, Params));

                // execute statment
                Params.Clear();
                objFactory.TransExecuteNonQuery(Sql,Params);

                // update processed status

                strSQL = "update db_change_log  set is_processed = 'Y' where log_rk = @logRk";
                Params.Clear();
                Params.Add("logRk", LogRk.ToString());
                objFactory.TransExecuteNonQuery(strSQL,Params);

                objFactory.TransCommit();
                strReturn = logicalOK + "Query executed Sucessfully!!! ";
                
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                return TechnicalError + e.Message;
            }
            finally
            {
                objFactory.TransCloseConnection();

            }

        }


        public string PostVendorOutstanding()
        {
            string strReturn;
            string strMsg;
            int VendorRk;
            DbConnectionFactory objFactory = new DbConnectionFactory();
            // Start a local transaction
            objFactory.TransConnection();
            objFactory.TransCommand();
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };

            try
            {

                strSql = "select " + Global.gIsNull + "(max(vendor_rk),-1) from vendor_master " +
                        "where upper(name)=upper(@VendorName)";
                Params.Clear();
                Params.Add("VendorName", VendorName.ToString());
                strReturn = objFactory.TransExecuteScalerQuery (strSql,Params);
                VendorRk = Convert.ToInt32(strReturn);

                //first create a buyer

                VendorManagement objVendor = new VendorManagement();

                objVendor.VendorName = VendorName;
                objVendor.Add1 = Add1;
                objVendor.Add2 = Add2;
                objVendor.City = City;
                objVendor.State = State;
                objVendor.Gstin = Gstin;
                objVendor.IsActive = 1;
                objVendor.Remarks = "Start-up data";
                objVendor.CreatedBy = CreatedBy;
                objVendor.bTransactionBound=true ;
                if (VendorRk > 0)
                {
                    objVendor.AddFlag = false;
                }
                else
                {
                    objVendor.AddFlag = true;
                }


                strReturn = objVendor.ManageVendorDetails();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();
                    objFactory.TransCloseConnection();
                    return strReturn;
                }

                // get the buyerrk 

                if (VendorRk < 0)
                {
                    strSql= "select max(vendor_rk) from vendor_master where upper(name)=upper(@VendorName)";
                    Params.Clear();
                    Params.Add("VendorName", VendorName.ToString());
                    strReturn = objFactory.TransExecuteScalerQuery(strSql,Params);
                    VendorRk = Convert.ToInt32(strReturn);
                }
                //// insert data into party ledger account one for Sale

                if (TotalAmtPayable != 0)
                {
                    CompanyLedger objLedger = new CompanyLedger();
                    objLedger.VendorRk = VendorRk;
                    objLedger.TranAmount = TotalAmtPayable;
                    objLedger.TranDate = TranDate.ToString();
                    objLedger.TransactionSubHead = TransactionSubHead;
                    objLedger.TranSource = TranSource;
                    objLedger.SourceRK = -1;
                    objLedger.Remarks = Remarks;
                    objLedger.EventDetails = "Vendor Outstandng Balance";
                    objLedger.CreatedBy = CreatedBy;
                    objLedger.bTransactionBound = true;
                    strReturn = objLedger.PostSupplierBillEntry();

                    InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback();
                        objFactory.TransCloseConnection();
                        return strReturn;
                    }
                }

                objFactory.TransCommit();
                objFactory.TransCloseConnection();
                strReturn = logicalOK + "Outstanding Posted Sucessfully!!! ";
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + e.Message;

            }

        }

        
    }
}
