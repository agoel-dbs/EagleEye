using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace EagleEye.DBLayer
{
    class InvoiceDetails
    {

        // expense Details
        public string UserId { get; set; }

        public string ExpenseGroup { get; set; }

        // invoice Details

        public int InvoiceNo { get; set; }

        public string InvoiceNoList { get; set; } = "-";

        public int InvoiceRk { get; set; }
        public string InvoiceNoVisible { get; set; } = "";
        public DateTime InvoiceDate { get; set; }
        public string DispatchDateTime { get; set; } = "";
        public string RavannaNo { get; set; } = "";
        public string TruckNo { get; set; } = "";

        public string SellerName { get; set; } = "";
        public string SellerAdd1 { get; set; } = "";
        public string SellerAdd2 { get; set; } = "";
        public string SellerAdd3 { get; set; } = "";
        public string SellerGSTIN { get; set; } = "";
        public string BuyerName { get; set; } = "";
        public string BuyerAdd1 { get; set; } = "";
        public string BuyerAdd2 { get; set; } = "";
        public string BuyerAdd3 { get; set; } = "";
        public string BuyerGSTIN { get; set; } = "";
        public string ItemDesc { get; set; } = "";

        public int ItemRK { get; set; } = -1;
        public string HSNCode { get; set; } = "";
        public decimal ItemQty { get; set; } = 0;
        public decimal ItemRate { get; set; } = 0;
        public decimal ItemAmt { get; set; } = 0;
        public decimal CGSTPer { get; set; } = 0;
        public decimal CGSTAmt { get; set; } = 0;
        public decimal SGSTPer { get; set; } = 0;
        public decimal SGSTAmt { get; set; } = 0;
        public decimal IGSTPer { get; set; } = 0;
        public decimal IGSTAmt { get; set; } = 0;
        public decimal TotalInvAmt { get; set; } = 0;
        public string TotalAmtWords { get; set; } = "";
        public string BankName { get; set; } = "";
        public string BankAccountNo { get; set; } = "";
        public string IfscCode { get; set; } = "";
        public string BankAdd1 { get; set; } = "";
        public string BankAdd2 { get; set; } = "";
        public string CertifyClause { get; set; } = "";
        public string GeneralInstruction { get; set; } = "";
        public decimal ActualItemQty { get; set; } = 0;
        public decimal ActualItemRate { get; set; } = 0;
        public decimal ActualItemAmt { get; set; } = 0;
        public decimal OtherInwardExpense { get; set; } = 0;
        public decimal OtherOutwardExpense { get; set; } = 0;
        public decimal TotalAmtPayable { get; set; } = 0;
        public decimal TotalAmtCollected { get; set; } = 0;
        public decimal AmountReceived { get; set; } = 0;
        public string Status { get; set; } = "";
        public string Remark { get; set; } = "";
        public int IsActive { get; set; }
        public string CheckDuplicateRavanna { get; set; } = "Y";
        public string InvoiceSource { get; set; } = "";
        public string CreatedBy { get; set; } = Global.gUserID;

        public int ActualBuyerRk { get; set; } = -1;


        // invoice changes
        public int NewBuyerRk { get; set; } = -1;
        public int InvoiceModified { get; set; } = 0;

        public string CheckDuplicateInvoiceNo = "Y";



        private string RavaanaInvoiceID = "Ravaana";
        private int PaidByDifferentBuyer = 0;

        // TAXABLE iNVOICE 

        public int TaxableInvoice { get; set; } = 1;

        public string UOM { get; set; } = "MT";

        public decimal SlipItemRate { get; set; } = 0;

        public decimal SlipItemQty { get; set; } = 0;



        // Invoice Cancel

        public string CancellationReason { get; set; }

        private string AllSelectedValtext = "-99";



        // change invoice sale rate & weight


        public decimal SaleRate { get; set; } = 0;
        public decimal SaleQuantity { get; set; } = 0;



        public bool AddFlag { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";








        public DataTable GetExpenseDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select expense_rk ExpenseKey , expense_key ExpenseID ," +
                            "expense_desc Expense , Default_value  Value, " +
                          "  exp_impact Type, 0.0  TotalExpense , user_editable Editable " +
                          " from expense_master where is_active = 1 and exp_group = @ExpenseGroup";

                Params.Add("ExpenseGroup", ExpenseGroup);
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }


        // Invoice Entry Method

        public string GenerateInvoice()
        {
            string strReturn;
            string strMsg;
            int ItemRk;
            int BuyerRk;
            int InvoiceRk;
            string Remarks;
            string strSql;
            string strInvoiceDate;
            int pos = 0;

            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            objFactory.TransCommand();
            // Start a local transaction
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            
            try
            {

                // CLEANSE TRUCK NO 

                pos = TruckNo.IndexOf("(");
                if (pos > 0)
                {
                    TruckNo = TruckNo.Substring(0, pos);
                    TruckNo = TruckNo.Replace("(", "").Trim();
                }



                // Check if Duplicate Ravanna needs to be checked if yes then return false for Duplicate ravanna
                if (CheckDuplicateRavanna == "Y")
                {
                    strSql = "select " + Global.gIsNull + "(max(invoice_no),-1) from vw_invoice_header where ravanna_no= @RavannaNo";
                    Params.Add("RavannaNo", RavannaNo);
                    strReturn = objFactory.TransExecuteScalerQuery(strSql, Params);

                    if (strReturn != "-1")
                    {
                        strReturn = logicalError + "Ravana has been processed and Invoice No " + strReturn + " has been generated , please load new Ravanaa !!! ";
                        objFactory.TransRollback();
                        return strReturn;
                    }
                }

                // check if Invoice No already eists in system

                if (CheckDuplicateInvoiceNo == "Y")
                {
                    strSql = "select " + Global.gIsNull + "(max(invoice_no),-1) from vw_invoice_header where invoice_no= @InvoiceNo";

                    Params.Clear();
                    Params.Add("InvoiceNo", InvoiceNo.ToString());
                    strReturn = objFactory.TransExecuteScalerQuery(strSql, Params);

                    if (strReturn != "-1")
                    {
                        strReturn = logicalError + "Invoice No " + strReturn + " already exists, Change the invoice no and try again";
                        objFactory.TransRollback();
                        return strReturn;
                    }
                }

                // insert data in buyer_master
                BuyerRk = -1;
                
                if (@BuyerGSTIN.ToUpper().Length > 2)
                {

                    strSql = "select " + Global.gIsNull + "(max(buyer_rk),-1) from buyer_master " +
                                       "where upper(GSTIN_NO) = upper(@BuyerGSTIN) " +
                                       " and " + Global.gLength + " (GSTIN_NO) > 8 and GSTIN_NO <>'' ";

                    Params.Clear();
                    Params.Add("BuyerGSTIN", BuyerGSTIN);
                    BuyerRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));
                }

                // get buyer_rk based on Byer Name

                if (BuyerRk == -1)
                {
                    strSql = "select " + Global.gIsNull + "(max(buyer_rk),-1) from buyer_master " +
                                       "where upper(name)=upper(@BuyerName) ";
                
                    Params.Clear();
                    Params.Add("BuyerName", BuyerName);
                    BuyerRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));
                }
                //BuyerRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                //strSql = "select " + Global.gIsNull + "(max(buyer_rk),-1) from buyer_master " +
                //                   "where (upper(name)=upper(@BuyerName)) or  (upper(GSTIN_NO) = upper(@BuyerGSTIN) " +
                //                   " and " + Global.gLength + " (GSTIN_NO) > 8 and GSTIN_NO <>'')  ";

                //Params.Clear();
                //Params.Add("BuyerName", BuyerName);
                //Params.Add("BuyerGSTIN", BuyerGSTIN);

                //BuyerRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                // record not found make an entry
                if (BuyerRk == -1)
                {

                    strSql = "insert into buyer_master(name,add1,gstin_no,created_by,updated_by) values" +
                                   "(upper(@BuyerName), @BuyerAdd1,@BuyerGSTIN,@CreatedBy,@CreatedBy)";

                    Params.Clear();
                    Params.Add("BuyerName", BuyerName.ToUpper());
                    Params.Add("BuyerAdd1", BuyerAdd1);
                    Params.Add("BuyerGSTIN", BuyerGSTIN.ToUpper());
                    Params.Add("CreatedBy", CreatedBy);

                    objFactory.TransExecuteNonQuery(strSql, Params);

                    // get buyer rk
                    //strSql = "select last_insert_rowid() as id from buyer_master";

                    //strSql = "select "  + Global.gLastInsertedRowId;

                    strSql = "select max(buyer_rk) from buyer_master";
                    BuyerRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));
                }


                // if payment is made by different buyer then change the buyer of invoice

                if (ActualBuyerRk > 0)
                {
                    BuyerRk = ActualBuyerRk;
                    PaidByDifferentBuyer = 1;
                }


                // insert data in item_master

                strSql = "select " + Global.gIsNull + "(max(item_rk),-1) from item_master " +
                                   "where upper(item_desc) = upper(@ItemDesc)";

                Params.Clear();
                Params.Add("ItemDesc", ItemDesc);

                ItemRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));
                // record not found make an entry
                if (ItemRk == -1)
                {
                    strSql = "insert into item_master" +
                                "(item_desc,uom,item_category,tran_type," +
                                "hsn_code,cgst_per,sgst_per,igst_per,created_by,updated_by) values" +
                                   "(@ItemDesc,'MT','FG', 'SALE'," +
                                   "'2517',2.5,2.5,5.0,@CreatedBy,@CreatedBy)";
                    Params.Clear();
                    Params.Add("ItemDesc", ItemDesc);
                    Params.Add("CreatedBy", CreatedBy);
                    objFactory.TransExecuteNonQuery(strSql, Params);

                    // get Item_rk
                    //strSql = "select last_insert_rowid() as id from item_master";

                    //strSql = "select " + Global.gLastInsertedRowId;

                    strSql = "select max(item_rk) from item_master";
                    ItemRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));

                }

                // get UOM of Item

                strSql = "select UOM from item_master where item_rk = @ItemRk ";
                Params.Clear();
                Params.Add("ItemRk", ItemRk.ToString());
                UOM = (objFactory.TransExecuteScalerQuery(strSql, Params));

                // make insert statment
                strInvoiceDate = commonLib.ConvertTranDateFormat(InvoiceDate);
                strSql = "insert into invoice_header" +
                                    "(invoice_no,invoice_no_visible,invoice_date,dispatch_date_time,ravanna_no,truck_no,seller_name,seller_add1," +
                                    " seller_add2,seller_add3,seller_gstin,buyer_rk,buyer_name,buyer_add1,buyer_add2,buyer_add3,buyer_gstin," +
                                    " item_rk,item_desc,hsn_code,item_qty,item_rate,item_amt,cgst_per,cgst_amt,sgst_per,sgst_amt,igst_per,igst_amt," +
                                   " total_inv_amt,total_amt_words,bank_name,bank_account_no,ifsc_code,bank_add1,bank_add2,certify_clause," +
                                    " general_instruction,actual_item_qty,actual_item_rate,actual_item_amt,other_inward_expense,other_outward_expense," +
                                    " total_amt_payable,total_amt_to_be_collected,amount_received,inv_source,created_By,updated_By,paid_by_different_buyer " +
                                    " ,remarks,is_tax_invoice,uom,slip_item_rate,slip_item_qty) " +
                                    " values (" +
                                    "@InvoiceNo,@InvoiceNoVisible,@InvoiceDate,@DispatchDateTime,@RavannaNo,@TruckNo,@SellerName,@SellerAdd1," +
                                    "@SellerAdd2,@SellerAdd3,@SellerGstin,@BuyerRk,@BuyerName,@BuyerAdd1,@BuyerAdd2,@BuyerAdd3,@BuyerGSTIN," +
                                    " @ItemRk,@ItemDesc,@HsnCode,@ItemQty,@ItemRate,@ItemAmt,@CgstPer,@CgstAmt,@SgstPer,@SgstAmt,@IgstPer,@IgstAmt," +
                                    " @TotalInvAmt,@TotalAmtWords,@BankName,@BankAccountNo,@IfscCode,@BankAdd1,@BankAdd2,@CertifyClause, " +
                                    "@GeneralInstruction,@ActualItemQty,@ActualItemRate,@ActualItmeAmt,@OtherInwardExpense,@OtherOutwardExpense," +
                                    "@TotalAmtPayable,@TotalAmtToBeCollected,@AmountReceived,@InvoiceSource,@CreatedBy,@CreatedBy" +
                                    ",@PaidByDifferentBuyer,@Remarks,@TaxableInvoice,@UOM,@SlipItemRate,@slipItemQty)";


                if (SlipItemRate == 0)
                {

                    SlipItemRate = ActualItemRate;
                }

                
                Params.Clear();
                Params.Add("InvoiceNo", InvoiceNo.ToString());
                Params.Add("InvoiceNoVisible", InvoiceNoVisible);
                Params.Add("InvoiceDate", strInvoiceDate); 
                Params.Add("DispatchDateTime", DispatchDateTime);
                Params.Add("RavannaNo", RavannaNo);
                Params.Add("TruckNo", TruckNo);
                Params.Add("SellerName", SellerName);
                Params.Add("SellerAdd1", SellerAdd1);
                Params.Add("SellerAdd2", SellerAdd2);
                Params.Add("SellerAdd3", SellerAdd3);
                Params.Add("SellerGstin", SellerGSTIN);
                Params.Add("BuyerRk", BuyerRk.ToString());
                Params.Add("BuyerName", BuyerName);
                Params.Add("BuyerAdd1", BuyerAdd1);
                Params.Add("BuyerAdd2", BuyerAdd2);
                Params.Add("BuyerAdd3", BuyerAdd3);
                Params.Add("BuyerGSTIN", BuyerGSTIN);
                Params.Add("ItemRk", ItemRk.ToString());
                Params.Add("ItemDesc", ItemDesc);
                Params.Add("HsnCode", HSNCode);
                Params.Add("ItemQty", ItemQty.ToString());
                Params.Add("ItemRate", ItemRate.ToString());
                Params.Add("ItemAmt", ItemAmt.ToString());
                Params.Add("CgstPer", CGSTPer.ToString());
                Params.Add("CgstAmt", CGSTAmt.ToString());
                Params.Add("SgstPer", SGSTPer.ToString());
                Params.Add("SgstAmt", SGSTAmt.ToString());
                Params.Add("IgstPer", IGSTPer.ToString());
                Params.Add("IgstAmt", IGSTAmt.ToString());
                Params.Add("TotalInvAmt", TotalInvAmt.ToString());
                Params.Add("TotalAmtWords", TotalAmtWords);
                Params.Add("BankName", BankName);
                Params.Add("BankAccountNo", BankAccountNo);
                Params.Add("IfscCode", IfscCode);
                Params.Add("BankAdd1", BankAdd1);
                Params.Add("BankAdd2", BankAdd2);
                Params.Add("CertifyClause", CertifyClause);
                Params.Add("GeneralInstruction", GeneralInstruction);
                Params.Add("ActualItemQty", ActualItemQty.ToString());
                Params.Add("ActualItemRate", ActualItemRate.ToString());
                Params.Add("ActualItmeAmt", ActualItemAmt.ToString());
                Params.Add("OtherInwardExpense", OtherInwardExpense.ToString());
                Params.Add("OtherOutwardExpense", OtherOutwardExpense.ToString());
                Params.Add("TotalAmtPayable", TotalAmtPayable.ToString());
                Params.Add("TotalAmtToBeCollected", TotalAmtCollected.ToString());
                Params.Add("AmountReceived", AmountReceived.ToString());
                Params.Add("InvoiceSource", InvoiceSource.ToString());
                Params.Add("Status", Status);
                Params.Add("CreatedBy", CreatedBy);
                Params.Add("PaidByDifferentBuyer", PaidByDifferentBuyer.ToString());
                Params.Add("Remarks", Remark);
                Params.Add("TaxableInvoice", TaxableInvoice.ToString());
                Params.Add("uom", UOM);
                Params.Add("SlipItemRate", SlipItemRate.ToString());
                Params.Add("slipItemQty", SlipItemQty.ToString());

                objFactory.TransExecuteNonQuery(strSql, Params);

                // get Invoice_rk
                //strSql = "select last_insert_rowid() as id from invoice_header";
                //strSql = "select IDENT_CURRENT('Invoice_header')";

                strSql = "select  max(invoice_rk) from invoice_header";

                
                Params.Clear();
                InvoiceRk = commonLib.fnCheckNull(objFactory.TransExecuteScalerQuery(strSql, Params));
                Global.gInvoiceRk = InvoiceRk;

                //// insert data into party ledger account one for Sale

                CompanyLedger objLedger = new CompanyLedger();
                objLedger.BuyerRk = BuyerRk;
                objLedger.TranAmount = TotalAmtPayable;
                objLedger.TranDate = strInvoiceDate;
                objLedger.TranSource = "Invoice";
                objLedger.SourceRK = InvoiceRk;
                objLedger.Remarks = InvoiceNoVisible;
                objLedger.EventDetails = InvoiceSource +  " Invoice Created";
                objLedger.CreatedBy = CreatedBy;
                objLedger.bTransactionBound= true;
                strReturn = objLedger.PostInvoiceEntry();

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();
                    return strReturn;
                }

                //// Commision Entry (OutWord)

                if (OtherOutwardExpense > 0)
                {
                    objLedger.BuyerRk = -1;
                    objLedger.TranAmount = OtherOutwardExpense;
                    objLedger.TransactionSubHead = "Service Payment";
                    objLedger.TranDate = strInvoiceDate;
                    objLedger.TranSource = "Invoice";
                    objLedger.SourceRK = InvoiceRk;
                    objLedger.Remarks = InvoiceNoVisible;
                    objLedger.EventDetails = "Driver Commision";
                    objLedger.CreatedBy = CreatedBy;
                    objLedger.bTransactionBound= true;
                    strReturn = objLedger.PostPaymentMadeEntry();

                    InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback();
                        return strReturn;
                    }

                }

                if (AmountReceived > 0)
                {
                    objLedger.BuyerRk = BuyerRk;
                    objLedger.TranAmount = AmountReceived;
                    objLedger.TranDate = strInvoiceDate;
                    objLedger.TranSource = "Invoice";
                    objLedger.TransactionSubHead = "Customer Payment";
                    objLedger.SourceRK = InvoiceRk;
                    objLedger.Remarks = InvoiceNoVisible;
                    objLedger.EventDetails = InvoiceSource + " Payment Received";
                    objLedger.CreatedBy = CreatedBy;
                    objLedger.bTransactionBound= true;
                    strReturn = objLedger.PostPaymentReceivedEntry();

                    InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback(); ;
                        return strReturn;
                    }

                }

                // post stock ledger entry

                StockLedger objStockLedger = new StockLedger();
                objStockLedger.ItemRk = ItemRk;
                objStockLedger.LedgerItemRk= ItemRk;
                objStockLedger.FGConversionRatio = 1;
                objStockLedger.BuyerRk = BuyerRk;
                objStockLedger.VendorRk = -1;
                objStockLedger.TransactionHead = "SALE";
                objStockLedger.TransactionSubHead = "Material Sale to Customer";
                objStockLedger.TranDate = strInvoiceDate;
                objStockLedger.ItemRate = ActualItemRate;
                objStockLedger.TranQty = ActualItemQty;
                objStockLedger.LedgerQty = ActualItemQty * -1;
                objStockLedger.TranAmount = ActualItemAmt;
                objStockLedger.LedgerAmount = ActualItemAmt;
                objStockLedger.TranSource = InvoiceSource;
                objStockLedger.SourceRK = InvoiceRk;
                objStockLedger.Remarks = InvoiceNoVisible;// supplier Bill no
                objStockLedger.EventDetails = "Customer Sale";
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





                // update invoice no parameter
                ParameterDetails objParam = new ParameterDetails();
                string strResult;
                //if (InvoiceSource == RavaanaInvoiceID)
                if (TaxableInvoice == 1)
                {
                    objParam.ParaCode = "INV_NO";
                }
                else
                {
                    objParam.ParaCode = "INV_NO_V";
                }

                objParam.ParaValue = (InvoiceNo + 1).ToString();
                objParam.bTransactionBound= true;
                strResult = objParam.SetParameterValue();
                if (InfoType >= Global.gErrorNoLowerLimit)
                {
                    strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                    objFactory.TransRollback();
                    return strReturn;
                }
                //if (InvoiceSource == RavaanaInvoiceID)
                if (TaxableInvoice == 1)
                {
                    Global.gInvNo = InvoiceNo + 1;
                }
                else
                {
                    Global.gInvNoVirtual = InvoiceNo + 1;
                }

                // set global invoice_rk which will be used for conitunation printing

                Global.gInvoiceRk = InvoiceRk;

                objFactory.TransCommit();
                strReturn = logicalOK + "Invoice Generated Sucessfully!!! ";
                objFactory.TransCloseConnection();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + e.Message;

            }

        }

        public DataTable GetInvoiceDetails()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select * from vw_invoice_header where invoice_rk = @InvoiceRk ";
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public DataTable GetInvoiceDetailsforReport()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                string strInvoiceNoFilter = "";
                string strfilter = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                if (InvoiceNoList == "-")
                {
                    //Params.Add("InvoiceNo", InvoiceNo.ToString());
                    strInvoiceNoFilter = " and InvoiceNo = " + InvoiceNo.ToString();
                }
                else
                {
                    //Params.Add("InvoiceNo", InvoiceNoList);
                    //strInvoiceNoFilter = " and InvoiceNo in ( @InvoiceNo )";
                    strInvoiceNoFilter = " and InvoiceNo in ("+ InvoiceNoList + ")";
                }

                strSql = "select InvoiceKey,OnAccount,SaleType,InvoiceType,TotalPayableAmount,InvoiceNo,Dated,DispatchDateTime,RavaanaNo,TruckNo,Remarks ," +
                    " Buyer,BuyerAdd1,BuyerAdd2,BuyerGSTIN,ItemDesc,Quantity,Rate" +
                    " ItemAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, LoadingCharges ," +
                    " Commission,TotalAmount" +
                    " from vw_Invoice_Details where 1= 1  " + strInvoiceNoFilter;
                
                if (InvoiceSource == "Ravaana")
                {
                    strfilter = " or InvoiceType = 'TaxInvoice' )";
                }
                else if (InvoiceSource == "Bill")
                {

                    strfilter = " or InvoiceType = 'W/O Tax' )";
                }

                if (InvoiceSource != AllSelectedValtext)
                {
                    strSql = strSql + " and ( source = @InvoiceSource";
                    Params.Add("InvoiceSource", InvoiceSource);
                }
                
                
                strSql = strSql + strfilter;
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                return null;

            }

        }


        public DataTable GetInvoiceDetailsforChanges()
        {
            try
            {
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select InvoiceKey ,Buyer,BuyerGSTIN,SaleType,InvoiceType,TotalPayableAmount,InvoiceNo,Dated,DispatchDateTime,RavaanaNo,TruckNo,Remarks ," +
                    " BuyerAdd1,BuyerAdd2,ItemDesc,Quantity,Rate" +
                    " ItemAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, LoadingCharges ," +
                    " Commission,TotalAmount" +
                    " from vw_Invoice_Details where InvoiceNo = @InvoiceNo and TaxInvoice = 1";
                Params.Add("InvoiceNo", InvoiceNo.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                return null;

            }

        }

        public DataTable GetCustomerInvoiceDetails()
        {
            try
            {
                // to be changed
                DataTable Dt;
                string strSql = "";
                Dictionary<string, string> Params = new Dictionary<string, string>() { };

                strSql = "select * from vw_invoice_header where invoice_rk = @InvoiceRk";
                Params.Clear();
                Params.Add("@InvoiceRk", InvoiceRk.ToString());
                DbConnectionFactory objAdapter = new DbConnectionFactory();
                Dt = objAdapter.AdapterQuery(strSql, Params);
                return Dt;
            }
            catch (Exception e)
            {
                return null;

            }

        }


        public string CancelInvoice()
        {
            string strReturn;
            string strMsg;
            string ProcessName = "CancelInvoice";
            string strSql;
            int stockRk;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            objFactory.TransCommand();
            // Start a local transaction
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            try
            {

                // Check if Invoice is already being generated for Ravanna
                strSql = "update invoice_header set status = 'C' , cancellation_reason = @CancellationReason" +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where invoice_rk =  @InvoiceRk ";
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("CancellationReason", CancellationReason);
                Params.Add("UpdatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // remove the paty ledger entry

                strSql = "update ledger_account set  is_active = 0 , cancellation_reason = @CancellationReason" +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where source_rk =  @InvoiceRk and Tran_source = 'Invoice' ";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString()); 
                Params.Add("CancellationReason", CancellationReason);
                Params.Add("UpdatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // remove stock entry

                strSql = "update stock_ledger set  is_active = 0 , cancellation_reason = @CancellationReason" +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where source_rk =  @InvoiceRk and Tran_head = 'SALE' ";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("CancellationReason", CancellationReason);
                Params.Add("UpdatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);


                // remove stock computation changed on 04 June 2021

                // get the stock rk
                strSql = "select stock_rk from stock_ledger where source_rk =  @InvoiceRk and Tran_head = 'SALE' ";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                strReturn = objFactory.TransExecuteScalerQuery(strSql, Params);
                stockRk = commonLib.fnCheckNull(strReturn);

                objFactory.TransCommit();
                strReturn = logicalOK + "Invoice cancelled Sucessfully!!!";
                objFactory.TransCloseConnection();

                DbConnectionFactory objFactory1 = new DbConnectionFactory();
                string strProcName = "PR_MANAGE_STOCK_BALANCE";
                Params.Clear();
                Params.Add("STOCK_LINE_RK", stockRk.ToString());
                Params.Add("MODE", "DEALLOC");
                Params.Add("CREATED_BY ", CreatedBy);
                strReturn = objFactory1.SqlServerStoredProcExecuteNonQuery(strProcName, Params, "MSG_OUT");
                strReturn = logicalOK + "Invoice cancelled Sucessfully!!!";

                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public string ModifyInvoice()
        {
            string strReturn;
            string strMsg = "";
            string ProcessName = "ModifyInvoice";
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            // Start a local transaction
            objFactory.TransCommand();
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            try
            {

                // Check if Invoice is already being generated for Ravanna

                //strSql = "update INVOICE_HEADER set (buyer_rk ,buyer_name, buyer_add1,buyer_add2,buyer_add3," +
                //    "buyer_gstin,item_rate,item_amt,cgst_per,cgst_amt,sgst_per,sgst_amt,igst_per,igst_amt,total_inv_amt" +
                //    ",total_amt_words,updated_by,updated_on ,inv_changed,paid_by_different_buyer) =" +
                //    " (select buyer_rk, name, add1, add2,city, gstin_no,@ItemRate,@ItemAmt" +
                //    " ,@CgstPer,@CgstAmt,@SgstPer,@SgstAmt,@IgstPer,@IgstAmt,@TotalInvAmt ,@TotalAmtWords ,@UpdatedBy ,CURRENT_TIMESTAMP" +
                //    " ,@InvoiceModified,1 from buyer_master where buyer_rk =@NewBuyerRk)" +
                //    " where invoice_rk =  @InvoiceRk ";

                if (ConfigurationManager.AppSettings.Get("APP_RUN_MODE").ToUpper() == "SINGLE")
                {
                    strSql = "update INVOICE_HEADER set (buyer_name, buyer_add1,buyer_add2,buyer_add3," +
                            "buyer_gstin,item_rate,item_amt,cgst_per,cgst_amt,sgst_per,sgst_amt,igst_per,igst_amt,total_inv_amt" +
                            ",total_amt_words,updated_by,updated_on ,inv_changed,paid_by_different_buyer) =" +
                            " (select name, add1, add2,city, gstin_no,@ItemRate,@ItemAmt" +
                            " ,@CgstPer,@CgstAmt,@SgstPer,@SgstAmt,@IgstPer,@IgstAmt,@TotalInvAmt ,@TotalAmtWords ,@UpdatedBy ,CURRENT_TIMESTAMP" +
                            " ,@InvoiceModified,1 from buyer_master where buyer_rk =@NewBuyerRk)" +
                        " where invoice_rk =  @InvoiceRk ";

                }
                else
                {
                    strSql = "update INVOICE_HEADER set INVOICE_HEADER.buyer_name = t1.name, INVOICE_HEADER.buyer_add1 = t1.add1," +
                                "INVOICE_HEADER.buyer_add2 = t1.add2,INVOICE_HEADER.buyer_add3 = t1.city," +
                            " INVOICE_HEADER.buyer_gstin = t1.gstin_no,INVOICE_HEADER.item_rate =@ItemRate ,INVOICE_HEADER.item_amt = @ItemAmt," +
                            " INVOICE_HEADER.cgst_per = @CgstPer,INVOICE_HEADER.cgst_amt = @CgstAmt,INVOICE_HEADER.sgst_per = @SgstPer," +
                            " INVOICE_HEADER.sgst_amt = @SgstAmt,INVOICE_HEADER.igst_per =@IgstPer ," +
                            " INVOICE_HEADER.igst_amt = @IgstAmt ,INVOICE_HEADER.total_inv_amt =@TotalInvAmt " +
                            ",INVOICE_HEADER.total_amt_words = @TotalAmtWords,INVOICE_HEADER.updated_by = @UpdatedBy,INVOICE_HEADER.updated_on = getdate() " +
                            ",INVOICE_HEADER.inv_changed = @InvoiceModified ,INVOICE_HEADER.paid_by_different_buyer = 1 , INVOICE_HEADER.item_desc = @ItemDesc " +
                            " from (select name, add1, add2,city, gstin_no from buyer_master where buyer_rk =@NewBuyerRk) t1" +
                        " where invoice_rk =  @InvoiceRk ";

                }
                
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("NewBuyerRk", NewBuyerRk.ToString());
                Params.Add("ItemQty", ItemQty.ToString());
                Params.Add("ItemRate", ItemRate.ToString());
                Params.Add("ItemAmt", ItemAmt.ToString());
                Params.Add("CgstPer", CGSTPer.ToString());
                Params.Add("CgstAmt", CGSTAmt.ToString());
                Params.Add("SgstPer", SGSTPer.ToString());
                Params.Add("SgstAmt", SGSTAmt.ToString());
                Params.Add("IgstPer", IGSTPer.ToString());
                Params.Add("IgstAmt", IGSTAmt.ToString());
                Params.Add("TotalInvAmt", TotalInvAmt.ToString());
                Params.Add("TotalAmtWords", TotalAmtWords.ToString());
                Params.Add("UpdatedBy", CreatedBy);
                Params.Add("InvoiceModified", InvoiceModified.ToString());
                Params.Add("ItemDesc", ItemDesc);
                objFactory.TransExecuteNonQuery(strSql, Params);


                // Modify the party ledger entry

                //strSql = "update ledger_account set  buyer_rk = @NewBuyerRk" +
                //                  " where source_rk =  @InvoiceRk and Tran_source = 'Invoice' and buyer_rk > 0 ";
                //Params.Clear();
                //Params.Add("InvoiceRk", InvoiceRk.ToString());
                //Params.Add("NewBuyerRk", NewBuyerRk.ToString());
                //Params.Add("UpdatedBy", CreatedBy);

                //objFactory.TransExecuteNonQuery(strSql, Params);

                objFactory.TransCommit();
                strReturn = logicalOK + "Invoice details modified Sucessfully!!!";
                objFactory.TransCloseConnection();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }

        public string GetLastInvoiceDate()
        {
            string strSql = "";
            string strReturn;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            try
            {

                // Check if Invoice is already being generated for Ravanna
                strSql = "select " + Global.gIsNull + "(max(dated),CURRENT_TIMESTAMP) from vw_Invoice_Details";
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(strSql, Params);
                return strReturn;
            }
            catch (Exception e)
            {
                return DateTime.Now.AddMonths(50).ToString();

            }

        }



        public string CashToCreditSale()
        {
            string strReturn;
            string strMsg;
            string ProcessName = "CashToCreditSale";
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            objFactory.TransCommand();
            // Start a local transaction
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            try
            {

                // Check if Invoice is already being generated for Ravanna
                strSql = "update invoice_header set amount_received = 0 , remarks = 'Changed from Cash to Credit Sale'" +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where invoice_rk =  @InvoiceRk ";
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("UpdatedBy", CreatedBy);

                objFactory.TransExecuteNonQuery(strSql, Params);

                // remove the paty ledger entry

                strSql = "update ledger_account set  is_active = 0 " +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where source_rk =  @InvoiceRk and tran_source = 'Invoice' and tran_sub_head ='Customer Payment'  ";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("UpdatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                objFactory.TransCommit();
                strReturn = logicalOK + "Sale moved from Cash to Credit sucessfully!!!";
                objFactory.TransCloseConnection();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }

        public string CreditToCashSale()
        {
            string strReturn;
            string strMsg;
            string ProcessName = "CreditToCashSale";
            string strSql;
            DataTable Dt;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            objFactory.TransConnection();
            objFactory.TransCommand();
            // Start a local transaction
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            try
            {

                // get the invoice Details

                strSql = "select * from vw_invoice_header where invoice_rk = @InvoiceRk";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Dt = objFactory.AdapterQuery(strSql, Params);

                DataRow row = Dt.Rows[0];

                DateTime InvoiceDate;
                decimal AmountPayable = commonLib.fnCheckDecimal(row["total_amt_payable"].ToString());
                int BuyerRk = commonLib.fnCheckNull(row["buyer_rk"].ToString());
                //InvoiceDate = Convert.ToDateTime(row["invoice_date"].ToString());
                string strInvoiceDate = commonLib.ConvertTranDateFormat(Convert.ToDateTime(row["invoice_date"].ToString()));
                string InvoiceNoVisible = row["invoice_no_visible"].ToString();
                string InvoiceSource = row["inv_Source"].ToString();


                // Check if Invoice is already being generated for Ravanna
                strSql = "update invoice_header set amount_received = total_amt_payable , remarks = 'Changed from Cash to Credit Sale'" +
                                  " , updated_by =@UpdatedBy , updated_on  = CURRENT_TIMESTAMP  " +
                                  " where invoice_rk =  @InvoiceRk ";
                Params.Clear();
                Params.Add("InvoiceRk", InvoiceRk.ToString());
                Params.Add("UpdatedBy", CreatedBy);

                objFactory.TransExecuteNonQuery(strSql, Params);

                // Make an entry to party ledger 

                if (AmountPayable > 0)
                {

                    CompanyLedger objLedger = new CompanyLedger();
                    objLedger.BuyerRk = BuyerRk;
                    objLedger.TranAmount = AmountPayable;
                    objLedger.TranDate = strInvoiceDate;
                    objLedger.TranSource = "Invoice";
                    objLedger.TransactionSubHead = "Customer Payment";
                    objLedger.SourceRK = InvoiceRk;
                    objLedger.Remarks = InvoiceNoVisible;
                    objLedger.EventDetails = InvoiceSource + " Payment Received";
                    objLedger.CreatedBy = CreatedBy;
                    objLedger.bTransactionBound = true;
                    strReturn = objLedger.PostPaymentReceivedEntry();

                    int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                    if (InfoType >= Global.gErrorNoLowerLimit)
                    {
                        strReturn = TechnicalError + commonLib.GetInformation(strReturn);
                        objFactory.TransRollback(); ;
                        return strReturn;
                    }

                }

                objFactory.TransCommit();
                strReturn = logicalOK + "Sale moved from Cash to Credit sucessfully!!!";
                objFactory.TransCloseConnection();
                return strReturn;
            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }


        public string ChangeSaleRateWeight()
        {
            string strReturn;
            string ProcessName = "ChangeSaleRateWeight";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            string strProcName = "PR_CHANGE_SALE_RATE";
            try
            {

                Params.Add("Invoice_No", InvoiceNo.ToString());
                Params.Add("Sale_Rate", SaleRate.ToString());
                Params.Add("Sale_Qty", SaleQuantity.ToString());

                strReturn = objFactory.SqlServerStoredProcExecuteNonQuery(strProcName, Params, "MSG_OUT");

                return strReturn;
            }
            catch (Exception e)
            {
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }

        }

        public string ChangeInvoiceAccount()
        {
            string strReturn;
            string ProcessName = "ChangeInvoiceAccount";
            string strProcessParam;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            DbConnectionFactory objFactory = new DbConnectionFactory();
            string strProcName = "PR_CHANGE_BUYER_NEW";
            try
            {

                // build JSON

                strProcessParam = "{";
                strProcessParam = strProcessParam + "\"" + "INVOICENO" + "\""+  ":"  + InvoiceNo.ToString() + ",";
                strProcessParam = strProcessParam + "\"" + "BUYERRK" + "\"" +":" + ActualBuyerRk.ToString() + ",";
                strProcessParam = strProcessParam + "\"" + "USERNAME" + "\"" +":" + "\"" + CreatedBy + "\"";
                strProcessParam = strProcessParam + "}";
                Params.Add("PROCESS_PARAM", strProcessParam);
                
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
