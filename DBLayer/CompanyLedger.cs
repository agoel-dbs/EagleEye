using EagleEye.Lib;
using System;
using System.Collections.Generic;

namespace EagleEye.DBLayer
{
    class CompanyLedger
    {

        public int BuyerRk { get; set; }
        public int VendorRk { get; set; }
        
        public int SourceRK { get; set; }

        public string TranDate { get; set; }
        public string Remarks { get; set; }

        public string TranSource { get; set; }
        public string EventDetails { get; set; }
        private string TransactionHead { get; set; }
        public string TransactionSubHead { get; set; }
        public decimal TranAmount { get; set; }
        private decimal LedgerAmount { get; set; }



        public string CreatedBy { get; set; }
        //public SQLiteConnection TransactionConn;
        public bool bTransactionBound = false;

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";




        public string PostLedgerEntry()
        {
            string strReturn;

            DbConnectionFactory objFactory = new DbConnectionFactory();
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            string strSql;
            string ProcessName = "PostLedgerEntry";
            try
            {

                strSql = " insert into ledger_account (" +
                        "buyer_rk,vendor_rk,tran_head,tran_sub_head,tran_amt,tran_date," +
                        "ledger_amt,tran_source,source_rk,event_detail,remarks,created_by) " +
                        " values " +
                        " ( @BuyerRk ,@VendorRk,@TransactionHead,@TransactionSubHead,@TranAmount,@TranDate," +
                        " @LedgerAmount , @TranSource,@SourceRK,@EventDetails,@Remarks,@CreatedBy)";

                Params.Add("BuyerRk", BuyerRk.ToString());
                Params.Add("VendorRk", VendorRk.ToString());
                Params.Add("TransactionHead", TransactionHead);
                Params.Add("TransactionSubHead", TransactionSubHead);
                Params.Add("TranAmount", TranAmount.ToString());
                Params.Add("TranDate", TranDate);
                Params.Add("LedgerAmount", LedgerAmount.ToString());
                Params.Add("TranSource", TranSource.ToString());
                Params.Add("SourceRK", SourceRK.ToString());
                Params.Add("EventDetails", EventDetails);
                Params.Add("Remarks", Remarks);
                Params.Add("CreatedBy", CreatedBy);

                if (bTransactionBound == false)
                {
                    objFactory.ExecuteNonQuery(strSql, Params);
                }
                else
                {
                    objFactory.TransExecuteNonQuery (strSql, Params);
                }

                strReturn = logicalOK + "Ledger Entry Created";
                return strReturn;

            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }

        public string PostInvoiceEntry()
        {
                string strReturn;
                string ProcessName = "PostInvoiceEntry";
                try
                {

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.BuyerRk = BuyerRk;
                objLedger.TransactionHead = "SALE";
                objLedger.TransactionSubHead = "Customer Sale";
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = -1 * TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostLedgerEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    return strReturn;
                }


                // extract from Goods

                objLedger.BuyerRk = -1;
                objLedger.TransactionHead = "GOODS";
                objLedger.TransactionSubHead = "Customer Sale";
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
//                objLedger.TransactionConn = TransactionConn;
                strReturn = objLedger.PostLedgerEntry();

                InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    return strReturn;
                }

                return strReturn;
            }

            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public string PostPaymentMadeEntry()
        {
            // this process will be used for all the cash / cheque payment made by company to vendor or service without bill
            string strReturn;
            string ProcessName = "PostPaymentMadeEntry";
            try
            {

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.BuyerRk = -1;
                objLedger.VendorRk = -1;
                objLedger.TransactionHead = "CASH";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostLedgerEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    return strReturn;
                }


                // extract from Goods

                objLedger.BuyerRk = -1;
                objLedger.VendorRk = VendorRk;
                objLedger.TransactionHead = "PURCHASE";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = -1 * TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                //                objLedger.TransactionConn = TransactionConn;
                strReturn = objLedger.PostLedgerEntry();

                InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    return strReturn;
                }

                return strReturn;
            }

            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public string PostPaymentReceivedEntry()
        {
            string strReturn;
            string ProcessName = "PostPaymentReceivedEntry";
            try
            {

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.BuyerRk = BuyerRk;
                objLedger.TransactionHead = "SALE";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostLedgerEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    return strReturn;
                }


                // extract from Goods

                objLedger.BuyerRk = -1;
                objLedger.TransactionHead = "CASH";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = -1 * TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                //                objLedger.TransactionConn = TransactionConn;
                strReturn = objLedger.PostLedgerEntry();

                InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    return strReturn;
                }

                return strReturn;
            }

            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public string PostSupplierBillEntry()
        {
            string strReturn;
            string ProcessName = "PostSupplierBillEntry";
            try
            {
                // enter Purchase entry

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.VendorRk = VendorRk;
                objLedger.TransactionHead = "PURCHASE";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostLedgerEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    return strReturn;
                }

                // enter Goods 

                objLedger.VendorRk = -1;
                objLedger.TransactionHead = "GOODS";
                objLedger.TransactionSubHead = TransactionSubHead;
                objLedger.TranAmount = TranAmount;
                objLedger.TranDate = TranDate;
                objLedger.LedgerAmount = -1 * TranAmount;
                objLedger.TranSource = TranSource;
                objLedger.SourceRK = SourceRK;
                objLedger.EventDetails = EventDetails;
                objLedger.Remarks = Remarks;
                objLedger.CreatedBy = CreatedBy;
                strReturn = objLedger.PostLedgerEntry();

                InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    return strReturn;
                }

                return strReturn;
            }

            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }




    }
}
