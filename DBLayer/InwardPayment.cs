using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class InwardPayment
    {

        public int BuyerRk { get; set; }

        public int InwardRk { get; set; }
        public decimal TranAmt { get; set; }

        public string TranDate{ get; set; }

        public string PaymentMode { get; set; }

        public string InstrumentNo { get; set; }

        public string InwardRemarks { get; set; }

        public string  CreatedBy { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public DataTable GetCustomerPaymentDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };


                strSql = "select Inwardkey ,BuyerName,TransactionAmount,Dated" +
                    ",PaymentMode,InstrumentNo,Remarks ,CreatedBy ,DateofEntry  " +
                    " from vw_Inward_payment where BuyerKey= @Buyer_rk order by Inwardkey  Desc";
                Params.Add("Buyer_rk", BuyerRk.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;

            }

        }

  
        public string PostPaymentEntry()
        {
            string strReturn;
            string ProcessName = "PostPaymentEntry";
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

                strSql = "insert into inward_remittance" +
                                    "(buyer_rk,tran_amt,tran_date,payment_mode,instrument_no,remarks,created_by,updated_by) " +
                                    " values " +
                                    "( @BuyerRk,@TranAmt,@TranDate,@PaymentMode,@InstrumentNo,@Remarks,@CreatedBy,@CreatedBy)";

                Params.Add("BuyerRk", BuyerRk.ToString());
                Params.Add("TranAmt", TranAmt.ToString());
                Params.Add("TranDate", TranDate.ToString());
                Params.Add("PaymentMode", PaymentMode);
                Params.Add("InstrumentNo", InstrumentNo);
                Params.Add("Remarks", InwardRemarks);
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // get remittance_rk
                strSql = "select max(inward_rk) from inward_remittance";

                Params.Clear();
                InwardRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql,Params));

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.BuyerRk = BuyerRk;
                objLedger.TranAmount = TranAmt;
                objLedger.TranDate = TranDate.ToString();
                objLedger.TranSource = "Inward Remittance";
                objLedger.TransactionSubHead = "Customer Payment";
                objLedger.SourceRK = InwardRk;
                objLedger.Remarks = InwardRemarks;
                objLedger.EventDetails = "Customer Payment Received";
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostPaymentReceivedEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback();
                        objFactory.TransCloseConnection();
                        return strReturn;
                    }

                objFactory.TransCommit();
                strReturn = logicalOK + "Payment posted sucessfully!!! ";
                objFactory.TransCloseConnection();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name: " + ProcessName + " : "  + e.Message;

            }

        }




    }
}
