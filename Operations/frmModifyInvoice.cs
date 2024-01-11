using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Data;
using System.Windows.Forms;

namespace EagleEye.Operations
{
    public partial class frmModifyInvoice : Form
    {
        decimal iItemRatePerUnit;
        decimal iActualSaleQty;
        decimal iItemAmount;
        decimal iInvoiceAmount;

        int iQtyColIndex;
        int iRowIndex = -1;

        decimal iCGSTPer = 0;
        decimal iCGSTAmount = 0;
        decimal iSGSTPer = 0;
        decimal iSGSTAmount = 0;
        decimal iIGSTPer = 0;
        decimal iIGSTAmount = 0;
        public frmModifyInvoice()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Invoice Changes");
        }

        private void FrmModifyInvoice_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void LoadDropDownData()
        {
            commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");
            commonLib.PopulateParamMasterCombo(cmbTaxApply, "N", " para_group = 'TAX_TYPE' ", "N");
            commonLib.PopulateItemCombo(cmbItem, "N", "", "N");
        }

        private void TxtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtInvoiceNo_Leave(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text == "")
                return;
            loadInvoiceDetails();
        }
        private void loadInvoiceDetails()
        {
            try
            {
                InvoiceDetails objInv = new InvoiceDetails();
                DataTable DT;
                objInv.InvoiceNo = commonLib.fnCheckNull(txtInvoiceNo.Text);
                //objInv.InvoiceSource = "Ravaana";
                DT = objInv.GetInvoiceDetailsforChanges();
                if (DT == null)
                {
                    commonLib.showUIMessage("Invoice not found in system , try another invoice!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // load data
                GridFunc.PopulateDataGrid(grdInvoiceDetails, DT);

                
                // if the record count is 0 then set the different source
                
                
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
            int InvoiceRk = -1;
            string strNewBuyer;
            string strReturn;
            string stritemDesc;
            int iBuyerRk;
            string strConfirmation;

            strNewBuyer = commonLib.GetComboSelectedValue(cmbBuyer);

            stritemDesc = cmbItem.Text.ToString();

            if (txtInvoiceNo.Text == "")
            {
                commonLib.showUIMessage("Please enter the invoice no !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtInvoiceNo.Focus();
                return;
            }

            // check if reason of new buyer is selected

            if (strNewBuyer == "")
            {
                commonLib.showUIMessage("Select the new Buyer !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbBuyer.Focus();
                return;
            }

            if (stritemDesc == "")
            {
                commonLib.showUIMessage("Select the new Item !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbItem.Focus();
                return;
            }

            iBuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer));
            // find selected row for re-printing
            foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
            {
                InvoiceRk = commonLib.fnCheckNull(grdInvoiceDetails.Rows[r.Index].Cells[0].Value.ToString());
            }

            if (InvoiceRk == -1)
            {
                commonLib.showUIMessage("Please select a invoice for changes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            CalulateTotalAmount();

            strConfirmation = "You are about to generate an Invoice with the below Details" + Environment.NewLine +
                                  "Actual Rate :" + iItemRatePerUnit.ToString() + Environment.NewLine +
                                  "Actual Quantity: " + iActualSaleQty.ToString() + Environment.NewLine +
                                  "Good Value :" + iItemAmount.ToString() + Environment.NewLine +
                                  "Tax payable: " + (iCGSTAmount + iSGSTAmount + iIGSTAmount).ToString() + Environment.NewLine +
                                  " Invoice Amount:" + iInvoiceAmount.ToString() + Environment.NewLine + Environment.NewLine +
                                   "Do you want to proceed ?";

            DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes)
            {
                commonLib.showUIMessage("Process aborted, please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            //change buyer
            InvoiceDetails objInvoice = new InvoiceDetails();

            objInvoice.InvoiceRk = InvoiceRk;
            objInvoice.NewBuyerRk= iBuyerRk;
            objInvoice.ItemRate = iItemRatePerUnit;
            objInvoice.ItemAmt = Math.Round(iItemAmount,0);
            objInvoice.CGSTPer = iCGSTPer;
            objInvoice.CGSTAmt = Math.Round(iCGSTAmount,2);
            objInvoice.SGSTPer = iSGSTPer;
            objInvoice.SGSTAmt = Math.Round(iSGSTAmount,2);
            objInvoice.IGSTPer = iIGSTPer;
            objInvoice.IGSTAmt = Math.Round(iIGSTAmount,2);
            objInvoice.TotalInvAmt = Math.Round(iInvoiceAmount,0);
            objInvoice.TotalAmtWords = commonLib.ConvertWholeNumber(iInvoiceAmount.ToString());
            objInvoice.CreatedBy = Global.gUserID;
            objInvoice.InvoiceModified = 1; // yes
            objInvoice.ItemDesc = stritemDesc;

            //Display Message
            strReturn = objInvoice.ModifyInvoice();
            commonLib.ShowDBMessage(strReturn);



        }

        private void TxtRatePerTon_TextChanged(object sender, EventArgs e)
        {
            CalulateTotalAmount();
        }

        private void CalulateTotalAmount()
        {
            try
            {
                
                // find selected Row Index

                foreach (DataGridViewRow r in grdInvoiceDetails.SelectedRows)
                {
                    iRowIndex = r.Index;
                    //InvoiceRk = Convert.ToInt16(grdInvoiceDetails.Rows[r.Index].Cells[0].Value);
                }


                iItemRatePerUnit = commonLib.fnCheckDecimal(txtRatePerTon.Text);
                iQtyColIndex = GridFunc.FindGridColumnIndex(grdInvoiceDetails, "Quantity");
                iActualSaleQty = commonLib.fnCheckDecimal(grdInvoiceDetails.Rows[iRowIndex].Cells[iQtyColIndex].Value.ToString());
                iItemAmount = iActualSaleQty * iItemRatePerUnit;


                //Tax 
                ParameterDetails objParam = new ParameterDetails();

                if (commonLib.GetComboSelectedValue(cmbTaxApply) == "LOCAL_TAX")
                {
                    objParam.ParaCode = "CGST_TAX";
                    iCGSTPer = commonLib.fnCheckDecimal(objParam.GetParameterValue());
                    iCGSTAmount = (iItemAmount * iCGSTPer) / 100;


                    objParam.ParaCode = "SGST_TAX";
                    iSGSTPer = commonLib.fnCheckDecimal(objParam.GetParameterValue());
                    iSGSTAmount = (iItemAmount * iSGSTPer) / 100;
                }
                if (commonLib.GetComboSelectedValue(cmbTaxApply) == "INTRA_STATE")
                {
                    objParam.ParaCode = "IGST_TAX";
                    iIGSTPer = commonLib.fnCheckDecimal(objParam.GetParameterValue());
                    iIGSTAmount = (iItemAmount * iIGSTPer) / 100;
                }

                iInvoiceAmount = iItemAmount + iCGSTAmount + iIGSTAmount + iSGSTAmount;

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

    }
}
