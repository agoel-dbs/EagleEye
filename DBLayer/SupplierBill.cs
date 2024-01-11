using EagleEye.Lib;
using System;
using System.Collections.Generic;

namespace EagleEye.DBLayer
{
    class SupplierBill
    {

        public int BillRk { get; set; } = -1;
        public  int VendorRk { get; set; } = -1;
        public int HeadRk { get; set; } = -1;
        public string   HeadDesc { get; set; } = "";
        public string BillNo { get; set; } = "";
        public string BillDate { get; set; }
        public decimal BillAmount { get; set; } = 0;
        public decimal CGST { get; set; } = 0;
        public decimal SGST { get; set; } = 0;
        public decimal IGST { get; set; } = 0;
        public string BillDetails { get; set; } = "";
        public string Remarks { get; set; } = "";

        // Item Realted Propoerties

        public int ItemRk { get; set; } = -1;
        public decimal ItemQty { get; set; } = 0;

        public decimal ItemRate { get; set; } = 0;

        public string CreatedBy { get; set; } = Global.gUserID;
        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public string PostSupplierBill()
        {
            string strReturn;
            string strMsg;
            string ProcessName = "PostSupplierBill";

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



                strSql = "insert into vendor_bill_header " +
                                  "(vendor_rk,expense_rk,bill_no,bill_date,total_bill_amount,igst_amt,cgst_amt,sgst_amt,bill_desc," +
                                  "item_rk,item_qty,item_rate," +
                                  "remarks,created_by,updated_by ) " +
                                  " Values (@VendorRk ,@Head,@BillNo,@BillDate,@BillAmount,@CGST,@SGST,@IGST,@BillDetails," +
                                  "@ItemRk,@ItemQty,@ItemRate," +
                                  " @Remarks,@CreatedBy,@CreatedBy)";

                Params.Add("VendorRk", VendorRk.ToString());
                Params.Add("Head", HeadRk.ToString());
                Params.Add("BillNo", BillNo);
                Params.Add("BillDate", BillDate.ToString());
                Params.Add("BillAmount", BillAmount.ToString());
                Params.Add("CGST", CGST.ToString());
                Params.Add("SGST", SGST.ToString());
                Params.Add("IGST", IGST.ToString());
                Params.Add("BillDetails", BillDetails);
                Params.Add("ItemRk", ItemRk.ToString());
                Params.Add("ItemQty", ItemQty.ToString());
                Params.Add("ItemRate", ItemRate.ToString());
                Params.Add("Remarks", Remarks);
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql,Params);

                // get bill_rk
                strSql= "select max(bill_rk) as id from vendor_bill_header";
                Params.Clear();
                BillRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql,Params));

                //// insert data into party ledger account one for Purchae

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.VendorRk = VendorRk;
                objLedger.TranAmount = BillAmount;
                objLedger.TranDate = BillDate.ToString();
                objLedger.TranSource = "Vendor Purchase";
                objLedger.TransactionSubHead = HeadDesc;
                objLedger.SourceRK = BillRk;
                objLedger.Remarks = "Bill No:" + BillNo; // supplier Bill no
                objLedger.EventDetails = "Vendor Bill Created";
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostSupplierBillEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();
                    objFactory.TransCloseConnection();
                    return strReturn;
                }

                // Post Stock Entry in case itemqty is > 0

                if (ItemRk > -1 && ItemQty > 0 )
                {
                    int LedgerItemRk;
                    decimal FGConversionRatio;
                    strSql = "select fg_item_rk from item_master where item_rk = " + ItemRk;
                    LedgerItemRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                    strSql = "select fg_conversion_ratio from item_master where item_rk = " + ItemRk;
                    FGConversionRatio = commonLib.fnCheckDecimal( objFactory.TransExecuteScalerQuery(strSql, Params) );

                    StockLedger objStockLedger = new StockLedger();
                    objStockLedger.ItemRk= ItemRk;
                    objStockLedger.LedgerItemRk = LedgerItemRk;
                    objStockLedger.FGConversionRatio = FGConversionRatio;
                    objStockLedger.BuyerRk= -1;
                    objStockLedger.VendorRk = VendorRk;
                    objStockLedger.TransactionHead = "PURCHASE";
                    objStockLedger.TransactionSubHead = HeadDesc;
                    objStockLedger.TranDate = BillDate.ToString();
                    objStockLedger.ItemRate = ItemRate;
                    objStockLedger.TranQty = ItemQty;
                    objStockLedger.LedgerQty = ItemQty * FGConversionRatio;  // ledger qty is of FG (RM to FG conversion ratio)
                    objStockLedger.TranAmount = BillAmount;
                    objStockLedger.LedgerAmount= BillAmount * -1;
                    objStockLedger.TranSource = "Vendor Purchase";
                    objStockLedger.SourceRK = BillRk;
                    objStockLedger.Remarks = "Bill No:" + BillNo; // supplier Bill no
                    objStockLedger.EventDetails = "Vendor Bill Entry";
                    objStockLedger.CreatedBy = CreatedBy;
                    objStockLedger.bTransactionBound = true;
                    strReturn = objStockLedger.PostStockLedgerEntry();
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
                strReturn = logicalOK + "Supplier Bill posted sucessfully!!! ";
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
