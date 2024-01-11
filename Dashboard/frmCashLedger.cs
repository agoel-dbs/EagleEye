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

namespace EagleEye.Dashboard
{
    public partial class frmCashLedger : Form

    {
        int iCreditColIndex = -1;
        int iDebitColIndex = -1;

        public frmCashLedger()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Cash Ledger Details");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            PopulateData();
        }

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {

                if (grdDaily.RowCount > 0)
                {
                    ExportDailyReport();
                    commonLib.showUIMessage("Daily Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


                if (grdReportDetails.RowCount > 0)
                {
                    ExportLedgerReport();
                    commonLib.showUIMessage("Daily Ledger report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void ExportLedgerReport()
        {
                string strReportHeader;

        strReportHeader = "Cash Ledger Report  for - " +
                                   commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbSubHead).ToString()) +
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                GridFunc objGrid = new GridFunc();
        objGrid.ExcelFileName = "Cash Ledger Report.xls";
                objGrid.WorkSheetName = "Cash Ledger Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails,"");

        }

        private void ExportDailyReport()
        {
            string strReportHeader;

            strReportHeader = "Daily Report  for - " +
                                     dtDailyDate.Value.ToString("dd-MMM-yyyy");

            GridFunc objGrid = new GridFunc();
            objGrid.ExcelFileName = "Daily Report.xls";
            objGrid.WorkSheetName = "Daily Report";
            objGrid.ReportHeader = strReportHeader;
            objGrid.ExportToExcel(grdDaily, "");
            commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmCashLedger_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateData();
        }

        private void LoadDropDownData()
        {
            try
            {

                commonLib.PopulateLedgerExpenseHeadCombo(cmbSubHead, "N", "", "Y");
                cmbSubHead.SelectedIndex = 0;
                commonLib.SetCustomDateFormat(dtFromDate);
                commonLib.SetCustomDateFormat(dtToDate);
                commonLib.SetCustomDateFormat(dtDailyDate);
                dtToDate.Value = DateTime.Now;
                dtFromDate.Value = DateTime.Now;
                dtDailyDate.Value = DateTime.Now.AddDays(-1);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void PopulateData()
        {

            try
            {
                //Dashboard objDashBoard = new Dashboard();
                DataTable DT;
                DashboardRep objDB = new DashboardRep();
                objDB.SubHead= commonLib.GetComboSelectedValue(cmbSubHead).ToString();
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);

                string[] AggregateColumn = { "TransactionAmount"};
                GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetCashBalanceHistory()));

                //cash In Hand 
                lblCashInHand.Text = "";
                DT = objDB.GetCashInHandDetails();
                foreach (DataRow row in DT.Rows)
                {
                    lblCashInHand.Text = row["CashStatus"].ToString() + ":" + row["LedgerBalance"].ToString();
                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void PopulateDailyData()
        {

            try
            {

                //Dashboard objDashBoard = new Dashboard();
                DashboardRep objDB = new DashboardRep();
                objDB.DailyDate = commonLib.ReportingDateStringHHMMSS(dtDailyDate);
                GridFunc.PopulateDataGrid(grdDaily, objDB.GetDailyReport());

                if (grdDaily.RowCount.ToString() == "0" )
                {
                    commonLib.showUIMessage("Daily Details not found. Please generate daily and try again!!!" , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                iCreditColIndex = GridFunc.FindGridColumnIndex(grdDaily, "CreditAmount");
                iDebitColIndex = GridFunc.FindGridColumnIndex(grdDaily, "DebitAmount");

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnGenerateDaily_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmation;
                string strResult;

                strConfirmation = "You are about to generate the daily for the date " + commonLib.ReportingDateString(dtDailyDate) +
                                     Environment.NewLine + "Do you want to proceed ?";

                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process aborted , please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // generate the daily for the date

                PlantDaily objDaily = new PlantDaily();
                //objDaily.DailyDate = commonLib.ConvertStringtoDate(dtDailyDate.Value.ToString("dd/MM/yyyy"));
                objDaily.DailyDate = commonLib.ReportingDateStringHHMMSS(dtDailyDate);

                strResult = objDaily.CheckDailyAlreadyExists();


                if (strResult != "0")
                {

                    strConfirmation = "Daily already exists for the date " + commonLib.ReportingDateString(dtDailyDate) +
                                     Environment.NewLine + "Do you want to re-generate?";
                    dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr != DialogResult.Yes)
                    {
                        commonLib.showUIMessage("Process aborted , please try again later!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                }

                // generate daily now

                objDaily.CreatedBy = Global.gUserID;
                strResult = objDaily.GenerateDaily();
                commonLib.ShowDBMessage(strResult);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnShowDaily_Click(object sender, EventArgs e)
        {
            try
            {
                tabMain.SelectedTab = tbDaily;
                PopulateDailyData();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void GrdDaily_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            GridFunc.ChangeCellGreenRed(e, iCreditColIndex, 0);
            GridFunc.ChangeCellGreenRed(e, iDebitColIndex, 0);

            

        }
    }
}
