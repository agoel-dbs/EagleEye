using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace EagleEye.Print
{
    public partial class frmPrintBill : Form
    {

        public int InvoiceRk { get; set; }

        public int PrintNoofCopies { get; set; }

        public string InvoiceSource { get; set; }
        //public decimal pix
        public frmPrintBill()
        {
            InitializeComponent();
        }

        
        private void fnResizeForm()
        {
            try
            {
                double ResizeFactor = Convert.ToDouble(Global.gInvPrintHeightRatio);
                tpInvoiceInfo.Height = commonLib.fnCheckNull(tpInvoiceInfo.Height * (ResizeFactor));

                tplInvoiceInfoDup.Top = tpInvoiceInfo.Top + tpInvoiceInfo.Height + 75;
                tplInvoiceInfoDup.Height = commonLib.fnCheckNull(tplInvoiceInfoDup.Height * (ResizeFactor));

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
                InvoiceDetails objInvoice = new InvoiceDetails();
                decimal TaxAmount = 0;
                decimal LoadingAmount; ;
                decimal SlipItemAmount;
                decimal SlipTotalAmount;
                objInvoice.InvoiceRk = InvoiceRk;
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

                // Slip rate might be different than actual sale rate

                SlipItemAmount = Math.Round((commonLib.fnCheckDecimal(row["slip_item_rate"].ToString()) *
                                       commonLib.fnCheckDecimal(row["slip_item_qty"].ToString())), 0);

                //LoadingAmount = commonLib.fnCheckDecimal(row["other_inward_expense"].ToString());
                LoadingAmount = Math.Round(50 *
                                       commonLib.fnCheckDecimal(row["slip_item_qty"].ToString()), 0); ;

                lblDate.Text = row["dispatch_date_time"].ToString();
                lblBuyer.Text = row["buyer_name"].ToString() + '/' +  row["account_name"].ToString();
                lblTruckNo.Text = row["truck_no"].ToString();
                lblRate.Text = row["slip_item_rate"].ToString();
                lblQty.Text = row["slip_item_qty"].ToString();
                lblItemAmount.Text = SlipItemAmount.ToString();

                TaxAmount = commonLib.fnCheckDecimal(row["cgst_amt"].ToString())
                            + commonLib.fnCheckDecimal(row["sgst_amt"].ToString()) 
                                + commonLib.fnCheckDecimal(row["igst_amt"].ToString());
                
                lblTaxAmount.Text = TaxAmount.ToString();

                lblLoading.Text = LoadingAmount.ToString();
                SlipTotalAmount = Math.Round((SlipItemAmount + TaxAmount + LoadingAmount),0);
                lblTotalAmount.Text = SlipTotalAmount.ToString();


                // loading amount of our slip 

                LoadingAmount = Math.Round(50 *
                       commonLib.fnCheckDecimal(row["actual_item_qty"].ToString()), 0); ;

                lblDateDup.Text = row["dispatch_date_time"].ToString();
                lblBuyerDup.Text = row["buyer_name"].ToString() + '/' + row["account_name"].ToString();
                lblTruckNoDup.Text = row["truck_no"].ToString();
                lblRateDup.Text = row["actual_item_rate"].ToString();
                lblQtyDup.Text = row["actual_item_qty"].ToString();
                lblItemAmountDup.Text = row["actual_item_amt"].ToString();
                lblTaxAmountDup.Text = TaxAmount.ToString();
                lblLoadingDup.Text = LoadingAmount.ToString();
                lblTotalAmountDup.Text = row["total_amt_payable"].ToString();
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

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            try
            {
                fnResizeForm();
                loadInvoiceData();
                PrintInvoice();
                this.Close();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void PrintInvoiceDoc_PrintPage(object sender, PrintPageEventArgs e)
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
    }

}
