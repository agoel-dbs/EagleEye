using EagleEye.Lib;
using System;
using System.Collections.Generic;

namespace EagleEye.DBLayer
{
    class StockVariance
    {


        public int VarianceRk { get; set; }
        public string VarianceType { get; set; }
        public string VarianceDate { get; set; }
        public int ItemRk { get; set; } = -1;
        public decimal ItemQty { get; set; } = 0;
        public decimal ItemRate { get; set; } = 0;
        public decimal BillAmount { get; set; } = 0;
        public string Remarks { get; set; } = "";

        // Item Realted Propoerties

        
        public string CreatedBy { get; set; } = Global.gUserID;
        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public string PostStockVariance()
        {
            string strReturn;
            string strMsg;
            string TransactionSubHead = "Positive Variance";
            string ProcessName = "PostStockVariance";

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



                strSql = "insert into stock_variance_header " +
                                  "(var_type,var_date,item_rk  ,item_qty ,item_rate,total_bill_amount,remarks," +
                                  "created_by,updated_by  ) " +
                                  " Values (@VarianceType,@VarianceDate,@ItemRk,@ItemQty ,@ItemRate,@BillAmount," +
                                  " @Remarks,@CreatedBy,@CreatedBy)";

                Params.Add("VarianceType", VarianceType);
                Params.Add("VarianceDate", VarianceDate);
                Params.Add("ItemRk", ItemRk.ToString());
                Params.Add("ItemQty", ItemQty.ToString());
                Params.Add("ItemRate", ItemRate.ToString());
                Params.Add("BillAmount", BillAmount.ToString());
                Params.Add("Remarks", Remarks);
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // get bill_rk
                strSql = "select max(variance_rk) as id from stock_variance_header";
                Params.Clear();
                VarianceRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                
                // Post Stock Entry in case itemqty is > 0

                    int LedgerItemRk;
                    decimal FGConversionRatio;
                    strSql = "select fg_item_rk from item_master where item_rk = " + ItemRk;
                    LedgerItemRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                    strSql = "select fg_conversion_ratio from item_master where item_rk = " + ItemRk;
                    FGConversionRatio = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                    // -- ve variance will reduce the stock

                    if (VarianceType == "NEG_VAR")
                    {
                        ItemQty = ItemQty * -1;
                    TransactionSubHead = "Negative Variance";
                    }

                    StockLedger objStockLedger = new StockLedger();
                    objStockLedger.ItemRk = ItemRk;
                    objStockLedger.LedgerItemRk = LedgerItemRk;
                    objStockLedger.FGConversionRatio = FGConversionRatio;
                    objStockLedger.BuyerRk = -1;
                    objStockLedger.VendorRk = -1;
                    objStockLedger.TransactionHead = "VARIANCE";
                    objStockLedger.TransactionSubHead = TransactionSubHead;
                    objStockLedger.TranDate = VarianceDate;
                    objStockLedger.ItemRate = ItemRate;
                    objStockLedger.TranQty = ItemQty;
                    objStockLedger.LedgerQty = ItemQty * FGConversionRatio;  // ledger qty is of FG (RM to FG conversion ratio)
                    objStockLedger.TranAmount = BillAmount;
                    objStockLedger.LedgerAmount = BillAmount * -1;
                    objStockLedger.TranSource = "Stock Variance";
                    objStockLedger.SourceRK = VarianceRk;
                    objStockLedger.Remarks = Remarks;
                    objStockLedger.EventDetails = "Variance Bill Entry";
                    objStockLedger.CreatedBy = CreatedBy;
                    objStockLedger.bTransactionBound = true;
                    strReturn = objStockLedger.PostStockLedgerEntry();
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
                strReturn = logicalOK + "Variance posted sucessfully!!! ";
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }
        }


    }
}
