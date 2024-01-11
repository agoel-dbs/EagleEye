using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;


namespace EagleEye.DBLayer
{
    class OutwardPayment
    {


        public int SubHeadRk { get; set; }

        public string  SubHeadDesc { get; set; }
        public int VendorRk { get; set; }

        public int OutwardRk { get; set; }
        public decimal TranAmt { get; set; }

        public string TranDate { get; set; }

        public string PaymentMode { get; set; }

        public string InstrumentNo { get; set; }

        public string Remarks { get; set; }

        public string CreatedBy { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";

        public bool bTransactionBound = false;


        public DataTable GetVendorPaymentDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select Outwardkey ,VendorName,SubHead,TransactionAmount,Dated" +
                    ",PaymentMode,InstrumentNo,Remarks ,CreatedBy ,DateofEntry  " +
                    " from vw_outward_payment where VendorKey= @VendorRk order by Outwardkey  Desc";

                Params.Add("VendorRk", VendorRk.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;

            }

        }

        

        public string PostOutwardPaymentEntry()
        {
            string strReturn;
            string ProcessName = "PostOutwardPaymentEntry";
            //string strMsg;

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

                // make insert statment

                strSql= "insert into outward_remittance" +
                                    "(sub_head_rk,vendor_rk,tran_amt,tran_date,payment_mode,instrument_no,remarks,created_by,updated_by) " +
                                    " values " +
                                    "(@SubHeadRk, @VendorRk,@TranAmt,@TranDate,@PaymentMode,@InstrumentNo,@Remarks,@CreatedBy,@CreatedBy)";

                Params.Add("SubHeadRk", SubHeadRk.ToString());
                Params.Add("VendorRk", VendorRk.ToString());
                Params.Add("TranAmt", TranAmt.ToString());
                Params.Add("TranDate", TranDate.ToString());
                Params.Add("PaymentMode", PaymentMode);
                Params.Add("InstrumentNo", InstrumentNo);
                Params.Add("Remarks", Remarks);
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // get Remittance_rk
                strSql = "select max(outward_rk) from outward_remittance";
                Params.Clear();
                OutwardRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql,Params));

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.VendorRk = VendorRk;
                objLedger.BuyerRk = -1;
                objLedger.TranAmount = TranAmt;
                objLedger.TransactionSubHead = SubHeadDesc;
                objLedger.TranDate = TranDate.ToString();
                objLedger.TranSource = "Vendor Payment";
                objLedger.SourceRK = OutwardRk;
                objLedger.Remarks = Remarks;
                objLedger.EventDetails = "Company Expenses";
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostPaymentMadeEntry();




                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();
                    objFactory.TransCloseConnection();
                    return strReturn;
                }

                objFactory.TransCommit();
                objFactory.TransCloseConnection();
                strReturn = logicalOK + "Expenses posted sucessfully!!! ";
                
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name: " + ProcessName + " : " + e.Message;

            }

        }




    }
}
