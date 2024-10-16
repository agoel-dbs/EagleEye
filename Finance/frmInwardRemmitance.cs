using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EagleEye.DBLayer;
using EagleEye.Lib;

namespace EagleEye.Operations
{
    public partial class frmInwardRemmitance : Form
    {
        Boolean bFormLoad = false;
        int BuyerRk;
        string LedgerHistoryMonths;
        public frmInwardRemmitance()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Payment Received - Entry");
        }

        private void FrmInwardRemmitance_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }
        private void LoadDropDownData()
        {
            try
            {
                ParameterDetails objParam = new ParameterDetails();
                objParam.ParaCode = "LEDGER_HIS_MONTH";
                LedgerHistoryMonths = objParam.GetParameterValue();

                commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");
                commonLib.PopulateParamMasterCombo(cmbModeOfPayment, "N", " para_group = 'PAYMENT_MODE' ", "N");
                dtTransasactionDate.MaxDate = DateTime.Now;
                dtTransasactionDate.Value = DateTime.Now.AddDays(-1);
                lblLedgerHis.Text = "Ledger History - Past " + LedgerHistoryMonths  + " months";
                rtxtRemarks.Text = "Payment";
                cmbModeOfPayment.Text = "Cash";
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

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                BuyerRk = commonLib.fnCheckNull(cmbBuyer.SelectedValue.ToString());
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
                    LedgerHisMonth =  commonLib.fnCheckNull(LedgerHistoryMonths) * -1;
                }


                InwardPayment objInward = new InwardPayment();
                DashboardRep objDashboard = new DashboardRep();

                objInward.BuyerRk = BuyerRk;

                // payment details
                GridFunc.PopulateDataGrid(grdDetails, objInward.GetCustomerPaymentDetails());

                //as on date balance
                objDashboard.BuyerRk = BuyerRk;
                //objDashboard.ToDate = DateTime.Now.ToString("yyyy-MM-dd");
                //objDashboard.FromDate = DateTime.Now.AddMonths(LedgerHisMonth).ToString("yyyy-MM-dd");

                objDashboard.ToDate = commonLib.ReportingDateStringHHMMSS(DateTime.Now);
                objDashboard.FromDate = commonLib.ReportingDateStringHHMMSS(DateTime.Now.AddMonths(LedgerHisMonth));


                GridFunc.PopulateDataGrid(grdOutstandingDetails, objDashboard.GetCustomerOutstandingBalance());

                if (grdOutstandingDetails.RowCount > 0)
                {
                    lblOutstanding.Text = "OS Balance: " + grdOutstandingDetails.Rows[0].Cells[1].Value.ToString()
                                           + " - " + grdOutstandingDetails.Rows[0].Cells[2].Value.ToString();
                }

                // LedgerHistory
                GridFunc.PopulateDataGrid(grdPartyLedgerHis, objDashboard.GetCustomerLedgerHistory());


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

                if (BuyerRk < 1)
                {
                    commonLib.showUIMessage("Select a Buyer for payment posting!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                TranAmount = commonLib.fnCheckDecimal(txtAmount.Text.ToString());

                if (TranAmount == 0)
                {
                    commonLib.showUIMessage("Enter the transaction amount!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtAmount.Focus();
                    return;

                }

                strConfirmation = "You are about to post a payment entry , this is a irreversible process , do you want to proceed ?";
                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                //set DB Class Parameteres
                InwardPayment objInward = new InwardPayment();

                objInward.BuyerRk= BuyerRk;
                objInward.TranAmt = commonLib.fnCheckDecimal(txtAmount.Text.ToString());
                objInward.TranDate = commonLib.ReportingDateStringHHMMSS(dtTransasactionDate);
                objInward.InstrumentNo = txtChequeNo.Text.ToString();
                objInward.PaymentMode = cmbModeOfPayment.SelectedValue.ToString();
                objInward.InwardRemarks= rtxtRemarks.Text.ToString();
                objInward.CreatedBy = Global.gUserID;

                //Display Message
                strReturn = objInward.PostPaymentEntry();
                commonLib.ShowDBMessage(strReturn);
                PopulateDetails();

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
