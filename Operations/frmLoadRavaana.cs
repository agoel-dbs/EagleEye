using EagleEye.DBLayer;
using EagleEye.Lib;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EagleEye.Operations
{

    public partial class frmLoadRavaana : Form
    {
        public String SRC = commonLib.GetRavanvaFileSourcePath();
        public String ProcessedFilePath = commonLib.GetInvoiceFilePath();
        public String DuplicateFilePath = commonLib.GetDuplicateInvoiceFilePath();

        public string RavannaFileName = Global.gRavannaFileName;
        public string msgBoxCaption = Global.gMsgBoxCaption;
        public string GeneratePdfInvoice = Global.gGeneratePdfInvoice;

        public string[] data_By_Line;

        List<RavanaaData> lRavanaaData = new List<RavanaaData>();
        public string strRavannaHeader = "";

        // Find Index of Expense Grid Columns
        int ExpenseKeyIDColIndex;
        int ExpenseChargesColIndex;
        int TotalExpenseColIndex;
        // find Row index of Expense 
        //vechile loading Row
        int LoadingRowID;
        // Driver Commison loading Row
        int CommisionRowID;

        string InvoiceSource = "Ravaana";
        //Amount
        decimal AmtToBeCollected;
        decimal TotalLoadingCharges;
        decimal TotalCommisionCharges;

        // Expenses

        decimal TotalInwardCharges = 0;
        decimal TotalOutwordCharges = 0;

        public frmLoadRavaana()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Bill Print from E-Ravaana");

        }

        private void txtPrintCopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressNumber(e);

        }

        protected virtual string LoadDatafromPdf(String SRC)
        {

            try
            {
                string strDocExtractedData;
                string strFileName = SRC + RavannaFileName;

                if (!File.Exists(strFileName))
                {
                    return "FNF";
                }
                PdfDocument pdfDoc = new PdfDocument(new PdfReader(strFileName));

                // Create a text extraction renderer
                LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();

                // Note: if you want to re-use the PdfCanvasProcessor, you must call PdfCanvasProcessor.Reset()
                PdfCanvasProcessor parser = new PdfCanvasProcessor(strategy);
                parser.ProcessPageContent(pdfDoc.GetFirstPage());
                strDocExtractedData = strategy.GetResultantText();
                pdfDoc.Close();
                return strDocExtractedData;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "ERR";
            }
        }


        private bool checkFileformat(string strData)
        {
            try
            {
                string[] data_By_Line_Orig;
                int j = 0;
                int k;
                int arrayLength = 0;
                ParameterManagement objParamManagment = new ParameterManagement();
                DataTable Dt;
                string[] ExlcudeLine;

                Boolean bExcludeLine = false;

                Dt = objParamManagment.RavannaExcludedLines();

                ExlcudeLine = new string[Dt.Rows.Count];

                foreach (DataRow row in Dt.Rows)
                {
                    // make column visible  = false
                    ExlcudeLine[j] = row["para_value"].ToString();
                    j++;
                }


                data_By_Line_Orig = Regex.Split(strData, "\n");
                arrayLength = data_By_Line_Orig.Length;

                // declare size of working array

                data_By_Line = new string[arrayLength];

                j = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    bExcludeLine = false;
                    for (k = 0; k < ExlcudeLine.Length; k++)
                    {
                        if (data_By_Line_Orig[i].ToUpper().IndexOf(ExlcudeLine[k].ToUpper()) > -1)
                        {
                            bExcludeLine = true;
                        }
                    }
                    if (bExcludeLine == false)
                    {
                        data_By_Line[j] = data_By_Line_Orig[i];
                        j = j + 1;
                    }

                }

                if (data_By_Line[0].ToUpper() != Global.gLine0.ToUpper())
                    return false;
                // RAVANNA CHANGD ON 18 Nov 2020
                //if (data_By_Line[1].ToUpper() != Global.gLine1.ToUpper())
                //    return false;
                //if (data_By_Line[2].ToUpper() != Global.gLine2.ToUpper())
                //    return false;

                // add data to ravanna List
                AddDataToRavaanaList(1, "", Global.gLine0);
                //AddDataToRavaanaList(2, "", Global.gLine1);
                //AddDataToRavaanaList(3, "", Global.gLine2);
                return true;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private bool checkFileformatNew(string strData)
        {
            try
            {
                string[] data_By_Line_Orig;
                int j = 0;
                int k;
                int arrayLength = 0;
                ParameterManagement objParamManagment = new ParameterManagement();
                DataTable Dt;
                string[] IncludeLine;

                Boolean bIncludeLine = false;

                Dt = objParamManagment.RavannaIncludeLines();

                IncludeLine = new string[Dt.Rows.Count];

                foreach (DataRow row in Dt.Rows)
                {
                    // make column visible  = false
                    IncludeLine[j] = row["para_value"].ToString();
                    j++;
                }


                data_By_Line_Orig = Regex.Split(strData, "\n");
                arrayLength = data_By_Line_Orig.Length;


                data_By_Line = new string[arrayLength];

                j = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    bIncludeLine = false;
                    for (k = 0; k < IncludeLine.Length; k++)
                    {
                        if (data_By_Line_Orig[i].ToUpper().IndexOf(IncludeLine[k].ToUpper()) > -1)
                        {
                            bIncludeLine = true;
                        }
                    }
                    if (bIncludeLine == true)
                    {
                        data_By_Line[j] = data_By_Line_Orig[i];
                        j = j + 1;
                    }

                }

                if (data_By_Line[0].ToUpper() != Global.gLine0.ToUpper())
                    return false;
                // RAVANNA CHANGD ON 18 Nov 2020
                //if (data_By_Line[1].ToUpper() != Global.gLine1.ToUpper())
                //    return false;
                //if (data_By_Line[2].ToUpper() != Global.gLine2.ToUpper())
                //    return false;

                // add data to ravanna List
                AddDataToRavaanaList(1, "", Global.gLine0);
                //AddDataToRavaanaList(2, "", Global.gLine1);
                //AddDataToRavaanaList(3, "", Global.gLine2);
                return true;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }


        private void AddDataToRavaanaList(int pSeqNo, string pHeader, string pValue)
        {
            try
            {
                RavanaaData oravanna = new RavanaaData(pSeqNo, pHeader, pValue);
                lRavanaaData.Add(oravanna);

            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ControlEnableDisable(Boolean bEnableControl)
        {
            btnLoadData.Enabled = bEnableControl;
            cmbBuyer.SelectedIndex = -1;
            cmbBuyer.Enabled = false;
        }

        private void SetControlValueBlank()
        {
            try
            {

                //dataGridView1.DataSource = null;
                txtCollectionAmt.Text = "";
                txtAmountReceived.Text = "";
                chkOtherBuyer.Checked = false;
                cmbBuyer.SelectedIndex = -1;
                cmbBuyer.Enabled = false;
                chkPaymentMade.Checked = false;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void loadDataUI()
        {
            try
            {

                // Read Data From ravaana an load in Grid
                SetControlValueBlank();

                // set invoice specific global variable to blank

                Global.gInvoiceQty = 0;
                Global.gDispatchDateTime = "";
                Global.gPassValidityUpto = ""; ;
                Global.gRate = ""; ;
                Global.gIGSTAmt = 0;
                Global.gSGSTAmt = 0;
                Global.gCGSTAmt = 0;
                Global.gTotalInvAmt = 0;
                Global.gItemUnitRate = 0;
                Global.gRavaanaNo = "";

                // populate from Ravanna

                int LineIndex = Global.gStartLineNo;


                Global.gRavaanaNo = getFormattedDataComplete(LineIndex++);
                AddDataToRavaanaList(LineIndex, "Ravaana No", Global.gRavaanaNo);

                Global.gDistrict = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gDistrict);

                Global.gCrusherName = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gCrusherName);

                Global.gLicenseNo = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gLicenseNo);

                Global.gSellerGST = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gSellerGST);

                Global.gMaterial = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gMaterial);

                Global.gBuyerName = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gBuyerName);

                Global.gBuyerAddress = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gBuyerAddress);

                Global.gBuyerGST = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gBuyerGST);

                Global.gRoute = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gRoute);

                Global.gVechileNo = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gVechileNo);

                Global.gInvoiceQty = commonLib.fnCheckDecimal(getFormattedData(LineIndex++));
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gInvoiceQty.ToString());
                txtActualSaleQty.Text = Global.gInvoiceQty.ToString();


                Global.gDispatchDateTime = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gDispatchDateTime);

                Global.gPassValidityUpto = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gPassValidityUpto);

                // below rate is for invoice Printing
                Global.gRate = getFormattedData(LineIndex++);
                AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gRate);


                // it is for calculation
                int pos = Global.gRate.IndexOf(Global.gUnitRateSearchPattern);
                int RateSerachPatternLength = Global.gUnitRateSearchPattern.Length;
                int pos1 = Global.gRate.IndexOf("]");
                Global.gItemUnitRate = commonLib.fnCheckDecimal(Global.gRate.Substring((pos + RateSerachPatternLength), (pos1 - pos - RateSerachPatternLength)));
                txtRatePerTon.Text = Global.gItemUnitRate.ToString();



                //// SGST is at 18 Position , CGST 19 ,IGST 20 , TotalAmt 21
                //// Ravvna changes its poistion for IGST invoice  , IGST comes at 18 and Total Amount at 19 position 

                //txtSGST.Text = getFormattedData(LineIndex++);

                string strSGSTAmt = getFormattedData(LineIndex++);
                Global.gSGSTAmt = commonLib.fnCheckDecimal(strSGSTAmt);
                if (strSGSTAmt == "")
                {
                    //lblIGST.Text = "IGST" + Global.gIgstTax;
                    //txtIGST.Text = getFormattedData(LineIndex - 1, LineIndex + 1); // pick from the same line no
                    strRavannaHeader = strRavannaHeader + " - " + Global.gIgstTax;
                    Global.gIGSTAmt = commonLib.fnCheckDecimal(getFormattedData(LineIndex - 1, LineIndex + 1));
                    AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gIGSTAmt.ToString());

                    //txtTotalInvAmt.Text = getFormattedData(LineIndex, LineIndex + 2);
                    Global.gTotalInvAmt = commonLib.fnCheckDecimal(getFormattedData(LineIndex, LineIndex + 2));
                    AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gTotalInvAmt.ToString());
                }
                else
                {
                    //lblSGST.Text = "SGST" + Global.gSgstTax;
                    strRavannaHeader = strRavannaHeader + " - " + Global.gSgstTax;
                    AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gSGSTAmt.ToString());

                    //lblCGST.Text = "CGST" + Global.gCgstTax;
                    //txtCGST.Text = getFormattedData(LineIndex++);
                    Global.gCGSTAmt = commonLib.fnCheckDecimal(getFormattedData(LineIndex++));
                    strRavannaHeader = strRavannaHeader + " - " + Global.gCgstTax;
                    AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gCGSTAmt.ToString());

                    //txtTotalInvAmt.Text = getFormattedData(LineIndex, LineIndex + 1);
                    Global.gTotalInvAmt = commonLib.fnCheckDecimal(getFormattedData(LineIndex, LineIndex + 1));
                    AddDataToRavaanaList(LineIndex, strRavannaHeader, Global.gTotalInvAmt.ToString());

                }


                txtInvoiceNo.Text = Global.gInvNo.ToString();
                txtPrintCopy.Text = Global.gInvPrintCopy;
                GridFunc.PopulateDataGrid(grdRavaanaDetails, lRavanaaData, false);

                // load expense details
                LoadInvoiceExpense();


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
                InvoiceDetails objInvoice = new InvoiceDetails();
                objInvoice.ExpenseGroup = "INVOICE";
                // load data
                GridFunc.PopulateDataGrid(dgExpenseDetails, objInvoice.GetExpenseDetails());
                // set grid propoerties
                GridFunc.SetGridProperties(this.Name, dgExpenseDetails);
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




        private string getFormattedData(int pLineNo)
        {
            try
            {
                int pos;
                int stringLength;
                string strValue;
                ParameterDetails objParam = new ParameterDetails();

                objParam.ParaCode = "LINE_" + pLineNo;
                strValue = objParam.GetParameterValue();
                strRavannaHeader = strValue;

                pos = data_By_Line[pLineNo].ToUpper().IndexOf(strValue.ToUpper());
                stringLength = strValue.Length;

                if (pos > 0)
                    return (data_By_Line[pLineNo].Substring(pos + stringLength).Trim());
                else
                    return "";
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }

        private string getFormattedData(int pLineNo, int pAppConfigLineNo)
        {
            try
            {
                int pos;
                int stringLength;
                string strValue;
                ParameterDetails objParam = new ParameterDetails();

                objParam.ParaCode = "LINE_" + pAppConfigLineNo;
                strValue = objParam.GetParameterValue();
                strRavannaHeader = strValue;

                pos = data_By_Line[pLineNo].ToUpper().IndexOf(strValue.ToUpper());
                stringLength = strValue.Length;

                if (pos > 0)
                    return (data_By_Line[pLineNo].Substring(pos + stringLength).Trim());
                else
                    return "";
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }

        private string getFormattedDataComplete(int pLineNo)
        {
            try
            {
                return data_By_Line[pLineNo].Trim();

            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string data = LoadDatafromPdf(SRC);


                if (data == "ERR")
                {
                    return;
                }

                if (data == "FNF")
                {
                    commonLib.showUIMessage("E-Ravaana file not found for processing, Place the Ravaana File at location " + SRC + " and try again !!!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }


                if (data != null)
                {
                    // set data source to null

                    //Ravanna data list 
                    lRavanaaData.Clear();

                    // check if file is of correct format
                    if (!checkFileformatNew(data))
                    {
                        commonLib.showUIMessage("Input file is not of correct format , check the file and try again!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ControlEnableDisable(false);
                        return;

                    }
                    ControlEnableDisable(true);
                    loadDataUI();
                    btnGenerateInvoice.Enabled = true;
                    btnCreateAccount.Enabled = true;
                }
                else
                {
                    commonLib.showUIMessage("Data Not found for Invoice!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ControlEnableDisable(false);

                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }




        private void txtRatePerTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void TxtCommision_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);

        }

        private void TxtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);

        }

        private void TxtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressNumber(e);

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
                decimal ActualAmountPaybale;
                decimal TotaTaxInvAmt;
                int InvoiceNo;

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
                    if (strBuyerName.ToUpper() == "CASH" )
                    {
                        chkPaymentMade.Checked = true;
                    }
                    else
                    {
                        chkPaymentMade.Checked = false;
                    }

                }

                CalulateTotalAmount();

                ActualAmountPaybale = (ActualSaleRate * ActualSaleQty) + Global.gSGSTAmt + Global.gCGSTAmt + Global.gIGSTAmt + TotalInwardCharges;
                ActualAmountPaybale = Math.Round(ActualAmountPaybale, 0);

                strConfirmation = "You are about to generate an Invoice with the below Details" + Environment.NewLine +
                                  "Actual Rate :" + ActualSaleRate.ToString() + Environment.NewLine +
                                  "Actual Quantity: " + ActualSaleQty.ToString() + Environment.NewLine +
                                  "Good Value :" + (commonLib.fnCheckDecimal(txtRatePerTon.Text) * Global.gInvoiceQty).ToString() + Environment.NewLine +
                                  "Tax payable: " + (Global.gIGSTAmt + Global.gCGSTAmt + Global.gSGSTAmt).ToString() + Environment.NewLine +
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

                string strDate = Global.gDispatchDateTime.Substring(0, 10);
                DateTime InvoiceDate;

                //strDate = strDate.Replace('-', '/');
                //InvoiceDate = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                InvoiceDate = commonLib.ConvertStringtoDate(strDate);
                //DateTime date = DateTime.ParseExact(Date, "dd/MM/YYYY", null);

                // make entries to database

                InvoiceNo = commonLib.fnCheckNull(txtInvoiceNo.Text);
                InvoiceDetails objInvoice = new InvoiceDetails();
                objInvoice.InvoiceNo = InvoiceNo;
                objInvoice.InvoiceNoVisible = (Global.gInvNoPrefix + InvoiceNo.ToString());
                objInvoice.InvoiceDate = InvoiceDate;
                objInvoice.DispatchDateTime = Global.gDispatchDateTime;
                objInvoice.RavannaNo = Global.gRavaanaNo;
                objInvoice.TruckNo = Global.gVechileNo;
                objInvoice.SellerName = Global.gSellerName;
                objInvoice.SellerAdd1 = Global.gSellerAdd1;
                objInvoice.SellerAdd2 = Global.gSellerAdd2;
                objInvoice.SellerAdd3 = Global.gSellerAdd3;
                objInvoice.SellerGSTIN = Global.gSellerGSTIN;
                objInvoice.BuyerName = Global.gBuyerName.Trim();
                objInvoice.BuyerAdd1 = Global.gBuyerAddress;
                objInvoice.BuyerGSTIN = Global.gBuyerGST;
                objInvoice.ItemDesc = Global.gMaterial;
                objInvoice.HSNCode = Global.gHSNCode;
                objInvoice.ItemQty = Global.gInvoiceQty;
                objInvoice.ItemRate = Global.gItemUnitRate;
                objInvoice.ItemAmt = Math.Round((Global.gInvoiceQty * Global.gItemUnitRate), 0);
                TotaTaxInvAmt = Math.Round((Global.gInvoiceQty * Global.gItemUnitRate), 0);
                objInvoice.CGSTAmt = Math.Round(Global.gCGSTAmt, 2);
                if (Global.gCGSTAmt > 0)
                {
                    objInvoice.CGSTPer = commonLib.fnCheckDecimal(Global.gCgstTax);
                }
                objInvoice.SGSTAmt = Math.Round(Global.gSGSTAmt, 2);
                if (Global.gSGSTAmt > 0)
                {
                    objInvoice.SGSTPer = commonLib.fnCheckDecimal(Global.gSgstTax);
                }
                objInvoice.IGSTAmt = Math.Round(Global.gIGSTAmt, 2);
                if (Global.gIGSTAmt > 0)
                {
                    objInvoice.IGSTPer = commonLib.fnCheckDecimal(Global.gIgstTax);
                }

                TotaTaxInvAmt = Math.Round((TotaTaxInvAmt + Global.gCGSTAmt + Global.gSGSTAmt + Global.gIGSTAmt), 0);
                objInvoice.TotalInvAmt = TotaTaxInvAmt;
                objInvoice.TotalAmtWords = commonLib.ConvertWholeNumber(TotaTaxInvAmt.ToString());
                objInvoice.BankName = Global.gBankName;
                objInvoice.BankAccountNo = Global.gBankAccountNo;
                objInvoice.IfscCode = Global.gIfscCode;
                objInvoice.BankAdd1 = Global.gBankAdd1;
                objInvoice.BankAdd2 = Global.gBankAdd2;
                objInvoice.CertifyClause = Global.gCertifyClause;
                objInvoice.GeneralInstruction = Global.gInstruction;
                objInvoice.ActualItemQty = ActualSaleQty;
                objInvoice.ActualItemRate = ActualSaleRate;
                objInvoice.ActualItemAmt = Math.Round((ActualSaleRate * ActualSaleQty), 0);
                objInvoice.OtherInwardExpense = TotalInwardCharges;
                objInvoice.OtherOutwardExpense = TotalOutwordCharges;
                objInvoice.TotalAmtPayable = ActualAmountPaybale;
                objInvoice.TotalAmtCollected = ActualAmountPaybale - TotalOutwordCharges;
                objInvoice.AmountReceived = Math.Round(commonLib.fnCheckDecimal(txtAmountReceived.Text), 0);
                objInvoice.CheckDuplicateRavanna = "Y";
                objInvoice.InvoiceSource = InvoiceSource;
                objInvoice.ActualBuyerRk = ActualBuyerRk;
                objInvoice.Remark = "";
                objInvoice.CheckDuplicateInvoiceNo = Global.gCheckDuplicateInvoice;
                objInvoice.CreatedBy = Global.gUserID;
                //objInvoice.UOM = "MT";
                objInvoice.SlipItemRate = commonLib.fnCheckDecimal(txtItemSlipRate.Text);
                objInvoice.SlipItemQty= commonLib.fnCheckDecimal(txtSlipWeight.Text);
                string strReturn = objInvoice.GenerateInvoice();
                string strReturn1 = commonLib.ShowDBMessage(strReturn, "Y");

                // if there are issues do nothing and return from process
                if (strReturn1 == "0")
                {
                    return;
                }

                // once invoice record is created move Ravanna File to Processed Folder
                string ProcessedRavannaFileName = ProcessedFilePath + (commonLib.fnCheckNull(txtInvoiceNo.Text)) + "_" + RavannaFileName;
                string DuplicateRavannaFileName = DuplicateFilePath + (commonLib.fnCheckNull(txtInvoiceNo.Text)) + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + "_" + RavannaFileName;

                commonLib.MoveFile(SRC + RavannaFileName, ProcessedRavannaFileName, DuplicateRavannaFileName);


                //print invoice
                DocPrint.PrintInvoiceSlip(Global.gInvoiceRk, 1, InvoiceSource);
                PrintInvoice(Global.gInvoiceRk, "N"); // New Invoice
                Global.gInvoiceRk = -1;

                SetControlValueBlank();

            }


            catch (Exception ex)
            {
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
                string ExpenseType;

                ItemRatePerUnit = commonLib.fnCheckDecimal(txtRatePerTon.Text);
                ActualSaleQty = commonLib.fnCheckDecimal(txtActualSaleQty.Text);
                AmtToBeCollected = (ItemRatePerUnit * ActualSaleQty);
                AmtToBeCollected = AmtToBeCollected + Global.gCGSTAmt + Global.gSGSTAmt + Global.gIGSTAmt;

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

                AmtToBeCollected = AmtToBeCollected + TotalInwardCharges;

                AmtToBeCollected = Math.Round(AmtToBeCollected, 0);

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

        private void TxtActualSaleQty_TextChanged(object sender, EventArgs e)
        {
            CalculateExpenses();
            CalulateTotalAmount();
            txtSlipWeight.Text = txtActualSaleQty.Text;
        }

        private void TxtRatePerTon_TextChanged(object sender, EventArgs e)
        {
            CalculateExpenses();
            CalulateTotalAmount();
            txtItemSlipRate.Text = txtRatePerTon.Text;
        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                int iInvoiceNoColIndex = GridFunc.FindGridColumnIndex(grdInvoiceDetails, "InvoiceNo");
                string strPrintMessers = "Y";

                int PrintCopy = 1;
                string InvoiceNo = "";

                if (chkPrintMs.Checked == false)
                {
                    strPrintMessers = "N";
                }


                if (txtOldInvoiceNo.Text == "")
                {
                    commonLib.showUIMessage("Please enter the invoice no for re-printing!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tabMain.SelectedTab = tbView;
                    txtOldInvoiceNo.Focus();
                    return;
                }

                // find selected row for re-printing
                if (txtPrintCopy.Text != "")
                    PrintCopy = commonLib.fnCheckNull(txtPrintCopy.Text);

                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    Global.gInvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
                    InvoiceNo = grdInvoiceDetails.Rows[r.Index].Cells[iInvoiceNoColIndex].Value.ToString();

                    if (Global.gInvoiceRk == -1)
                    {
                        commonLib.showUIMessage("Please select a row for invoice re-printing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        // Invoice Print
                        if (chkPrintSlip.Checked == true)
                            DocPrint.PrintInvoiceSlip(Global.gInvoiceRk, 1, InvoiceSource);

                        if (chkPrintInvoice.Checked == true)
                            //PrintInvoice(Global.gInvoiceRk,"R");  // Reprint
                            DocPrint.PrintInvoice(Global.gInvoiceRk, InvoiceNo, PrintCopy, "", strPrintMessers);
                        Global.gInvoiceRk = -1;
                    }

                }
                                

                
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

        private void PrintInvoice(int pInvoiceRk, string pPrintFrom)
        {
            try
            {
                int PrintCopy;
                if (pInvoiceRk < 1)
                    return;

                frmInvoice objInvoice = new frmInvoice();
                if (txtPrintCopy.Text.Trim() == "")
                {
                    PrintCopy = 1;
                }
                else
                {
                    PrintCopy = commonLib.fnCheckNull(txtPrintCopy.Text);
                }
                objInvoice.PrintNoofCopies = PrintCopy;
                objInvoice.InvoiceRk = pInvoiceRk;
                objInvoice.InvoiceSource = InvoiceSource;
                // print related setting
                objInvoice.InvoicePrintHeightRatio = Global.gInvPrintHeightRatio;

                objInvoice.PrintCopy = txtPrintCopy.Text;


                string strCurrentFilePath = commonLib.GetInvoiceFilePath();
                string strDuplicateFilePath = commonLib.GetDuplicateInvoiceFilePath();
                string strInvFileSufix = Global.gInvFileSufix;
                string strBmpFileSufix = Global.gBmpFileSufix;
                string strBlankPDFTempFileName = Global.gBlankTemplate;

                string strBlankPDfSource;

                string strInvNo;
                string strInvFileName;
                string strbmpFileName;
                string strDuplicateInvFileName;

                if (pPrintFrom == "R")
                {
                    strInvNo = txtOldInvoiceNo.Text.Trim();
                }
                else
                {
                    strInvNo = txtInvoiceNo.Text.Trim();
                }
                // make current file Name
                strInvFileName = strCurrentFilePath + strInvNo + strInvFileSufix;
                strbmpFileName = strCurrentFilePath + strInvNo + strBmpFileSufix;
                strBlankPDfSource = strCurrentFilePath + strBlankPDFTempFileName;
                strDuplicateInvFileName = strDuplicateFilePath + strInvNo + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + strInvFileSufix;
                if (chkPrintMs.Checked == false)
                {
                    objInvoice.PrintMessers = "N";
                }

                objInvoice.GeneratePDGInvoice = GeneratePdfInvoice;
                if (GeneratePdfInvoice == "Y")
                {
                    objInvoice.InvoiceName = strInvFileName;
                    objInvoice.InvoiceBmpName = strbmpFileName;
                    objInvoice.DuplicateInvoiceName = strDuplicateInvFileName;
                    objInvoice.BlankPDfFileName = strBlankPDfSource;
                }
                else
                {
                    objInvoice.InvoiceName = strbmpFileName;
                    objInvoice.InvoiceBmpName = "";
                    objInvoice.BlankPDfFileName = "";
                }

                objInvoice.ShowDialog();
                commonLib.showUIMessage("Invoice printed Sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void txtOldInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

                if (commonLib.fnCheckNull1(txtOldInvoiceNo.Text).Contains(",") ==true)
                {
                    objInv.InvoiceNoList = commonLib.fnCheckNull1(txtOldInvoiceNo.Text);
                    objInv.InvoiceNo = -1;
                }
                else
                {
                    objInv.InvoiceNoList = "-";
                    objInv.InvoiceNo = commonLib.fnCheckNull(txtOldInvoiceNo.Text);
                }

                
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

        private void ChkOtherBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherBuyer.Checked == true)
            {
                cmbBuyer.Enabled = true;
            }
            else
            {
                cmbBuyer.SelectedIndex = -1;
                cmbBuyer.Enabled = false;
            }

        }

        private void FrmLoadRavaana_Load(object sender, EventArgs e)
        {
            //ChangeLanguage("hi");
            LoadDropDownData();

        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(frmLoadRavaana));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void LoadDropDownData()
        {
            commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ChkPaymentMade_CheckedChanged(object sender, EventArgs e)
        {
            AmountCollectedAuto();
        }

        private void TxtDriverPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressNumber(e);
        }

        private void TxtItemSlipRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmation;
                strConfirmation = "Do you want to clear down the unused files?";
                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    return;
                }

                string[] array1 = Directory.GetFiles(SRC, "e-*.pdf");

                foreach (string name in array1)
                {
                    commonLib.RemoveFile(name);
                }

                commonLib.showUIMessage("Directory cleaned up sucessfully !!! , Download the e-Ravaana from the mines website and try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string strBuyerName;
                string strReturn;

                strBuyerName = Interaction.InputBox("Account Name");

                if (strBuyerName.Trim() == "")
                {
                    commonLib.showUIMessage("Account Name is blank , Enter a valid account name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                BuyerManagement objBuyer = new BuyerManagement();
                objBuyer.AddFlag = true;

                objBuyer.BuyerRK = "-1";
                objBuyer.BuyerName = strBuyerName;

                objBuyer.IsActive = 1;
                objBuyer.Remarks = "Payment Account Name";
                objBuyer.CreatedBy = Global.gUserID;

                //Display Message
                strReturn = objBuyer.ManageBuyerDetails();
                commonLib.ShowDBMessage(strReturn);

                LoadDropDownData();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void txtSlipWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void chkPaymentMade_MouseClick(object sender, MouseEventArgs e)
        {
            AmountCollectedAuto();
        }
    }

}
