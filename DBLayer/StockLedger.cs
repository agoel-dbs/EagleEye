using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.DBLayer
{
    class StockLedger
    {
        public int ItemRk { get; set; }

        public int LedgerItemRk { get; set; } = -1;

        public decimal FGConversionRatio { get; set; } = 0;
        public int BuyerRk { get; set; }
        public int VendorRk { get; set; }

        public string TransactionHead { get; set; }
        public string TransactionSubHead { get; set; }

        public string TranDate { get; set; }

        public decimal ItemRate { get; set; }

        public decimal TranQty { get; set; }
        public decimal LedgerQty { get; set; }
        public decimal TranAmount { get; set; }
        public decimal LedgerAmount { get; set; }

        public string TranSource { get; set; }
        public int SourceRK { get; set; }
        public string EventDetails { get; set; }

        public string Remarks { get; set; }

        public string CreatedBy { get; set; }
        //public SQLiteConnection TransactionConn;
        public bool bTransactionBound = false;

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";




        public string PostStockLedgerEntry()
        {
            string strReturn;

            DbConnectionFactory objFactory = new DbConnectionFactory();
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            string strSql;
            string ProcessName = "PostStockLedgerEntry";
            try
            {

                strSql = " insert into stock_ledger" +
                        "(item_rk,ledger_item_rk,fg_conversion_ratio, buyer_rk, vendor_rk, tran_head, tran_sub_head, tran_date,item_rate, tran_qty, " +
                        "ledger_qty, tran_amt, ledger_amt, tran_source, source_rk, " +
                        "event_detail, remarks, created_by) " +
                        " values " +
                        " (@ItemRk,@LedgerItemRk,@FGConversionRatio, @BuyerRk ,@VendorRk,@TransactionHead,@TransactionSubHead,@TranDate,@ItemRate,@TranQty," +
                        " @LedgerQty ,@TranAmount,@LedgerAmount,@TranSource,@SourceRK" +
                        ",@EventDetails,@Remarks,@CreatedBy)";

                Params.Add("ItemRk", ItemRk.ToString());
                Params.Add("LedgerItemRk", LedgerItemRk.ToString());
                Params.Add("FGConversionRatio", FGConversionRatio.ToString());
                Params.Add("BuyerRk", BuyerRk.ToString());
                Params.Add("VendorRk", VendorRk.ToString());
                Params.Add("TransactionHead", TransactionHead);
                Params.Add("TransactionSubHead", TransactionSubHead);
                Params.Add("TranDate", TranDate);
                Params.Add("ItemRate", ItemRate.ToString());
                Params.Add("TranQty", TranQty.ToString());
                Params.Add("LedgerQty", LedgerQty.ToString());
                Params.Add("TranAmount", TranAmount.ToString());
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
                    objFactory.TransExecuteNonQuery(strSql, Params);
                }

                strReturn = logicalOK + "Stock Ledger Entry Created";
                return strReturn;

            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;
            }

        }
     }
}
