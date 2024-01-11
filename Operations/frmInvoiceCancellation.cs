using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Data;
using System.Windows.Forms;

namespace EagleEye.Operations
{
    public partial class frmInvoiceCancellation : Form
    {
        public frmInvoiceCancellation()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Invoice Cancellation / Changes");
        }

        private void TxtOldInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
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
                objInv.InvoiceNo = commonLib.fnCheckNull(txtOldInvoiceNo.Text);
                objInv.InvoiceSource = "-99";
                DT = objInv.GetInvoiceDetailsforReport();
                if (DT.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Invoice not found in system , try another invoice!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // load data
                GridFunc.PopulateDataGrid(grdInvoiceDetails, DT);

                // populate ledger Entry
             
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

                int InvoiceRk = -1;
                string strCancelReason;
                string strReturn;

                strCancelReason = commonLib.GetComboSelectedValue(cmbCancelReason);

                if (txtOldInvoiceNo.Text == "")
                {
                    commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtOldInvoiceNo.Focus();
                    return;
                }

                // check if reason of cancelleation is select

                if (strCancelReason== "")
                {
                    commonLib.showUIMessage("Select the reason of cancellation!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbCancelReason.Focus();
                    return;
                }

                DialogResult dr = MessageBox.Show("Do you want to proceed for the invoice cancellation ?", Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process aborted, please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                // find selected row for re-printing
                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    //InvoiceRk = Convert.ToInt16(grdInvoiceDetails.Rows[r.Index].Cells[0].Value);
                    InvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
                }

                if (InvoiceRk == -1)
                {
                    commonLib.showUIMessage("Please select a row for cancellation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                //cancel Invioice

                InvoiceDetails objInvoice = new InvoiceDetails();

                objInvoice.InvoiceRk = InvoiceRk;
                objInvoice.CancellationReason = strCancelReason;
                objInvoice.CreatedBy = Global.gUserID;
                

                //Display Message
                strReturn = objInvoice.CancelInvoice();
                commonLib.ShowDBMessage(strReturn);


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FrmInvoiceCancellation_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void LoadDropDownData()
        {
            try
            {
                
                commonLib.PopulateParamMasterCombo(cmbCancelReason, "N", " para_group = 'INV_CANCEL' ", "N");
                commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnChangetoCredit_Click(object sender, EventArgs e)
        {
            try
            {

                int InvoiceRk = -1;
                string strReturn;
                int iSaleTypeColIndex;
                string SaleType="";

                if (txtOldInvoiceNo.Text == "")
                {
                    commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtOldInvoiceNo.Focus();
                    return;
                }

                // check if reason of cancelleation is select

                
                DialogResult dr = MessageBox.Show("This will change the Cash sale to Credit sale. Do you want to proceed ?", Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process aborted, please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                // find selected row for re-printing

                iSaleTypeColIndex = GridFunc.FindGridColumnIndex(grdInvoiceDetails, "SaleType");

                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    InvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
                    SaleType = grdInvoiceDetails.Rows[r.Index].Cells[iSaleTypeColIndex].Value.ToString();
                }

                if (InvoiceRk == -1)
                {
                    commonLib.showUIMessage("Please select a row for the changes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (SaleType == "Credit Sale")
                {
                    commonLib.showUIMessage("The selected invoice is already in Credit Sale , process aborted !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                    //Change Cash to Credit

                    InvoiceDetails objInvoice = new InvoiceDetails();

                objInvoice.InvoiceRk = InvoiceRk;
                objInvoice.CreatedBy = Global.gUserID;


                //Display Message
                strReturn = objInvoice.CashToCreditSale();
                commonLib.ShowDBMessage(strReturn);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnChangetoCash_Click(object sender, EventArgs e)
        {
            try
            {

                int InvoiceRk = -1;
                string strReturn;
                string SaleType = "";
                int iSaleTypeColIndex;

                if (txtOldInvoiceNo.Text == "")
                {
                    commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtOldInvoiceNo.Focus();
                    return;
                }

                // check if reason of cancelleation is select


                DialogResult dr = MessageBox.Show("This will change the Credit sale to Cash sale. Do you want to proceed ?", Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process aborted, please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                iSaleTypeColIndex = GridFunc.FindGridColumnIndex(grdInvoiceDetails, "SaleType");

                // find selected row for re-printing
                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    InvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
                    SaleType = grdInvoiceDetails.Rows[r.Index].Cells[iSaleTypeColIndex].Value.ToString();
                }

                if (InvoiceRk == -1)
                {
                    commonLib.showUIMessage("Please select a row for the changes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (SaleType == "Cash Sale")
                {
                    commonLib.showUIMessage("The selected invoice is already in Cash Sale , Process aborted..", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                //Change Cash to Credit

                InvoiceDetails objInvoice = new InvoiceDetails();

                objInvoice.InvoiceRk = InvoiceRk;
                objInvoice.CreatedBy = Global.gUserID;


                //Display Message
                strReturn = objInvoice.CreditToCashSale();
                commonLib.ShowDBMessage(strReturn);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnChangeSaleRate_Click(object sender, EventArgs e)
        {
            int InvoiceNo;
            string strReturn;
            decimal saleRate;
            decimal saleWeight;


            InvoiceNo = commonLib.fnCheckNull(txtOldInvoiceNo.Text);

            if (InvoiceNo  <= 0)
            {
                commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtOldInvoiceNo.Focus();
                return;
            }


            saleRate = commonLib.fnCheckDecimal(txtSaleRate.Text);
            saleWeight = commonLib.fnCheckDecimal(txtSaleWeight.Text);

            if (saleRate <= 0)
            {
                commonLib.showUIMessage("Sale rate can not be 0 !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSaleRate.Focus();
                return;
            }
            /*
            if (saleWeight <= 0)
            {
                commonLib.showUIMessage("Sale weight can not be 0 !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSaleWeight.Focus();
                return;
            }
            */

            InvoiceDetails objInvoice = new InvoiceDetails();

            objInvoice.InvoiceNo = InvoiceNo;
            objInvoice.SaleRate= saleRate;
            objInvoice.SaleQuantity = saleWeight;
            strReturn = objInvoice.ChangeSaleRateWeight();
            commonLib.showUIMessage(strReturn, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void btnChangeBuyer_Click(object sender, EventArgs e)
        {
            int InvoiceNo;
            string strReturn;
            int BuyerRk;

            BuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer));
            InvoiceNo = commonLib.fnCheckNull(txtOldInvoiceNo.Text);


            if (InvoiceNo <= 0)
            {
                commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtOldInvoiceNo.Focus();
                return;
            }

            // check if reason of cancelleation is select

            if (BuyerRk  < 0 )
            {
                commonLib.showUIMessage("Select the account this invoice will move to !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbCancelReason.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Do you want to proceed for the account change?", Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr != DialogResult.Yes)
            {
                commonLib.showUIMessage("Process aborted, please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


                        



            InvoiceDetails objInvoice = new InvoiceDetails();

            objInvoice.InvoiceNo = InvoiceNo;
            objInvoice.ActualBuyerRk= BuyerRk;
            objInvoice.CreatedBy = Global.gUserID;
            strReturn = objInvoice.ChangeInvoiceAccount();
            commonLib.showUIMessage(strReturn, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void txtSaleRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void txtSaleWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }
    }
}
