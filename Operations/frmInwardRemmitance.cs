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
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "buyer_master";
                objCommonDBFunc.CodeColumnName = "buyer_rk";
                objCommonDBFunc.DisplayColumnName = "name";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = "";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbBuyer, false);

                objCommonDBFunc.TableName = "param_master";
                objCommonDBFunc.CodeColumnName = "para_code";
                objCommonDBFunc.DisplayColumnName = "para_value";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = " para_group = 'PAYMENT_MODE'";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbModeOfPayment, false);


                dtTransasactionDate.MaxDate = DateTime.Now;
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
                BuyerRk = Convert.ToInt16(cmbBuyer.SelectedValue.ToString());
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
                DataTable DT;
                InwardPayment objInward = new InwardPayment();
                objInward.BuyerRk = BuyerRk;
                // payment details
                DT = objInward.GetCustomerPaymentDetails();
                GridFunc.PopulateDataGrid(grdDetails,DT);

                //as on date balance
                DT = objInward.GetCustomerOutstandingBalance();
                GridFunc.PopulateDataGrid(grdOutstandingDetails, DT);
                if (grdOutstandingDetails.RowCount > 0)
                {
                    lblOutstanding.Text = "OS Balance: " + grdOutstandingDetails.Rows[0].Cells[1].Value.ToString()
                                           + " - " + grdOutstandingDetails.Rows[0].Cells[2].Value.ToString();
                }

                // LedgerHistory

                DT = objInward.GetCustomerLedgerHistory();
                GridFunc.PopulateDataGrid(grdPartyLedgerHis, DT);


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtAmount.Text.Contains("."))
            {
                e.Handled = true;
            }
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

                if (TranAmount <= 0)
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
                objInward.TranDate =   commonLib.ConvertStringtoDate(dtTransasactionDate.Value.ToString("dd/MM/yyyy"));
                objInward.InstrumentNo = txtChequeNo.Text.ToString();
                objInward.PaymentMode = cmbModeOfPayment.SelectedValue.ToString();
                objInward.InwardRemarks= rtxtRemarks.Text.ToString();
                objInward.CreatedBy = Global.gUserID;

                //Display Message
                strReturn = objInward.PostPaymentEntry();
                commonLib.ShowDBMessage(strReturn);

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
