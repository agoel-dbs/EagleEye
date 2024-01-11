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
    public partial class frmStockVariance : Form
    {
        public frmStockVariance()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Stock Variance");

        }

        private void FrmStockVariance_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void LoadDropDownData()
        {
            try
            {

                commonLib.PopulateParamMasterCombo(cmbVarianceType, "N", " para_group = 'VARIANCE_TYPE' ", "N", true);
                commonLib.PopulateItemCombo(cmbItem, "N", "", "Y");


                commonLib.SetCustomDateFormat(dtBillDate);
                dtBillDate.Value = DateTime.Now;

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

        private void CalculateBillAmount()
        {
            txtBillAmt.Text = Math.Round(commonLib.fnCheckDecimal(txtItemQty.Text) * commonLib.fnCheckDecimal(txtItemRate.Text), 2).ToString();

        }

        private void TxtItemRate_TextChanged(object sender, EventArgs e)
        {
            CalculateBillAmount();
        }

        private void TxtItemQty_TextChanged(object sender, EventArgs e)
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

        private void TxtBillAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = commonLib.KeyPressDecimal(e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                // string VendorRk;
                string VarianceType;
                string BillDate;
                decimal BillAmount;
                string Remarks;
                string strConfirmation;
                string strReturn;
                string ItemRk = "";
                decimal ItemQty = 0;
                decimal UnitRate = 0;
                decimal TotalAmount = 0;

                VarianceType = commonLib.GetComboSelectedValue(cmbVarianceType);
                BillAmount = commonLib.fnCheckDecimal(txtBillAmt.Text);
                if (VarianceType == "")
                {
                    commonLib.showUIMessage("Please select the Variance head!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbVarianceType.Focus();
                    return;
                }

                if (BillAmount <= 0)
                {
                    commonLib.showUIMessage("Please enter the Total amount!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBillAmt.Focus();
                    return;
                }

                ItemRk = commonLib.GetComboSelectedValue(cmbItem);

                ItemQty = commonLib.fnCheckDecimal(txtItemQty.Text);
                UnitRate = commonLib.fnCheckDecimal(txtItemRate.Text);
                if (ItemRk=="")
                {

                    commonLib.showUIMessage("Please select the item !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtItemQty.Focus();
                    return;

                }

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


                if (VarianceType == "POS_VAR")
                {
                    strConfirmation = "The stock of the selected item will be increased.";

                }
                else
                {
                    strConfirmation = "The stock of the selected item will be reduced.";

                }

                strConfirmation = strConfirmation + Environment.NewLine + " Do you want to proceed?";

                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                BillDate = commonLib.ReportingDateStringHHMMSS(dtBillDate);
                Remarks = rtxtRemarks.Text;

                StockVariance objVar = new StockVariance();
                objVar.VarianceType = VarianceType;
                objVar.VarianceDate = BillDate;
                objVar.ItemRk = commonLib.fnCheckNull( ItemRk);
                objVar.ItemQty = ItemQty;
                objVar.ItemRate = UnitRate;
                objVar.BillAmount = BillAmount;
                objVar.Remarks = rtxtRemarks.Text;
                strReturn =  objVar.PostStockVariance();
                commonLib.ShowDBMessage(strReturn); 

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
