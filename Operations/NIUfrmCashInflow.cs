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
    public partial class NIUfrmCashInflow : Form
    {
        Boolean bFormLoad = false;
        int BuyerRk = -1;

        public NIUfrmCashInflow()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Cash In-Flow");
        }

        private void FrmCashInflow_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }
        private void LoadDropDownData()
        {
            try
            {
                commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "N");
                dtBillDate.Value = DateTime.Now;
                dtBillDate.MaxDate = DateTime.Now;

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

        }

        private void TxtBillAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtBillAmt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                BuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer));
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

                SupplierBill objSupplier = new SupplierBill();
                OutwardPayment objOutward = new OutwardPayment();
                objSupplier.VendorRk = BuyerRk;

                // Bill details
                //GridFunc.PopulateDataGrid(grdBillDetails, objSupplier.GetSupplierBillHistory());
                //OS Balance
                objOutward.VendorRk = BuyerRk;
                GridFunc.PopulateDataGrid(grdOutstandingDetails, objOutward.GetVendorOutstandingBalance());
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



    }
}
