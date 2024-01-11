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

namespace EagleEye.Finance
{
    public partial class frmOutwordRemmitance : Form
    {
        Boolean bFormLoad = false;
        int VendorRk;
        int SubHeadRk;
        string SubHeadDesc;
        string LedgerHistoryMonths;

        public frmOutwordRemmitance()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Expense / Vendor Payment - Entry");
        }

        private void FrmOutwordRemmitance_Load(object sender, EventArgs e)
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

                commonLib.PopulateExpenseHeadCombo(cmbExpenseHead, "N", " exp_group = 'VENDOR_PAYMENT' ", "N");
                commonLib.PopulateVendorCombo(cmbVendor, "N", "", "N");
                commonLib.PopulateParamMasterCombo(cmbModeOfPayment, "N", " para_group = 'PAYMENT_MODE' ", "N");
                dtTransasactionDate.MaxDate = DateTime.Now;
                lblLedgerHis.Text = "Ledger History - Past " + LedgerHistoryMonths + " months";

                dtTransasactionDate.Value = DateTime.Now.AddDays(-1);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        private void CmbExpenseHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                SubHeadRk = commonLib.fnCheckNull(cmbExpenseHead.SelectedValue.ToString());
                SubHeadDesc = commonLib.GetComboSelectedText(cmbExpenseHead);
                //LoadDetails();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try

            {
                if (bFormLoad == false)
                    return;
                VendorRk = commonLib.fnCheckNull(cmbVendor.SelectedValue.ToString());
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

                OutwardPayment objOutward = new OutwardPayment();

                objOutward.VendorRk = VendorRk;
                // payment details
                GridFunc.PopulateDataGrid(grdDetails, objOutward.GetVendorPaymentDetails());


                //as on date balance
                DashboardRep objDB = new DashboardRep();
                objDB.VendorRk = VendorRk;
                objDB.ToDate =  commonLib.ConvertTranDateFormat(DateTime.Now);
                //objDB.FromDate = DateTime.Now.AddMonths(LedgerHisMonth).ToString("yyyy-MM-dd");
                objDB.FromDate = commonLib.ConvertTranDateFormat(DateTime.Now.AddMonths(LedgerHisMonth));

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

                // LedgerHistory
                
                GridFunc.PopulateDataGrid(grdPartyLedgerHis, objDB.GetVendorLedgerHistory());


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimalMinus(e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TranAmount;
                string strReturn;
                string strConfirmation;

                CalculatePostingAmount();

                if (VendorRk < 1)
                {
                    commonLib.showUIMessage("select the Vendor for the payment posting!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbVendor.Focus();
                    return;
                }

                if (SubHeadRk < 1)
                {
                    commonLib.showUIMessage("select the Head under which payment is being made!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbExpenseHead.Focus();
                    return;
                }


                TranAmount = commonLib.fnCheckDecimal(txtAmount.Text.ToString());

                if (TranAmount == 0)
                {
                    commonLib.showUIMessage("Enter the transaction amount!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtAmount.Focus();
                    return;

                }



                strConfirmation = "You are about to post a payment entry made to vendor, this is a irreversible process , do you want to proceed ?";
                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                //set DB Class Parameteres
                OutwardPayment objOutword = new OutwardPayment();

                objOutword.VendorRk = VendorRk;
                objOutword.SubHeadRk = SubHeadRk;
                objOutword.SubHeadDesc = SubHeadDesc;
                objOutword.TranAmt = commonLib.fnCheckDecimal(txtAmount.Text.ToString());
                objOutword.TranDate = commonLib.ReportingDateStringHHMMSS(dtTransasactionDate);
                objOutword.InstrumentNo = txtChequeNo.Text.ToString();
                objOutword.PaymentMode = cmbModeOfPayment.SelectedValue.ToString();
                objOutword.Remarks = rtxtRemarks.Text.ToString();
                objOutword.CreatedBy = Global.gUserID;

                //Display Message
                strReturn = objOutword.PostOutwardPaymentEntry();
                commonLib.ShowDBMessage(strReturn);

                // refresh form
                PopulateDetails();
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

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void txtAmt_Leave(object sender, EventArgs e)
        {
            CalculatePostingAmount();
        }

        private void CalculatePostingAmount()
        {
            if (rdPaid.Checked == true)
            {
                txtAmount.Text = txtAmt.Text;
            }
            if (rdReceived.Checked == true)
            {
                txtAmount.Text = (commonLib.fnCheckDecimal(txtAmt.Text) * -1).ToString();
            }

        }

        private void rdPaid_Click(object sender, EventArgs e)
        {
            CalculatePostingAmount();
        }

        private void rdReceived_Click(object sender, EventArgs e)
        {
            CalculatePostingAmount();
        }
    }
}
