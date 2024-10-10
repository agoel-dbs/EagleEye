using EagleEye.DBLayer;
using EagleEye.Lib;
using EagleEye.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye.Operations
{
    public partial class frmInvoiceWR : Form
    {
        public String SRC = commonLib.GetRavanvaFileSourcePath();
        public String ProcessedFilePath = commonLib.GetInvoiceFilePath();

        public string RavannaFileName = Global.gRavannaFileName;
        public string msgBoxCaption = Global.gMsgBoxCaption;
        public string GeneratePdfInvoice = Global.gGeneratePdfInvoice;
        public Boolean bInvoiceGenerated = false;
        // Find Index of Expense Grid Columns
        int ExpenseKeyIDColIndex;
        int ExpenseChargesColIndex;
        int TotalExpenseColIndex;
        // find Row index of Expense 
        //vechile loading Row
        int LoadingRowID;
        // Driver Commison loading Row
        int CommisionRowID;

        //Amount
        decimal AmtToBeCollected;
        decimal ItemAmount;
        decimal TaxItemAmount;
        decimal TotalLoadingCharges;
        decimal TotalCommisionCharges;

        // Expenses

        decimal TotalInwardCharges = 0;
        decimal TotalOutwordCharges = 0;

        string InvoiceSource = "Bill";

        // Invoice Realted Parameter
        bool bFormLoad = false;
        int TaxableInvoice = 0;
        int InvoiceNo;
        string  HSNCode;
        decimal CGSTPer;
        decimal CGSTAmt;
        decimal SGSTPer;
        decimal SGSTAmt;
        decimal IGSTPer;
        decimal IGSTAmt;

        decimal ItemCGSTPer;
        decimal ItemSGSTPer;
        decimal ItemIGSTPer;

        string BuyerAdd1;
        string BuyerAdd2;
        string BuyerAdd3;
        string BuyerGSTIN;

        public frmInvoiceWR()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Bill Print");
        }

        private void TxtPrintCopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressNumber(e);
        }

        private void ControlEnableDisable(Boolean bEnableControl)
        {
            //txtInvoiceNo.Enabled = bEnableControl;
        }

        private void SetControlValueBlank()
        {
            try
            {

                //dataGridView1.DataSource = null;
                cmbBuyer.SelectedIndex = -1;
                txtActualSaleQty.Text = "";
                txtAmountReceived.Text = "";
                txtCollectionAmt.Text = "";
                txtOldInvoiceNo.Text = "";
                txtRatePerTon.Text = "";

            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void LoadInvoiceExpense()
        {
            try
            {
                DataTable DT;
                InvoiceDetails objInvoice = new InvoiceDetails();
                objInvoice.ExpenseGroup = "INVOICE";
                DT = objInvoice.GetExpenseDetails();
                // load data
                GridFunc.PopulateDataGrid(dgExpenseDetails, DT);
                // set grid propoerties
                GridFunc.SetGridProperties("frmLoadRavaana", dgExpenseDetails);
                // calculate expenses
                CalculateExpenses();

            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        private void CalculateExpenses()
        {
            try
            {

                ExpenseKeyIDColIndex = GridFunc.FindGridColumnIndex(dgExpenseDetails, "ExpenseID");

                if (ExpenseKeyIDColIndex == -1)
                {
                    return;
                }

                ExpenseChargesColIndex = GridFunc.FindGridColumnIndex(dgExpenseDetails, "Value");

                TotalExpenseColIndex = GridFunc.FindGridColumnIndex(dgExpenseDetails, "TotalExpense");

                LoadingRowID = GridFunc.FindGridRowIndex(dgExpenseDetails, ExpenseKeyIDColIndex, "VECHILE_LOADING");

                CommisionRowID = GridFunc.FindGridRowIndex(dgExpenseDetails, ExpenseKeyIDColIndex, "DRIVER_COMMISION");


                // find the loading charges
                decimal loadingCharge;
                loadingCharge = commonLib.fnCheckDecimal(dgExpenseDetails.Rows[LoadingRowID].Cells[ExpenseChargesColIndex].Value.ToString());

                // set the value in TotalExpenseColumn
                decimal InvoiceQty = commonLib.fnCheckDecimal(txtActualSaleQty.Text);
                TotalLoadingCharges = Math.Round((loadingCharge * InvoiceQty), 0);
                dgExpenseDetails.Rows[LoadingRowID].Cells[TotalExpenseColIndex].Value = TotalLoadingCharges;



                // find the loading charges
                decimal CommisionCharge;
                CommisionCharge = commonLib.fnCheckDecimal(dgExpenseDetails.Rows[CommisionRowID].Cells[ExpenseChargesColIndex].Value.ToString());

                // set the value in TotalExpenseColumn
                TotalCommisionCharges = Math.Round((CommisionCharge * InvoiceQty), 0);

                dgExpenseDetails.Rows[CommisionRowID].Cells[TotalExpenseColIndex].Value = TotalCommisionCharges;

            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void TxtRatePerTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void TxtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void BtnGenerateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmation;
                int ActualBuyerRk = -1;
                string strBuyerName = "";
                decimal ActualSaleQty = commonLib.fnCheckDecimal(txtActualSaleQty.Text);
                decimal ActualSaleRate = commonLib.fnCheckDecimal(txtRatePerTon.Text);
                decimal InvoiceQty = commonLib.fnCheckDecimal(txtInvoiceQty.Text);
                decimal InvoiceRate = commonLib.fnCheckDecimal(txtTaxInvoiceRate.Text);
                decimal ActualAmountPaybale;
                string BuyerName;
                string ItemDesc;
                decimal TotalTaxInvAmt;
                int NoPrintCopies = 0;
                BuyerName =  commonLib.GetComboSelectedText(cmbBuyer);
                ItemDesc = commonLib.GetComboSelectedText(cmbItem);
                NoPrintCopies = commonLib.fnCheckNull(txtPrintCopy.Text);

                if (NoPrintCopies == 0)
                {
                    NoPrintCopies = 1;

                }

                // in case of non taxable invoice set invoice rate and Qty same of actual Sale

                if ( chkTaxableInvoice.Checked==false )
                {
                    txtInvoiceQty.Text = txtActualSaleQty.Text;
                    txtTaxInvoiceRate.Text = txtRatePerTon.Text;
                }


                ActualSaleQty = commonLib.fnCheckDecimal(txtActualSaleQty.Text);
                ActualSaleRate = commonLib.fnCheckDecimal(txtRatePerTon.Text);
                InvoiceQty = commonLib.fnCheckDecimal(txtInvoiceQty.Text);
                InvoiceRate = commonLib.fnCheckDecimal(txtTaxInvoiceRate.Text);
                TaxItemAmount = InvoiceQty * InvoiceRate;


                //if (bInvoiceGenerated == true)
                //{
                //    commonLib.showUIMessage("You have already generated the invoice / slip.",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    this.Close();
                //}

                if (BuyerName == "")
                {
                    commonLib.showUIMessage("Please select the buyer!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbBuyer.Focus();
                    return;
                }

                if (ItemDesc == "")
                {
                    commonLib.showUIMessage("Please select the Item!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbItem.Focus();
                    return;
                }

                if (txtRatePerTon.Text.Trim() == "")
                {
                    commonLib.showUIMessage("Please enter the sale rate !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRatePerTon.Focus();
                    return;
                }

                if (txtActualSaleQty.Text.Trim() == "")
                {
                    commonLib.showUIMessage("Please enter the sale Qualtity!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtActualSaleQty.Focus();
                    return;
                }


                if (txtInvoiceQty.Text.Trim() == "")
                {
                    commonLib.showUIMessage("Please enter the Invoice Quantity!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtInvoiceQty.Focus();
                    return;
                }

                if (txtTaxInvoiceRate.Text.Trim() == "")
                {
                    commonLib.showUIMessage("Please enter the invoice sale rate!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTaxInvoiceRate.Focus();
                    return;
                }

                if (txtTruckNo.Text.Trim() == "")
                {
                    commonLib.showUIMessage("Please enter the vechile no!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTruckNo.Focus();
                    return;
                }


                // if it is sale invoice and tax type is not selected the prompt

                if (TaxableInvoice == 1)
                {

                    if (commonLib.GetComboSelectedValue(cmbTaxType) == "")
                    {
                        commonLib.showUIMessage("Please select the tax type applied for this invoice !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbTaxType.Focus();
                        return;

                    }

                }

                

                if (BuyerName.ToUpper() == "CASH")
                {
                    chkPaymentMade.Checked = true;
                }
                else
                {
                    chkPaymentMade.Checked = false;
                }

                if (chkOtherBuyer.Checked == true)
                {

                    strBuyerName = commonLib.GetComboSelectedText(cmbBuyer);
                    ActualBuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer));

                    if (strBuyerName == "")
                    {
                        commonLib.showUIMessage("Select the buyer for payment!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbBuyer.Focus();
                        return;
                    }
                    if (strBuyerName.ToUpper() == "CASH")
                    {
                        chkPaymentMade.Checked = true;
                    }
                    else
                    {
                        chkPaymentMade.Checked = false;
                    }

                }

                if (chkOtherBuyer.Checked == true)
                {

                    strBuyerName = commonLib.GetComboSelectedText(cmbOtherBuyer);
                    ActualBuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbOtherBuyer));

                    if (strBuyerName == "")
                    {
                        commonLib.showUIMessage("Select the buyer for payment!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbBuyer.Focus();
                        return;
                    }
                    if (strBuyerName.ToUpper() == "CASH")
                    {
                        chkPaymentMade.Checked = true;
                    }
                    else
                    {
                        chkPaymentMade.Checked = false;
                    }

                }
                LoadTaxDetails();
                CalulateTotalAmount();

                ActualAmountPaybale = ((ActualSaleRate * ActualSaleQty) + TotalInwardCharges + CGSTAmt + SGSTAmt + IGSTAmt);

                ActualAmountPaybale = Math.Round(ActualAmountPaybale, 0);
                strConfirmation = "You are about to generate an Invoice with the below Details" + Environment.NewLine +
                                  "Actual Rate :" + ActualSaleRate.ToString() + Environment.NewLine +
                                  "Actual Quantity: " + ActualSaleQty.ToString() + Environment.NewLine +
                                  "Good Value :" + (ActualSaleRate * ActualSaleQty).ToString() + Environment.NewLine +
                                  "CGST Tax :" + CGSTAmt + Environment.NewLine +
                                  "SGST Tax :" + SGSTAmt + Environment.NewLine +
                                  "IGST Tax :" + IGSTAmt + Environment.NewLine +
                                  "Loading charges: " + TotalLoadingCharges + Environment.NewLine +
                                  "Payable by customer: " + ActualAmountPaybale + Environment.NewLine + Environment.NewLine +
                                  "Commision: " + TotalCommisionCharges + Environment.NewLine +
                                  "Total Amount to be Collected: " + AmtToBeCollected + Environment.NewLine + Environment.NewLine +
                                   "Do you want to proceed ?";

                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Invoice process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string strDate;
                DateTime InvoiceDate;

                //strDate = DateTime.Now.ToString("dd/MM/yyyy");

                strDate = dtBillDate.Value.ToString("dd/MM/yyyy");

                strDate = strDate.Replace('-', '/');
                //InvoiceDate = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                InvoiceDate = commonLib.ConvertStringtoDate(strDate);
                
                //DateTime date = DateTime.ParseExact(Date, "dd/MM/YYYY", null);

                // make entries to database

                if (chkTaxableInvoice.Checked==true)
                {
                    InvoiceNo = Global.gInvNo;
                }
                else
                {
                    InvoiceNo = Global.gInvNoVirtual;
                }

                InvoiceNo = Convert.ToInt32(txtInvoiceNo.Text);

                InvoiceDetails objInvoice = new InvoiceDetails();
                objInvoice.InvoiceNo = InvoiceNo;
                objInvoice.InvoiceNoVisible = (Global.gInvNoPrefix + InvoiceNo.ToString());
                objInvoice.InvoiceDate = InvoiceDate;
                objInvoice.DispatchDateTime = dtBillDate.Value.ToString("dd-MM-yyyy hh:mm:ss tt");
                objInvoice.RavannaNo = "-1";
                objInvoice.TruckNo = txtTruckNo.Text;
                objInvoice.SellerName = Global.gSellerName;
                objInvoice.SellerAdd1 = Global.gSellerAdd1;
                objInvoice.SellerAdd2 = Global.gSellerAdd2;
                objInvoice.SellerAdd3 = Global.gSellerAdd3;
                objInvoice.SellerGSTIN = Global.gSellerGSTIN;
                objInvoice.BuyerName = BuyerName;
                objInvoice.BuyerAdd1 = BuyerAdd1;
                objInvoice.BuyerAdd2 = BuyerAdd2;
                objInvoice.BuyerAdd3 = BuyerAdd3;
                objInvoice.BuyerGSTIN = BuyerGSTIN;
                objInvoice.ItemDesc = ItemDesc;
                objInvoice.HSNCode = HSNCode;
                objInvoice.ItemQty = InvoiceQty;
                objInvoice.ItemRate = InvoiceRate;
                TotalTaxInvAmt = Math.Round((InvoiceQty * InvoiceRate), 0);
                objInvoice.ItemAmt = TotalTaxInvAmt;
                //objInvoice.ItemAmt = Math.Round((ActualSaleRate * ActualSaleQty),0);

                objInvoice.CGSTAmt = Math.Round(CGSTAmt,2);
                objInvoice.CGSTPer = CGSTPer;
                objInvoice.SGSTAmt = Math.Round(SGSTAmt,2);
                objInvoice.SGSTPer = SGSTPer;
                objInvoice.IGSTAmt = Math.Round(IGSTAmt,2);
                objInvoice.IGSTPer = IGSTPer;

                TotalTaxInvAmt = Math.Round(TotalTaxInvAmt + Math.Round(CGSTAmt, 2) +Math.Round(SGSTAmt, 2) + Math.Round(IGSTAmt, 2),0);
                objInvoice.TotalInvAmt = TotalTaxInvAmt;

                objInvoice.TotalAmtWords = commonLib.ConvertWholeNumber(TotalTaxInvAmt.ToString());
                objInvoice.BankName = Global.gBankName;
                objInvoice.BankAccountNo = Global.gBankAccountNo;
                objInvoice.IfscCode = Global.gIfscCode;
                objInvoice.BankAdd1 = Global.gBankAdd1;
                objInvoice.BankAdd2 = Global.gBankAdd2;
                objInvoice.CertifyClause = Global.gCertifyClause;
                objInvoice.GeneralInstruction = Global.gInstruction;
                objInvoice.ActualItemQty = ActualSaleQty;
                objInvoice.ActualItemRate = ActualSaleRate;
                objInvoice.ActualItemAmt = Math.Round((ActualSaleRate * ActualSaleQty),0);
                objInvoice.OtherInwardExpense = Math.Round(TotalInwardCharges,0);
                objInvoice.OtherOutwardExpense = Math.Round(TotalOutwordCharges,0);
                objInvoice.TotalAmtPayable = Math.Round(ActualAmountPaybale,0);
                objInvoice.TotalAmtCollected = Math.Round((ActualAmountPaybale - TotalOutwordCharges),0);
                objInvoice.AmountReceived = Math.Round(commonLib.fnCheckDecimal(txtAmountReceived.Text),0);
                objInvoice.CheckDuplicateRavanna = "N";
                objInvoice.InvoiceSource = InvoiceSource;
                objInvoice.CreatedBy = Global.gUserID;
                //objInvoice.ActualBuyerRk = -1;// buyer is same who is paying
                objInvoice.ActualBuyerRk = ActualBuyerRk;
                objInvoice.CheckDuplicateInvoiceNo = "Y";
                objInvoice.TaxableInvoice = TaxableInvoice;
                objInvoice.SlipItemRate = commonLib.fnCheckDecimal(txtItemSlipRate.Text);
                objInvoice.SlipItemQty= commonLib.fnCheckDecimal(txtSlipWeight.Text);

                string strReturn = objInvoice.GenerateInvoice();
                commonLib.ShowDBMessage(strReturn);

                // print invoice

                //PrintInvoice(Global.gInvoiceRk);
                // Print Invoice Slip

                
                DocPrint.PrintInvoiceSlip(Global.gInvoiceRk, 1, InvoiceSource);
                if (chkTaxableInvoice.Checked == true)
                { 
                    
                    DocPrint.PrintInvoice(Global.gInvoiceRk,InvoiceNo.ToString(), NoPrintCopies, InvoiceSource,"Y");

                }
                
                Global.gInvoiceRk = -1;
                bInvoiceGenerated = true;

                commonLib.PopulateGlobalParameter();
                
                if (chkTaxableInvoice.Checked == true)
                {
                    InvoiceNo = Global.gInvNo;
                }
                else
                {
                    InvoiceNo = Global.gInvNoVirtual;
                }
                txtInvoiceNo.Text = InvoiceNo.ToString();
                //commonLib.showUIMessage("Invoice printed Sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            catch (Exception ex)
            {
                commonLib.PopulateGlobalParameter();
                txtInvoiceNo.Text = Global.gInvNoVirtual.ToString();
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        private void CalulateTotalAmount()
        {
            try
            {
                decimal ItemRatePerUnit;
                //decimal AmtToBeCollected;
                int ExpenseTypeColIndex;
                decimal ActualSaleQty;
                decimal InvoiceQty;
                decimal InvoiceRate;
                string ExpenseType;

                
                ItemRatePerUnit = commonLib.fnCheckDecimal(txtRatePerTon.Text);
                ActualSaleQty = commonLib.fnCheckDecimal(txtActualSaleQty.Text);

                InvoiceQty = commonLib.fnCheckDecimal(txtInvoiceQty.Text);
                InvoiceRate = commonLib.fnCheckDecimal(txtTaxInvoiceRate.Text);

                AmtToBeCollected = (ItemRatePerUnit * ActualSaleQty) ;
                ItemAmount = ActualSaleQty * ItemRatePerUnit;

                TaxItemAmount = InvoiceQty * InvoiceRate;

                // find amount to be charged from Customer (Inward Expense)

                //get the column index of Type Columns
                TotalInwardCharges = 0;
                TotalOutwordCharges = 0;

                ExpenseTypeColIndex = GridFunc.FindGridColumnIndex(dgExpenseDetails, "Type");
                if (ExpenseTypeColIndex == -1)
                {
                    return;
                }


                for (int i = 0; i < dgExpenseDetails.Rows.Count; i++)
                {

                    ExpenseType = dgExpenseDetails.Rows[i].Cells[ExpenseTypeColIndex].Value.ToString();

                    if (ExpenseType == "CR")
                    {
                        TotalInwardCharges = TotalInwardCharges + commonLib.fnCheckDecimal(dgExpenseDetails.Rows[i].Cells[TotalExpenseColIndex].Value.ToString());

                    }
                    else
                    {
                        TotalOutwordCharges = TotalOutwordCharges + commonLib.fnCheckDecimal(dgExpenseDetails.Rows[i].Cells[TotalExpenseColIndex].Value.ToString());

                    }
                }

                // loading charges
                TotalLoadingCharges = Math.Round(commonLib.fnCheckDecimal(dgExpenseDetails.Rows[LoadingRowID].Cells[TotalExpenseColIndex].Value.ToString()), 0);

                // taxes in case of tax invoice ( for scrap and other material)
                AmtToBeCollected = AmtToBeCollected + TotalInwardCharges + IGSTAmt + CGSTAmt + SGSTAmt;


                // Commision charges
                TotalCommisionCharges = Math.Round(commonLib.fnCheckDecimal(dgExpenseDetails.Rows[CommisionRowID].Cells[TotalExpenseColIndex].Value.ToString()), 0);

                txtCollectionAmt.Text = AmtToBeCollected.ToString();

                AmountCollectedAuto();

                AmtToBeCollected = AmtToBeCollected - TotalOutwordCharges;

                
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void TxtRatePerTon_TextChanged(object sender, EventArgs e)
        {
            CalculateExpenses();
            CalulateTotalAmount();
            txtItemSlipRate.Text = txtRatePerTon.Text;
            if (chkTaxableInvoice.Checked == true)
            {
                txtTaxInvoiceRate.Text = "600";
            }
            else
            {
                txtTaxInvoiceRate.Text = txtRatePerTon.Text;
            }
        }

        private void TxtActualSaleQty_TextChanged(object sender, EventArgs e)
        {
            CalculateExpenses();
            CalulateTotalAmount();
            txtSlipWeight.Text = txtActualSaleQty.Text;
            txtInvoiceQty.Text= txtActualSaleQty.Text;

        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                int iNoofPrint;
                string InvoiceType = "";
                string InvoiceNo = "";

                if (txtOldInvoiceNo.Text == "")
                {
                    commonLib.showUIMessage("Please enter the invoice no for re-printing!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tabMain.SelectedTab = tbView;
                    txtOldInvoiceNo.Focus();
                    return;
                }

                // find selected row for re-printing
                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    if (r.Selected == true)
                    {
                        Global.gInvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
                        InvoiceType = grdInvoiceDetails.Rows[r.Index].Cells[2].Value.ToString();
                        InvoiceNo = grdInvoiceDetails.Rows[r.Index].Cells[4].Value.ToString();
                    }
                }

                if (Global.gInvoiceRk == -1)
                {
                    commonLib.showUIMessage("Please select a row for invoice re-printing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (txtPrintCopy.Text =="")
                {
                    iNoofPrint = 1;
                }
                else
                {
                    iNoofPrint = commonLib.fnCheckNull(txtPrintCopy.Text);
                }

                if (InvoiceType == "TaxInvoice")
                {
                    // Print Invoice
                    DocPrint.PrintInvoice(Global.gInvoiceRk, InvoiceNo, iNoofPrint, InvoiceSource,"Y");
                }
                else
                {
                    // Print Invoice Slip
                    DocPrint.PrintInvoiceSlip(Global.gInvoiceRk, iNoofPrint, InvoiceSource);
                }
                Global.gInvoiceRk = -1;
                //commonLib.showUIMessage("Invoice printed Sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void TxtOldInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressNumber(e); 
        }

        private void TxtOldInvoiceNo_Leave(object sender, EventArgs e)
        {
            if (txtOldInvoiceNo.Text == "")
                return;
            loadInvoiceDetails();
        }
        private void loadInvoiceDetails()
        {
            try
            {
                InvoiceDetails objInv = new InvoiceDetails();
                DataTable DT;
                Global.gInvoiceRk = -1;
                objInv.InvoiceNo = Convert.ToInt32(txtOldInvoiceNo.Text);
                objInv.InvoiceSource = InvoiceSource;
                DT = objInv.GetInvoiceDetailsforReport();
                if (DT == null)
                {
                    commonLib.showUIMessage("Invoice not found in system , try another invoice!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // load data
                GridFunc.PopulateDataGrid(grdInvoiceDetails, DT);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FrmInvoiceWR_Load(object sender, EventArgs e)
        {
            commonLib.PopulateGlobalParameter();
            bInvoiceGenerated = false;
            // load Combo
            commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");
            commonLib.PopulateBuyerCombo(cmbOtherBuyer, "N", "", "N");
            commonLib.PopulateSaleItemCombo(cmbItem, "N", "", "N");
            commonLib.PopulateParamMasterCombo(cmbTaxType, "N", " para_group = 'TAX_TYPE' ", "N");
            txtInvoiceNo.Text = Global.gInvNo.ToString();
            //txtPrintCopy.Text = "1";
            
            //chkTaxableInvoice.Checked = true;
            cmbTaxType.SelectedIndex = 1;
            TaxableInvoice = 1;
            InvoiceNo = Global.gInvNo;
            cmbTaxType.SelectedIndex = 1;
            txtTaxInvoiceRate.Text = "600";
            InvoiceSource = "Bill";

            //Expense Details
            LoadInvoiceExpense();

            commonLib.SetCustomDateFormat(dtBillDate);
            dtBillDate.Value = DateTime.Now;

            // load tax Details
            LoadTaxDetails();
            bFormLoad = true;
        }

        private void LoadTaxDetails()
        {
            if (TaxableInvoice == 0)
            {
                InvoiceNo = Global.gInvNoVirtual;
                CGSTPer = 0  ;
                CGSTAmt = 0 ;
                SGSTPer = 0 ;
                SGSTAmt = 0;
                IGSTPer = 0;
                IGSTAmt = 0;
            }
            else
            {
                if  (commonLib.GetComboSelectedValue(cmbTaxType) == "LOCAL_TAX")
                {
                    CGSTPer = ItemCGSTPer;
                    //CGSTAmt = (ItemAmount * CGSTPer) /100;
                    CGSTAmt = (TaxItemAmount * CGSTPer) / 100;
                    SGSTPer = ItemSGSTPer;
                    SGSTAmt = (TaxItemAmount * CGSTPer)/100;
                    IGSTPer = 0;
                    IGSTAmt = 0;
                }
                else
                {
                    CGSTPer = 0;
                    CGSTAmt = 0;
                    SGSTPer = 0;
                    SGSTAmt = 0;
                    IGSTPer = ItemIGSTPer;
                    IGSTAmt = (TaxItemAmount * IGSTPer)/100;

                }

            }
        }


        private void ChkPaymentMade_CheckedChanged(object sender, EventArgs e)
        {
            AmountCollectedAuto();
        }

        private void AmountCollectedAuto()
        {
            if (chkPaymentMade.Checked == true)
            {
                txtAmountReceived.Text = txtCollectionAmt.Text;
            }
            else
            {
                txtAmountReceived.Text = "";
            }

        }

        private void CmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFormLoad == false)
                return;
            GetItemDetails();

        }

        private void GetItemDetails()
        {
            try
            {
                string ItemRk;
                DataTable DT;
                ItemRk = commonLib.GetComboSelectedValue(cmbItem);

                ItemMasterDetails objItem = new ItemMasterDetails();
                objItem.ItemRK = ItemRk;
                DT = objItem.GetItemDetails();
                DataRow row = DT.Rows[0];

                HSNCode = row["HSNCode"].ToString();
                ItemCGSTPer = commonLib.fnCheckDecimal( row["CGSTPer"].ToString());
                ItemSGSTPer = commonLib.fnCheckDecimal(row["SGSTPer"].ToString());
                ItemIGSTPer = commonLib.fnCheckDecimal(row["IGSTPer"].ToString());

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CmbTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFormLoad == false)
                return;
            LoadTaxDetails();
        }

        private void ChkTaxableInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaxableInvoice.Checked == true)
            {
                TaxableInvoice = 1;
                InvoiceNo = Global.gInvNo;
                cmbTaxType.SelectedIndex = 1;
                txtTaxInvoiceRate.Text = "600";
            }
            else
            {
                TaxableInvoice = 0;
                InvoiceNo = Global.gInvNoVirtual;
                txtTaxInvoiceRate.Text = txtActualSaleQty.Text;
            }

            LoadTaxDetails();

        }

        

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFormLoad == false)
                return;
            GetBuyerDetails();
        }

        private void GetBuyerDetails()
        {
            try
            {
                string BuyerRk;
                DataTable DT;
                BuyerRk = commonLib.GetComboSelectedValue(cmbBuyer);

                BuyerManagement objBuyer = new BuyerManagement();
                objBuyer.BuyerRK= BuyerRk;
                DT = objBuyer.GetBuyerDetails();
                DataRow row = DT.Rows[0];

                BuyerAdd1 = row["Address1"].ToString();
                BuyerAdd2 = row["Address2"].ToString();

                BuyerAdd3 = row["City"].ToString();
                BuyerGSTIN= row["GSTIN"].ToString();
                txtGSTNo.Text = BuyerGSTIN;
            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void TxtItemSlipRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void txtActualSaleQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void txtSlipWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void chkPaymentMade_MouseClick(object sender, MouseEventArgs e)
        {
            AmountCollectedAuto();
        }

        private void chkTaxableInvoice_Click(object sender, EventArgs e)
        {
            if (chkTaxableInvoice.Checked == true)
            {
                TaxableInvoice = 1;
                InvoiceNo = Global.gInvNo;
                cmbTaxType.SelectedIndex = 1;
                txtTaxInvoiceRate.Text = "600";
                txtInvoiceNo.Text = Global.gInvNo.ToString();
                InvoiceSource = "Ravaana";
            }
            else
            {
                TaxableInvoice = 0;
                InvoiceNo = Global.gInvNoVirtual;
                txtTaxInvoiceRate.Text = txtRatePerTon.Text;
                txtInvoiceQty.Text = txtActualSaleQty.Text;
                cmbTaxType.SelectedIndex = -1;
                txtInvoiceNo.Text = Global.gInvNoVirtual.ToString();
                InvoiceSource = "Bill";
            }

            LoadTaxDetails();

        }


        private void ChkOtherBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherBuyer.Checked == true)
            {
                cmbOtherBuyer.Enabled = true;
            }
            else
            {
                cmbOtherBuyer.SelectedIndex = -1;
                cmbOtherBuyer.Enabled = false;
            }

        }
    }
}
