using EagleEye.DBLayer;
using EagleEye.Lib;
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
    public partial class frmSupplierBill : Form
    {
        Boolean bFormLoad = false;
        int VendorRk = -1;
        string LedgerHistoryMonths;
        public frmSupplierBill()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Supplier Bill- Entry");
        }

        private void FrmSupplierBill_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;

        }

        private void LoadDropDownData()
        {
            try
            {
                ParameterDetails objParam = new ParameterDetails();
                objParam.ParaCode = "VENDOR_HIS_MONTH";
                LedgerHistoryMonths = objParam.GetParameterValue();

                commonLib.PopulateVendorCombo(cmbVendor, "N", "", "N");
                commonLib.PopulateExpenseHeadCombo(cmbHead, "N", " exp_group = 'VENDOR_PAYMENT' ", "N");
                commonLib.PopulatePurchaseItemCombo(cmbItem, "N", "", "");

                dtBillDate.Value = DateTime.Now;
                dtBillDate.MaxDate = DateTime.Now.AddDays(-1);
                
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

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {

               // string VendorRk;
                string HeadRk;
                string BillNo;
                string BillDate;
                decimal BillAmount;
                decimal CGST;
                decimal SGST;
                decimal IGST;
                string BillDetails;
                string Remarks;
                string strConfirmation;
                string strReturn;
                string ItemRk;
                decimal ItemQty= 0;
                decimal UnitRate =0;
                decimal TotalAmount =0;

                //VendorRk = commonLib.GetComboSelectedValue(cmbVendor);
                HeadRk = commonLib.GetComboSelectedValue(cmbHead);
                BillAmount = commonLib.fnCheckDecimal(txtBillAmt.Text);
                BillNo = txtBillNo.Text;

                if (VendorRk < 0 )
                {
                    commonLib.showUIMessage("Please select vendor!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbVendor.Focus();
                    return;
                }
                if (HeadRk == "")
                {
                    commonLib.showUIMessage("Please select the Expense head!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbHead.Focus();
                    return;
                }

                if (BillAmount <= 0)
                {
                    commonLib.showUIMessage("Please enter the Bill amount!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBillAmt.Focus();
                    return;
                }

                ItemRk = commonLib.GetComboSelectedValue(cmbItem);

                if ( ItemRk != "")
                {
                    ItemQty = commonLib.fnCheckDecimal(txtItemQty.Text);
                    UnitRate = commonLib.fnCheckDecimal(txtItemRate.Text);

                    if (ItemQty == 0)
                    {
                        commonLib.showUIMessage("Please enter the item quantity !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtItemQty.Focus();
                        return;

                    }
                    if (UnitRate == 0)
                    {
                        commonLib.showUIMessage("Please enter the item quantity !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtItemRate.Focus();
                        return;
                    }

                }


                strConfirmation = "A new supplier bill will be created!!!";

                if (chkPaidtoVendor.Checked == true)
                {
                    strConfirmation = strConfirmation  + Environment.NewLine + "Vendor account will be credited with the bill amount.";

                }
                strConfirmation = strConfirmation + Environment.NewLine + " Do you want to proceed?";

                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                BillDate = commonLib.ReportingDateStringHHMMSS(dtBillDate);
                IGST = commonLib.fnCheckDecimal(txtIGST.Text);
                CGST = commonLib.fnCheckDecimal(txtCGST.Text);
                SGST = commonLib.fnCheckDecimal(txtSGST.Text);
                BillDetails = txtBillDetails.Text;
                Remarks = rtxtRemarks.Text;


                SupplierBill objSupplier = new SupplierBill();
                objSupplier.VendorRk = commonLib.fnCheckNull(VendorRk);
                objSupplier.HeadRk = commonLib.fnCheckNull(HeadRk);
                objSupplier.HeadDesc = cmbHead.GetItemText(this.cmbHead.SelectedItem);
                objSupplier.BillNo = BillNo;
                objSupplier.BillDate= BillDate;
                objSupplier.ItemRk = commonLib.fnCheckNull(ItemRk);
                objSupplier.ItemQty = ItemQty;
                objSupplier.ItemRate = UnitRate;
                objSupplier.BillAmount = BillAmount;
                objSupplier.CGST= CGST;
                objSupplier.SGST = SGST;
                objSupplier.IGST = IGST;
                objSupplier.BillDetails = BillDetails;
                objSupplier.Remarks= Remarks;
                strReturn  = objSupplier.PostSupplierBill();

                commonLib.ShowDBMessage(strReturn);

                int InfoType = commonLib.GetInformationType(strReturn); // spilt string and get error no
                if (InfoType < Global.gErrorNoLowerLimit)
                {

                    if (chkPaidtoVendor.Checked == true)
                    {
                        OutwardPayment objOutword = new OutwardPayment();
                        objOutword.VendorRk = VendorRk;
                        objOutword.SubHeadRk = commonLib.fnCheckNull(HeadRk);
                        objOutword.SubHeadDesc = cmbHead.GetItemText(this.cmbHead.SelectedItem);
                        objOutword.TranAmt = BillAmount;
                        objOutword.TranDate = BillDate;
                        objOutword.InstrumentNo = "";
                        objOutword.PaymentMode = "CASH";
                        objOutword.Remarks = "Details:" + Remarks + ", Payment done (Auto)";
                        objOutword.CreatedBy = Global.gUserID;

                        //Display Message
                        strReturn = objOutword.PostOutwardPaymentEntry();
                        commonLib.ShowDBMessage(strReturn);
                    }
                }

                // refresh form
                PopulateDetails();

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }

        private void TxtBillAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimalMinus(e);
        }

        private void TxtCGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void TxtSGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        
        private void TxtIGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void CmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                VendorRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbVendor));
                PopulateDetails();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void PopulateDetails()
        {
            try
            {
                LoadDetails();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LoadDetails()
        {
            try
            {

                int LedgerHisMonth;

                if (LedgerHistoryMonths == "")
                {
                    LedgerHisMonth = -3;
                }
                else
                {
                    LedgerHisMonth = commonLib.fnCheckNull(LedgerHistoryMonths) * -1;
                }

                // Bill details
                DashboardRep objDB = new DashboardRep();
                objDB.VendorRk= VendorRk;
                objDB.ToDate = DateTime.Now.ToString("yyyy-MM-dd");
                objDB.FromDate = DateTime.Now.AddMonths(LedgerHisMonth).ToString("yyyy-MM-dd");

                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(DateTime.Now);
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(DateTime.Now.AddMonths(LedgerHisMonth));

                GridFunc.PopulateDataGrid(grdBillDetails, objDB.GetSupplierBillHistory());

                //OS Balance
                GridFunc.PopulateDataGrid(grdOutstandingDetails, objDB.GetVendorOutstandingBalance());
                if (grdOutstandingDetails.RowCount > 0)
                {
                    lblOutstanding.Text = "OS Balance: " + grdOutstandingDetails.Rows[0].Cells[1].Value.ToString()
                                           + " - " + grdOutstandingDetails.Rows[0].Cells[2].Value.ToString();
                }
                else
                {
                    lblOutstanding.Text = "OS Balance: - ";
                }


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void   CalculateBillAmount()
        {
            txtBillAmt.Text = Math.Round(commonLib.fnCheckDecimal(txtItemQty.Text) * commonLib.fnCheckDecimal(txtItemRate.Text), 2).ToString();

        }

        private void TxtItemQty_TextChanged(object sender, EventArgs e)
        {
            CalculateBillAmount();
        }

        private void TxtItemRate_TextChanged(object sender, EventArgs e)
        {
            CalculateBillAmount();
        }

        private void TxtItemQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void TxtItemRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        
        private void txtBillNo_Leave(object sender, EventArgs e)
        {
            rtxtRemarks.Text = txtBillNo.Text + " Expense";
        }
    }
}
