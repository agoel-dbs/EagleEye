using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace EagleEye
{
    public partial class frmInvoice : Form
    {

        public int InvoiceRk { get; set; }
        
        // printer propoerties

        public string InvoicePrintHeightRatio { get; set; }

        public string PrintCopy { get; set; }

        public string InvoiceName { get; set; }

        public string DuplicateInvoiceName { get; set; }
        public string InvoiceBmpName { get; set; }

        public string BlankPDfFileName { get; set; }

        public string GeneratePDGInvoice{ get; set; }

        public int PrintNoofCopies { get; set; }

        public string InvoiceSource { get; set; }

        public string PrintMessers { get; set; } = "Y";
        //public decimal pix
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            try
            {

                SetClientLogo();

                fnResizeForm();
                loadInvoiceData();
                PrintInvoice();
                this.Close();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message,MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SetClientLogo()
        {
            try
            {
                string strFilePath = "";
                if (ConfigurationManager.AppSettings.Get("CONFIG_DB_PATH").Trim() == "Y")
                {

                    strFilePath = ConfigurationManager.AppSettings.Get("COMPANY_LOGO").Trim();
                }
                else
                {
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                    strFilePath = projectDirectory.Replace("\\", "/") + "/Images/Company_logo.png";
                }
                //picLogo.Image = Image.FromFile(strFilePath);
            }
            catch (Exception ex)
            {

            }
        }

        private void fnResizeForm()
        {
            try
            {
                double ResizeFactor = Convert.ToDouble(InvoicePrintHeightRatio);
                tpInvoiceInfo.Height = commonLib.fnCheckNull(tpInvoiceInfo.Height * (ResizeFactor));

                tplBuyerInfo.Top = tpInvoiceInfo.Top + tpInvoiceInfo.Height;
                tplBuyerInfo.Height = commonLib.fnCheckNull(tplBuyerInfo.Height * (ResizeFactor));

                tplMaterialInfo.Top = tplBuyerInfo.Top + tplBuyerInfo.Height;
                tplMaterialInfo.Height = commonLib.fnCheckNull(tplMaterialInfo.Height * (ResizeFactor));

                tplTaxInfo.Top = tplMaterialInfo.Top + tplMaterialInfo.Height;
                tplTaxInfo.Height = commonLib.fnCheckNull(tplTaxInfo.Height * (ResizeFactor));

                tplOtherInfo.Top = tplTaxInfo.Top + tplTaxInfo.Height;
                tplOtherInfo.Height = commonLib.fnCheckNull(tplOtherInfo.Height * (ResizeFactor));

                pnlInvoice.Height = commonLib.fnCheckNull(pnlInvoice.Height * (ResizeFactor));
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void loadInvoiceData()
        {
            try
            {
                // load data from database for the invoice no

                DataTable DT;
                string strUOM = "";
                InvoiceDetails objInvoice = new InvoiceDetails();
                objInvoice.InvoiceRk= InvoiceRk;
                objInvoice.InvoiceSource = InvoiceSource;
                DT = objInvoice.GetInvoiceDetails();
                if (DT.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Invoice Information not found , Try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
                // will return one row
                DataRow row = DT.Rows[0];
                //foreach (DataRow row in DT.Rows)
                //{

                if (Global.gPrintRavannaNo == "Y")
                {
                    if (row["inv_changed"].ToString() == "0")
                    {
                        //lblRavannaNo.Text = "Ravaana No:" + row["ravanna_no"].ToString();
                    }
                    else
                    {
                        //lblRavannaNo.Text = "";
                    }
                }

                strUOM = row["UOM"].ToString();

                lblInvoiceNoValue.Text = "Invoice No: " + row["invoice_no_visible"].ToString();
                lblInvDateVal.Text = "Dispatch Time: " + row["dispatch_date_time"].ToString();
                lblTruckNo.Text = "Vechile No: " + row["truck_no"].ToString();

                //Seller Info
                lblSellerName.Text = "Seller: M/s " + row["seller_name"].ToString();
                lblSellerAdd1.Text = "Addrees: " +  row["seller_add1"].ToString();
                lblSellerAdd2.Text = row["seller_add2"].ToString(); 
                lblSellerAdd3.Text = row["seller_add3"].ToString() ;
                lblSellerGSTNo.Text = "GSTIN:" + row["seller_gstin"].ToString();

                // buyer Info
                if (PrintMessers == "Y")
                {
                    lblBuyerName.Text = "Buyer: M/s " + row["buyer_name"].ToString();
                }
                else
                {
                    lblBuyerName.Text = "Buyer: " + row["buyer_name"].ToString();
                }

                //lblBuyerAdd1.Text = "Address/Destination: " + row["buyer_add1"].ToString() + row["buyer_add2"].ToString(); 
                //lblBuyerGSTIN.Text = "GSTIN: " + row["buyer_GSTIN"].ToString();
                    
                lblBuyerAdd1.Text = "Addrees: " + row["buyer_add1"].ToString();
                lblBuyerAdd2.Text = commonLib.fnCheckNull1(row["buyer_add2"].ToString());
                lblBuyerAdd3.Text = commonLib.fnCheckNull1(row["buyer_add3"].ToString());
                lblBuyerGSTIN.Text = "GSTIN:" + commonLib.fnCheckNull1(row["buyer_gstin"].ToString());

                // Ship to 

                if (commonLib.fnCheckNull(row["is_ship_to_buyer"].ToString()) == 1)
                {
                    lblShiptoName.Text = "Ship To: Same As Buyer";
                    lblShiptoAdd1.Text = "Addrees: Same As Buyer";
                    lblShiptoAdd2.Text = "";
                    lblShiptoAdd3.Text = "";
                    lblShiptoGSTIN.Text = "GSTIN:: Same As Buyer";
                }   
                else
                {
                    if (PrintMessers == "Y")
                    {
                        lblShiptoName.Text = "Ship To: M/s " + row["ship_to_name"].ToString();
                    }
                    else
                    {
                        lblShiptoName.Text = "Ship To: " + row["ship_to_name"].ToString();
                    }


                    lblShiptoAdd1.Text = "Addrees: " + row["ship_to_add1"].ToString();
                    lblShiptoAdd2.Text = commonLib.fnCheckNull1(row["ship_to_add2"].ToString());
                    lblShiptoAdd3.Text = commonLib.fnCheckNull1(row["ship_to_add3"].ToString());
                    lblShiptoGSTIN.Text = "GSTIN:" + commonLib.fnCheckNull1(row["ship_to_gstin"].ToString());
                }


                ///Item
                ///
                lblInvUOM.Text = "Qty (" + strUOM + ")";

                lblItemDesc.Text = row["item_desc"].ToString(); 
                lblHSN.Text = row["hsn_code"].ToString(); 
                lblInvQty.Text = row["item_qty"].ToString(); 
                lblInvAmt.Text = "Rs." + row["item_Amt"].ToString() 
                                + " [@Rate/"+ strUOM + " "  + row["item_rate"].ToString() 
                                + "]";  

                // Tax Details

                lblBeforeTaxAmt.Text = row["item_Amt"].ToString();
                lblTotalAmtWord.Text = "Amount in Words : " +
                                        row["total_amt_words"].ToString() 
                                        +" Only";

                if (commonLib.fnCheckDecimal(row["cgst_amt"].ToString()) > 0 )
                {
                    lblCGST.Text = "CGST @" + row["cgst_per"].ToString() + "%";
                    lblCGSTAmt.Text = row["cgst_amt"].ToString();
                    lblSGST.Text = "SGST @" + row["sgst_per"].ToString() + "%";
                    lblSGSTAmt.Text = row["sgst_amt"].ToString(); ;
                }
                else
                {
                    lblIGST.Text = "IGST @" + row["igst_per"].ToString() + "%";
                    lblIGSTAmt.Text = row["igst_amt"].ToString();
                }
                lblTotalAmt.Text = row["total_inv_amt"].ToString();


                // bank details
                lblBankName.Text = "Name:" + row["bank_name"].ToString()
                                        + ",IFSC: " +
                                            row["ifsc_code"].ToString();
                lblAccountDetail.Text = "A/c No: " + 
                                            row["bank_account_no"].ToString() +
                                            " , " + row["bank_add1"].ToString();

                lblCertify.Text = row["certify_clause"].ToString();

                lblSellerSign.Text = "for " + row["seller_name"].ToString();
                lblInstruction.Text = row["general_instruction"].ToString();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        
        private void PrintInvoiceDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Rectangle pagearea = e.PageBounds;
                e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.pnlInvoice.Width / 2), this.pnlInvoice.Location.Y);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void PrintInvoice()
        {
            try
            {
                Print(this.pnlInvoice);
                MemoryImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                MemoryImage.Save(InvoiceBmpName, ImageFormat.Jpeg);
                if (GeneratePDGInvoice == "Y")
                {
                    commonLib.CreatePDFDocument(BlankPDfFileName, InvoiceName, InvoiceBmpName,DuplicateInvoiceName);
                    commonLib.RemoveFile(InvoiceBmpName);
                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        private void BtnPrintInv_Click(object sender, EventArgs e)
        {
            try
            {
                PrintInvoice();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            try
            {
                MemoryImage = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (MemoryImage != null)
                {
                    e.Graphics.DrawImage(MemoryImage, 0, 0);
                    base.OnPaint(e);
                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
       
        public void Print(Panel pnl)
        {
            try
            {
                pnlInvoice = pnl;
                GetPrintArea(pnl);
                PrinterSettings ps = new PrinterSettings();
                ps.Copies = Convert.ToInt16(PrintNoofCopies);
                //IEnumerable paperSizes = ps.PaperSizes.Cast;
                //IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
                //PaperSize printPaperSize = paperSizes.First(size => size.Kind == PaperKind.A4);
                //printInvoiceDoc.DefaultPageSettings.PaperSize = printPaperSize;
                //PaperSize pkCustomSize1 = new PaperSize("First custom size", 502, 801);
                //printInvoiceDoc.DefaultPageSettings.PaperSize = pkCustomSize1;
                printInvoiceDoc.DefaultPageSettings.PrinterSettings.Copies = ps.Copies;
                printInvoicePreview.Document = printInvoiceDoc;
                //printInvoicePreview.ShowDialog();
                printInvoiceDoc.Print();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
