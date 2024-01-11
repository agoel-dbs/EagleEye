using EagleEye.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye.Lib
{
    class DocPrint
    {
        
        public static void PrintInvoiceSlip(int pInvoiceRk ,int pPrintCopy,string pInvoiceSource)
        {
            try
            {
                // if client doens not want tto print the invoice slip
                if (Global.gPrintInvoiceSlip == "N")
                    return;

                if (pInvoiceRk < 1)
                {
                    commonLib.showUIMessage("Nothing to Print!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    
                frmPrintBill objPrintBill = new frmPrintBill();
                objPrintBill.PrintNoofCopies = pPrintCopy;
                objPrintBill.InvoiceRk = pInvoiceRk;
                objPrintBill.InvoiceSource = pInvoiceSource;
                objPrintBill.ShowDialog();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public static void PrintInvoice(int pInvoiceRk, string pInvoiceNo , int pPrintCopy , string pInvoiceSource,string pPrintMessers)
        {
            try
            {
                int PrintCopy;
                if (pInvoiceRk < 1)
                    return;

                frmInvoice objInvoice = new frmInvoice();
                PrintCopy = pPrintCopy;
                objInvoice.PrintNoofCopies = PrintCopy;
                objInvoice.InvoiceRk = pInvoiceRk;
                objInvoice.InvoiceSource = pInvoiceSource;
                objInvoice.PrintMessers = pPrintMessers;
                // print related setting
                objInvoice.InvoicePrintHeightRatio = Global.gInvPrintHeightRatio;

                objInvoice.PrintCopy = pPrintCopy.ToString();


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


                strInvNo = pInvoiceNo.ToString();
                
                // make current file Name
                strInvFileName = strCurrentFilePath + strInvNo + strInvFileSufix;
                strbmpFileName = strCurrentFilePath + strInvNo + strBmpFileSufix;
                strBlankPDfSource = strCurrentFilePath + strBlankPDFTempFileName;
                strDuplicateInvFileName = strDuplicateFilePath + strInvNo + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + strInvFileSufix;

                objInvoice.GeneratePDGInvoice = Global.gGeneratePdfInvoice;
                if (Global.gGeneratePdfInvoice == "Y")
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

    }
}
