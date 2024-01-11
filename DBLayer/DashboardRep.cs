using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class DashboardRep
    {
        // parameteres for partywise sale report
        public int BuyerRk { get; set; } = -1;
        public string SaleType { get; set; } = "";

        public string InvoiceType { get; set; } = "";
        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string DailyDate{ get; set; }


        // parameteres for partwise sale report
        public int VendorRk { get; set; } = -1;


        // 


        // Get Stock Staus

        
            public int ItemRk { get; set; } = -1;

        public string SubHead { get; set; } ="";



        private string AllSelectedValtext = "-99";
        private int AllSelectedVal = -99;

        public string TechnicalError = "100~";

        // Include sale of selected period for Party Ledger Report

        public string IncludeSaleforSelectedPeriod = "Y";

        public DataTable GetPartyWiseSaleReport()
        {
            try
            {
                string strSQL;
                DataTable Dt;
             
                strSQL = "select OnAccount,ActualQty Qty,ActualRate Rate,TotalPayableAmount ,AmountReceived ,InvoiceType,SaleType,InvoiceNo,Dated,DispatchDateTime,RavaanaNo,TruckNo,Buyer BillTo,BuyerGSTIN,ItemDesc,ItemAmount" +
                                ",CGSTAmount,SGSTAmount,IGSTAmount,TaxAmount ,TotalAmount TaxInvoiceAmount," +
                                  " LoadingCharges,Commission" +
                                  " from vw_Invoice_Details where 1= 1 " +
                                  " and Dated >= @FromDate  and Dated <= @ToDate ";
                Dictionary<string, string> Params = new Dictionary<string, string>() 
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (BuyerRk != AllSelectedVal)
                {
                    strSQL = strSQL + " and BuyerKey = @BuyerRk ";
                    Params.Add("BuyerRk", BuyerRk.ToString());
                }
                if (SaleType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(SaleType) = upper(@SaleType) ";
                    Params.Add("SaleType", SaleType);
                }
                if (InvoiceType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(InvoiceType) = upper(@InvoiceType) ";
                    Params.Add("InvoiceType", InvoiceType);
                }

                strSQL =  strSQL + " order by InvoiceNo desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;

}
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable GetPartyWiseSaleReportShort()
        {
            try
            {
                string strSQL;
                DataTable Dt;

                //strSQL = "select Buyer BillTo,InvoiceNo,TruckNo,DispatchDateTime, " +
                //     " ActualRate Rate, ActualQty Qty, round(TaxAmount, 0) Tax,round(TotalAmount, 0) TaxInvoiceAmount,LoadingCharges,round(TotalPayableAmount, 0) TotalPayableAmount, " +
                //    " round(case when(TaxAmount > 0  and " + Global.gLength +  "(trim(BuyerGSTIN)) > 2 and InvModified = 0) then TotalAmount  else 0 end,0) ChequeAmount, " +
                //    " round(case when(TaxAmount > 0  and  " + Global.gLength + "(trim(BuyerGSTIN)) > 2 and InvModified = 0) then TotalPayableAmount - TotalAmount  else TotalPayableAmount end,0) CashAmount " +
                //    " from vw_Invoice_Details where 1= 1 " +
                //    " and Dated >= @FromDate  and Dated <= @ToDate ";

                strSQL = "select OnAccount,ActualQty Qty,ActualRate Rate,TotalAmt  Total ,Buyer BillTo,CONVERT(varchar,substring(DispatchDateTime,1,10), 108) Date,TruckNo, " +
                     "round(TaxAmount, 0) Tax,LoadingCharges Loading , " +
                    "ChequeAmt Cheque ,CashAmt Cash " +
                    " from vw_Invoice_Details where 1= 1 " +
                    " and Dated >= @FromDate  and Dated <= @ToDate ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (BuyerRk != AllSelectedVal)
                {
                    strSQL = strSQL + " and BuyerKey = @BuyerRk ";
                    Params.Add("BuyerRk", BuyerRk.ToString());
                }
                if (SaleType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(SaleType) = upper(@SaleType) ";
                    Params.Add("SaleType", SaleType);
                }
                if (InvoiceType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(InvoiceType) = upper(@InvoiceType) ";
                    Params.Add("InvoiceType", InvoiceType);
                }

                strSQL = strSQL + " order by InvoiceNo desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable GetAggregatedSaleReport()
        {
            try
            {
                string strSQL;
                DataTable Dt;

                strSQL = "select Dated,InvoiceType,SaleType,ItemDesc,SaleQty,SaleAmount,Tax,Commission,Collection,LoadingCharges,SaleCount" +
                                  " from vw_agg_Sale where 1= 1 " +
                                  " and Dated >= @FromDate  and Dated <= @ToDate ";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (SaleType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(SaleType) = upper(@SaleType) ";
                    Params.Add("SaleType", SaleType);
                }
                if (InvoiceType != AllSelectedValtext)
                {
                    strSQL = strSQL + " and upper(InvoiceType) = upper(@InvoiceType) ";
                    Params.Add("InvoiceType", InvoiceType);
                }
                strSQL = strSQL + " order by Dated desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable GetCustomerOutstandingBalance()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                strSQL = "select BuyerName,LedgerBalance,LedgerStatus" +
                    " from vw_agg_party_ledger where 1=1 ";

                Dictionary<string, string> Params = new Dictionary<string, string>();
                
                if (BuyerRk != AllSelectedVal)
                {
                    strSQL = strSQL + " and BuyerKey = @BuyerRk ";
                    Params.Add("BuyerRk", BuyerRk.ToString());
                }

                strSQL = strSQL + " order by BuyerName";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);

                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }


        }


        public DataTable GetCustomerOutstandingBalanceDateRange()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                
                // Outstanding Balance till the FromDate Variable and Payment made till to date ( if we want to see how much is balance from the billss raised on last 15 days
                strSQL = "select   t1.*,case when t1.LedgerBalance > 0 then 'Payment Pending' when t1.LedgerBalance = 0 then 'Account Settled' else 'Credit' end LedgerStatus " +
                          " ,t2.PendingBillStartDate,t2.LastPaymentMade FROM (select BuyerKey BuyerKey, BuyerName, round(sum(TransactionAmount * -1), 2) LedgerBalance " +
                          " from vw_Party_Ledger where 1 = 1 and ((TransactionDate < @FromDate) or (SubHead = 'Customer Payment' and TransactionDate <= @ToDate))   " +
                          " group by BuyerName, BuyerKey" +
                          ") t1" +
                          " left outer join vw_party_ledger_adjustment t2 on t1.BuyerKey = t2.BuyerKey " +
                          " where 1 = 1 ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                //{ { "ToDate", ToDate} };
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (BuyerRk != AllSelectedVal)
                {
                    strSQL = strSQL + " and t1.BuyerKey = @BuyerRk ";
                    Params.Add("BuyerRk", BuyerRk.ToString());
                }

                strSQL = strSQL + " order by BuyerName";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);

                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }


        }



        //public DataTable GetCustomerLedgerHistory()
        //{
        //    try
        //    {
        //        DataTable Dt;
        //        string strSQL; 

        //        strSQL = "select LedgerKey,BuyerName,TransactionDate,SubHead, TransactionAmount" +
        //            " ,sum(TransactionAmount) over (order by TransactionDate asc,LedgerKey asc) as LedgerTotal , Source," +
        //            " Action,Remarks , CreatedBy , CreatedOn" +
        //            " from vw_Party_Ledger where 1 = 1 " +
        //            " and TransactionDate >= @FromDate  and TransactionDate <= @ToDate";

        //        Dictionary<string, string> Params = new Dictionary<string, string>()
        //        { { "FromDate", FromDate },{ "ToDate", ToDate} };

        //        if (BuyerRk != AllSelectedVal)
        //        {
        //            strSQL = strSQL + " and BuyerKey = @BuyerRk ";
        //            Params.Add("BuyerRk", BuyerRk.ToString());
        //        }

        //        strSQL = strSQL + " order by BuyerName , TransactionDate asc,LedgerKey asc";
        //        DbConnectionFactory objAdapter = new DbConnectionFactory();
        //        Dt = objAdapter.AdapterQuery(strSQL, Params);
        //        return Dt;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;

        //    }
        //}


        public DataTable GetCustomerLedgerHistory()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                string strSQL1;

                strSQL = "select LedgerKey,BuyerName,TransactionDate,SubHead, TransactionAmount" +
                    " ,sum(TransactionAmount) over (order by TransactionDate asc,LedgerKey asc) as LedgerTotal , Source," +
                    " Action,Remarks , CreatedBy , CreatedOn " +
                    "from ( " +
                    " select -1 LedgerKey, '' BuyerName, convert(date,@FromDate) TransactionDate, 'Opening Balance' SubHead, sum(TransactionAmount) TransactionAmount, " +
                    " '' Source,'' Action, '' Remarks , '' CreatedBy , convert(date,@FromDate) CreatedOn" +
                    " from vw_Party_Ledger where BuyerKey = @BuyerRk  and TransactionDate <  @FromDate " +
                    " union ";
                strSQL1 = "  select LedgerKey,BuyerName,TransactionDate,SubHead, TransactionAmount,Source,Action,Remarks , CreatedBy , CreatedOn " +
                      "  from vw_Party_Ledger where 1 = 1 " +
                      " and TransactionDate >= @FromDate  and TransactionDate <= @ToDate";
                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} ,{"BuyerRk",BuyerRk.ToString()} };

                if (BuyerRk != AllSelectedVal)
                {
                    strSQL1 = strSQL1 + " and BuyerKey = @BuyerRk ";
                    //Params.Add("BuyerRk", BuyerRk.ToString());
                }

                strSQL1 = strSQL1 + " union " +
                    " select 999999 LedgerKey, '' BuyerName, convert(date,@ToDate) TransactionDate, 'Closing Balance' SubHead, sum(TransactionAmount) TransactionAmount, " +
                    " '' Source,'' Action, '' Remarks , '' CreatedBy , convert(date,@ToDate) CreatedOn" +
                    " from vw_Party_Ledger where BuyerKey = @BuyerRk  and TransactionDate >  @ToDate " +
                 ") t1";
                strSQL = strSQL + strSQL1;
                    //+  " order by BuyerName , TransactionDate asc,LedgerKey asc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }
        }


        public DataTable GetCustomerLedgerHistoryNew()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                string strSQL1;
                string strsubHeadFilter;


                strsubHeadFilter = "";
                if (IncludeSaleforSelectedPeriod == "N")
                {
                    strsubHeadFilter = " and subhead = 'Customer Payment' ";  // show only payment
                }
                
                //strSQL = "select LedgerKey,BuyerName,TransactionDate,SubHead, " +
                //    " InvoiceNo,TruckNo, DispatchDateTime , Rate,   Qty, ActualAmount,Tax, LoadingCharges " +
                //    " ,TransactionAmount,sum(TransactionAmount) over (order by TransactionDate asc,LedgerKey asc) as LedgerTotal " +
                //    " from ( " +
                //    " select -1 LedgerKey, '' BuyerName, convert(date,@FromDate) TransactionDate, 'Opening Balance' SubHead, " +
                //    " '' InvoiceNo,'' TruckNo,'' DispatchDateTime ,0.0 Rate, 0.0 Qty,0.0 ActualAmount,0.0 Tax,0.0 LoadingCharges " +
                //    " , sum(TransactionAmount) TransactionAmount " +
                //    " from vw_Party_Ledger where BuyerKey = @BuyerRk  and TransactionDate <  @FromDate " +
                //    " union ";
                //"select BuyerName , CONVERT(varchar,isnull(substring(DispatchDateTime,1,10),TransactionDate), 108) Date,TruckNo,SubHead, " +

                strSQL = "select BuyerName , CONVERT(char(15),TransactionDate, 106) Date,TruckNo,SubHead, " +
                    " Rate,Qty,LoadingCharges Loading ,Tax,ChequeAmt Cheque, CashAmt Cash ,TransactionAmount Amount " +
                    " ,sum(TransactionAmount) over (order by SeqNo asc,TransactionDate asc,LedgerKey asc) as LedgerTotal " +
                    " from ( " +
                    " select -1 LedgerKey, 100 SeqNo, '' BuyerName, convert(date,@FromDate) TransactionDate, 'Opening Balance' SubHead, " +
                    " '' InvoiceNo,'' TruckNo,'' DispatchDateTime ,0.0 Rate, 0.0 Qty,0.0 ActualAmount,0.0 Tax,0.0 LoadingCharges " +
                    " , sum(TransactionAmount) TransactionAmount, 0.0 ChequeAmt , 0.0 CashAmt " +
                    " from vw_Party_Ledger where BuyerKey = @BuyerRk  and TransactionDate <  @FromDate "  +
                    " union ";


                strSQL1 = "  select LedgerKey,case SubHead when 'Customer Sale' then 300 else 200 end SeqNo,BuyerName,TransactionDate,SubHead, " +
                            " t2.InvoiceNo,t2.TruckNo,t2.DispatchDateTime ,t2.ActualRate Rate, t2.ActualQty Qty, t2.ActualAmount," +
                            " round(t2.TaxAmount, 0) Tax,t2.LoadingCharges, " +
                            " round(t1.TransactionAmount, 0) TransactionAmount , t2.ChequeAmt , t2.CashAmt " +
                            "  from vw_Party_Ledger t1  " +
                            " left outer join vw_Invoice_Details t2 on t1.Source = 'Invoice' and t1.SourceKey = t2.InvoiceKey " +
                            " where 1 = 1 " +
                            " and t1.TransactionDate >= @FromDate  and t1.TransactionDate <= @ToDate" + strsubHeadFilter  ;

                if (BuyerRk != AllSelectedVal)
                {
                    strSQL1 = strSQL1 + " and t1.BuyerKey = @BuyerRk " ;
                    //Params.Add("BuyerRk", BuyerRk.ToString());
                }

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} ,{"BuyerRk",BuyerRk.ToString()} };

                strSQL1 = strSQL1 + " union " + 
                    " select 999999 LedgerKey,500 SeqNo, '' BuyerName, convert(date,@ToDate) TransactionDate, 'Closing Balance' SubHead, " +
                    " '' InvoiceNo,'' TruckNo,'' DispatchDateTime ,0.0 Rate, 0.0 Qty,0.0 ActualAmount,0.0 Tax,0.0 LoadingCharges," +
                    " sum(TransactionAmount) TransactionAmount ,0.0 ChequeAmt , 0.0 CashAmt" +
                    " from vw_Party_Ledger where BuyerKey = @BuyerRk  and TransactionDate >  @ToDate " +
                 ") t1";
                strSQL = strSQL + strSQL1;
                //+  " order by BuyerName , TransactionDate asc,LedgerKey asc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }
        }


        //----------------------Vendor Reports

        public DataTable GetSupplierBillHistory()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                
                strSQL = "select BillKey , VendorName, BillNo ,Dated , Description," +
                         " TotalAmount,Remarks ,DateofEntry , EnteredBy,UpdatedOn,UpdatedBy" +
                         " from vw_vendor_bill_details where 1= 1 " +
                         " and ( ((DateofEntry) >= (@FromDate)  and (DateofEntry) <= (@ToDate)) or" +
                         "       ((Dated) >= (@FromDate)  and (Dated) <= (@ToDate))" +
                         "      )  ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (VendorRk != AllSelectedVal)
                {
                    strSQL = strSQL + " and VendorKey = @VendorRk ";
                    Params.Add("VendorRk", VendorRk.ToString());
                }

                strSQL = strSQL + "Order by BillKey desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public DataTable GetVendorOutstandingBalance()
        {
            try
            {
                DataTable Dt;
                string strSQL;

                strSQL = "select VendorName,LedgerBalance,LedgerStatus" +
                    " from vw_agg_vendor_ledger where 1 = 1";

                Dictionary<string, string> Params = new Dictionary<string, string>();
                if (VendorRk != AllSelectedVal && VendorRk > 0)
                {
                    strSQL = strSQL + " and VendorKey = @VendorRk";
                    Params.Add("VendorRk", VendorRk.ToString());
                }
                strSQL = strSQL + " order by VendorName";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable GetVendorLedgerHistory()
        {
            try
            {
                DataTable Dt;
                string strSql;
                

                strSql = "select LedgerKey,VendorName,TransactionDate,SubHead, TransactionAmount,Source,Action,Remarks , CreatedBy , CreatedOn" +
                    " from vw_vendor_Ledger where 1= 1 and " +
                     " TransactionDate >= @FromDate  and TransactionDate  <= @ToDate ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                if (VendorRk != AllSelectedVal)
                {
                    strSql = strSql + " and VendorKey= @VendorKey ";
                    Params.Add("VendorKey", VendorRk.ToString());
                }
                strSql = strSql + " order by VendorName , LedgerKey Desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public DataTable GetVendorLedgerHistoryNew()
        {
            try
            {
                DataTable Dt;
                string strSql;
                string strVendorSql;
                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };

                strVendorSql = "";
                if (VendorRk != AllSelectedVal)
                {
                    strVendorSql = " and VendorKey= @VendorKey ";
                    Params.Add("VendorKey", VendorRk.ToString());
                }

                strSql = "select LedgerKey,VendorName, CONVERT(char(15),TransactionDate, 106) Date, SubHead," +
                        " TransactionAmount,sum(TransactionAmount) over(order by SeqNo ,VendorName, TransactionDate asc, ledgerkey asc) " +
                         " as LedgerTotal,Source,Action,Remarks , CreatedBy , CreatedOn from ( ";

                strSql = strSql + "select 0 SeqNo,-1 LedgerKey,VendorName,@FromDate TransactionDate,'Opening Balance' SubHead, " +
                                " sum(TransactionAmount) TransactionAmount ,'' Source, '' Action, '' Remarks , '' CreatedBy , '' CreatedOn" +
                                " from vw_vendor_Ledger where 1= 1 and " +
                                    " TransactionDate < @FromDate  "  + strVendorSql  + " group by VendorName  union ";

                strSql = strSql  + "select 1 SeqNo, LedgerKey,VendorName,TransactionDate,SubHead, TransactionAmount,Source,Action,Remarks , CreatedBy , CreatedOn" +
                    " from vw_vendor_Ledger where 1= 1 and " +
                     " TransactionDate >= @FromDate  and TransactionDate  <= @ToDate " + strVendorSql;

                strSql = strSql + ") t1";
                //strSql = strSql + " order by VendorName , LedgerKey Desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        ////Cash Ledger Reports


        public DataTable GetCashBalanceHistory()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                strSQL = "select LedgerKey,EntityName,Remarks,SubHead,TransactionAmount,TransactionDate,Source,Action,CreatedBy,CreatedOn" +
                        " from vw_Cash_Ledger where 1 = 1 " +
                        " and TransactionDate >= @FromDate  and TransactionDate <= @ToDate ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "FromDate", FromDate },{ "ToDate", ToDate} };


                if (SubHead != AllSelectedValtext)
                {
                    strSQL = strSQL + " and SubHead = @SubHead";
                    Params.Add("SubHead", SubHead);
                }
                strSQL = strSQL + " order by SubHead , LedgerKey desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public DataTable GetCashInHandDetails()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                strSQL = "select * from vw_agg_Cash_Ledger";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        // get daily Report


        public DataTable GetDailyReport()
        {
            try
            {
                DataTable Dt;
                string strSQL;
                strSQL = "select 0 SeqNo,REC_DESC MainHead , Description Details , Sub_Desc SubHead , Ledger_amt CreditAmount , 0 DebitAmount " +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('OB')and  tran_date = @DailyDate " +
                    " union" +
                    " select 10 SeqNo,REC_DESC MainHead , 'Cash Sale' Details , Sub_Desc SubHead , sum(Ledger_amt) CreditAmount , 0 DebitAmount " +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('AR') and  tran_date = @DailyDate and rec_desc = 'Invoice' " +
                    " group by rec_desc ,Sub_Desc " +
                    " union" +
                    " select 20 SeqNo,REC_DESC MainHead , Description Details , Sub_Desc SubHead , Ledger_amt CreditAmount , 0 DebitAmount " +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('AR')and  tran_date = @DailyDate and rec_desc <> 'Invoice' " +
                    " union" +
                    " select 30 SeqNo, REC_DESC MainHead , Description Details, Sub_Desc SubHead , 0 CreditAmount , round(Ledger_amt,0) DebitAmount" +
                    " from vw_daily_details " +
                    " where REC_TYPE in ('AP') and tran_date = @DailyDate" +
                    " union" +
                    " select 40 SeqNo,'' MainHead , ''  Details , 'Total Credit' SubHead , 0 CreditAmount, round(Ledger_amt,0) DebitAmount" +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('TAR') and tran_date = @DailyDate " +
                    " union" +
                    " select 50 SeqNo,'' MainHead , ''  Details , 'Total Debit' Sub_Desc  , 0 CreditAmount,  round(Ledger_amt,0) DebitAmount" +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('TAP')and tran_date = @DailyDate" +
                    " union " +
                    " select 60 SeqNo,'' MainHead , ''  Details , 'Closing Balance' Sub_Desc  , 0 CreditAmount,  round(Ledger_amt,0)DebitAmount" +
                    " from vw_daily_details" +
                    " where REC_TYPE in ('CB')and tran_date = @DailyDate" +
                    " order by 1 , MainHead , Details ";

                Dictionary<string, string> Params = new Dictionary<string, string>()
                { { "DailyDate", DailyDate }};

                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSQL, Params);
                return Dt;

            }
            catch (Exception e)
            {
                throw e;

            }

        }


        /// Stock Status
        /// 

        public DataTable StockStatus()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select FGStockName,Dated,OriginalStockName,TranHead,Quantity ,Amount ,AverageRate " +
                        " from agg_stock_ledger where 1= 1 " +
                        " and Dated >= @FromDate  and Dated <= @ToDate ";

                Params.Clear();
                Params.Add("FromDate", FromDate);
                Params.Add("ToDate", ToDate);

                if (ItemRk != AllSelectedVal)
                {
                    strSql = strSql + " and FGItemKey = @ItemRk ";
                    Params.Add("ItemRk", ItemRk.ToString());
                }
                strSql = strSql + " order by Dated Desc";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }



        }

        public DataTable StockInHand()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select PurchaseDate,FGStockName,PurchaseQty,AverageRate,PurchaseAmount,StockInHand,StockValuation " +
                        " from vw_stock_summary where 1= 1 and PurchaseDate>= @FromDate  and PurchaseDate <= @ToDate ";
                Params.Add("FromDate", FromDate);
                Params.Add("ToDate", ToDate);
                if (ItemRk != AllSelectedVal)
                {
                    strSql = strSql + " and FGItemKey = @ItemRk ";
                    Params.Add("ItemRk", ItemRk.ToString());
                }
                strSql = strSql + " order by PurchaseDate desc ";
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public string ComputeStock()
        {
            string strReturn;
            string ProcessName = "ComputeStock  ";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            string strProcName = "PR_PROCESS_STOCK";
            try
            {

                Params.Add("MODE", "SALE");
                Params.Add("CREATED_BY", Global.gUserID);
                

                strReturn = objFactory.SqlServerStoredProcExecuteNonQuery(strProcName, Params, "MSG_OUT");

                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public DataTable AveragePurchase()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select sum(PurchaseAmount) PurchaseAmount , sum(PurchaseQty) PurchaseQty ,case sum(PurchaseQty) when 0 then 0 else sum(PurchaseAmount) / sum(PurchaseQty) end  PurchaseAverage " +
                        " ,sum(StockInHand) StockInHand, case sum(StockInHand) when 0 then 0 else sum(AverageRate * StockInHand) / sum(StockInHand) end StockInHandAverage from vw_stock_summary where 1 = 1 and PurchaseDate>= @FromDate  and PurchaseDate <= @ToDate ";
                Params.Add("FromDate", FromDate);
                Params.Add("ToDate", ToDate);
                if (ItemRk != AllSelectedVal)
                {
                    strSql = strSql + " and FGItemKey = @ItemRk ";
                    Params.Add("ItemRk", ItemRk.ToString());
                }
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public DataTable AverageSale()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select sum(ActualAmount) SaleAmount, Sum(SaleQty) SaleQty , sum(ActualAmount) / sum(SaleQty) SaleAvg,sum(Commission) / sum(SaleQty) CommisionAvg," +
                        " ((sum(ActualAmount) / sum(SaleQty)) - sum(Commission) / sum(SaleQty)) NetSaleAvg " +
                        " from vw_agg_Sale where 1 = 1 and Dated >= @FromDate  and Dated <= @ToDate ";
                Params.Add("FromDate", FromDate);
                Params.Add("ToDate", ToDate);
                if (ItemRk != AllSelectedVal)
                {
                    strSql = strSql + " and ItemRk = @ItemRk ";
                    Params.Add("ItemRk", ItemRk.ToString());
                }
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        public string ComputePartyLedger()
        {
            string strReturn;
            string ProcessName = "ComputeStock  ";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            string strProcName = "PR_PARTY_LEDGER_ADJUSTMENT_ALL";
            try
            {

                
                strReturn = objFactory.SqlServerStoredProcExecuteNonQuery(strProcName, Params, "MSG_OUT");

                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }
        }

    }
}
