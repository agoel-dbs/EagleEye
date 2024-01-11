using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using EagleEye.Lib;
using EagleEye.DBLayer;

namespace EagleEye.Administration
{
    public partial class frmAdminTasks : Form
    {
        public frmAdminTasks()
        {
            InitializeComponent();
        }

        private void BtnBuyerLoad_Click(object sender, EventArgs e)
        {
            loadfromExcel();
        }


        private void loadfromExcel()
        {
            try
            {

                OpenFileDialog ofdExcel = new OpenFileDialog();  //create openfileDialog Object
                ofdExcel.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                ofdExcel.FilterIndex = 3;

                ofdExcel.Multiselect = false;        //not allow multiline selection at the file selection level
                ofdExcel.Title = "Open Text File-R13";   //define the name of openfileDialog
                //ofdExcel.InitialDirectory = @"Desktop"; //define the initial directory

                if (ofdExcel.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = ofdExcel.FileName;
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    string sheetName;//= System.IO.Path.GetFileNameWithoutExtension(ofdExcel.FileName);
                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    // sheetName = sheetName + extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;'";
                            break;
                    }

                    using (OleDbConnection conn = new OleDbConnection(strConn))
                    {
                        conn.Open();
                        DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        sheetName = dtSchema.Rows[0].Field<string>("TABLE_NAME");
                        OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}]", sheetName), conn);
                        oda.Fill(tbContainer);
                        conn.Close();
                    }

                    // OleDbConnection cnnxls = new OleDbConnection(strConn);
                    grdReportDetails.DataSource = tbContainer;
                    GridFunc.GridAutosize(grdReportDetails);
                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void FrmAdminTasks_Load(object sender, EventArgs e)
        {
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Admin Activities");
            commonLib.SetCustomDateFormat(dtTransasactionDate);
            dtTransasactionDate.Value = DateTime.Now;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmation;
                string strReturn;


                int iBuyerNameColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "BuyerName");
                int iAdd1ColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "Add1");
                int iAdd2ColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "Add2");
                int iCityColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "City");
                int iStateColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "State");
                int iGSTINColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "GSTIN");
                int iAmountDueColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "AmountDue");


                if (grdReportDetails.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Buyer data not found , aborting the process", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                strConfirmation = "You are about to post a payment entry , this is a irreversible process , do you want to proceed ?";
                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iBuyerNameColIndex == -1)
                {
                    commonLib.showUIMessage("Column (BuyerName) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (iAdd1ColIndex == -1)
                {
                    commonLib.showUIMessage("Column (Add1) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iAdd2ColIndex == -1)
                {
                    commonLib.showUIMessage("Column (Add2) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iCityColIndex == -1)
                {
                    commonLib.showUIMessage("Column (City) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iStateColIndex == -1)
                {
                    commonLib.showUIMessage("Column (State) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iGSTINColIndex == -1)
                {
                    commonLib.showUIMessage("Column (GSTIN) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iAmountDueColIndex == -1)
                {
                    commonLib.showUIMessage("Column (AmountDue) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                StartupData objStartup = new StartupData();

                for (int i = 0; i < grdReportDetails.Rows.Count; i++)
                {

                    objStartup.BuyerName = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iBuyerNameColIndex].Value.ToString());
                    objStartup.Add1 = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iAdd1ColIndex].Value.ToString());
                    objStartup.Add2 = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iAdd2ColIndex].Value.ToString());
                    objStartup.City = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iCityColIndex].Value.ToString());
                    objStartup.State = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iStateColIndex].Value.ToString());
                    objStartup.Gstin = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iGSTINColIndex].Value.ToString());
                    objStartup.TotalAmtPayable = commonLib.fnCheckNull(grdReportDetails.Rows[i].Cells[iAmountDueColIndex].Value.ToString());
                    objStartup.Remarks = rtxtRemarks.Text;
                    //objStartup.TranDate = commonLib.ConvertStringtoDate(dtTransasactionDate.Value.ToString("dd/MM/yyyy"));
                    objStartup.TranDate = commonLib.ReportingDateStringHHMMSS(dtTransasactionDate);
                    objStartup.TranSource = "Customer Start-up Data ";
                    objStartup.CreatedBy = Global.gUserID;

                    strReturn = objStartup.PostCustomerOutstanding();
                    commonLib.ShowDBMessage(strReturn);
                }



            }





            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }

        private void BtnDBScripts_Click(object sender, EventArgs e)
        {

            string strConfirmation;
            string strReturn;


            int iSQLColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "SQL");
            int iMDBColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "MDBChanges");

            if (grdReportDetails.Rows.Count == 0)
            {
                commonLib.showUIMessage("No data found, aborting the process", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            strConfirmation = "You are about to execute the scripts in DB , this is a irreversible process , do you want to proceed ?";
            DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (iSQLColIndex == -1)
            {
                commonLib.showUIMessage("Column (SQL) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (iMDBColIndex == -1)
            {
                commonLib.showUIMessage("Column (MDBChanges) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            StartupData objStartup = new StartupData();


            for (int i = 0; i < grdReportDetails.Rows.Count; i++)
            {

                objStartup.Sql = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iSQLColIndex].Value.ToString());
                objStartup.MdbChanges = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iMDBColIndex].Value.ToString());
                objStartup.CreatedBy = Global.gUserID;
                strReturn = objStartup.ExecuteDbScripts();
                commonLib.ShowDBMessage(strReturn);
            }



        }

        private void BtnGenerateLicLey_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                commonLib.showUIMessage("Enter the value for Key gegneration!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            txtOutput.Text = commonLib.GetLicenseKey(txtInput.Text.Trim());
            commonLib.UpdateConfigKey("LICESSE_KEY", txtOutput.Text);
            commonLib.showUIMessage("Product Key updated sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGenerateExpiry_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                commonLib.showUIMessage("Enter the value for Key gegneration!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            txtOutput.Text = commonLib.GetEncryptedPassword(txtInput.Text.Trim());

            commonLib.UpdateConfigKey("LICESSE_VALIDITY", txtOutput.Text);
            commonLib.showUIMessage("Expiry Key updated sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnProcessVendor_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmation;
                string strReturn;


                int iBuyerNameColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "VendorName");
                int iAdd1ColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "Add1");
                int iAdd2ColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "Add2");
                int iCityColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "City");
                int iStateColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "State");
                int iGSTINColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "GSTIN");
                int iAmountDueColIndex = GridFunc.FindGridColumnIndex(grdReportDetails, "AmountDue");


                if (grdReportDetails.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Vendor data not found , aborting the process", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                strConfirmation = "You are about to post a Vendor Outstanding Amount, this is a irreversible process , do you want to proceed ?";
                DialogResult dr = MessageBox.Show(strConfirmation, Global.gMsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                {
                    commonLib.showUIMessage("Process cancelled , please try again after making the changes!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iBuyerNameColIndex == -1)
                {
                    commonLib.showUIMessage("Column (VenddorName) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (iAdd1ColIndex == -1)
                {
                    commonLib.showUIMessage("Column (Add1) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iAdd2ColIndex == -1)
                {
                    commonLib.showUIMessage("Column (Add2) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iCityColIndex == -1)
                {
                    commonLib.showUIMessage("Column (City) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iStateColIndex == -1)
                {
                    commonLib.showUIMessage("Column (State) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iGSTINColIndex == -1)
                {
                    commonLib.showUIMessage("Column (GSTIN) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (iAmountDueColIndex == -1)
                {
                    commonLib.showUIMessage("Column (AmountDue) is missing in file !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                StartupData objStartup = new StartupData();

                for (int i = 0; i < grdReportDetails.Rows.Count; i++)
                {

                    objStartup.VendorName = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iBuyerNameColIndex].Value.ToString());
                    objStartup.Add1 = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iAdd1ColIndex].Value.ToString());
                    objStartup.Add2 = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iAdd2ColIndex].Value.ToString());
                    objStartup.City = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iCityColIndex].Value.ToString());
                    objStartup.State = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iStateColIndex].Value.ToString());
                    objStartup.Gstin = commonLib.fnCheckNull1(grdReportDetails.Rows[i].Cells[iGSTINColIndex].Value.ToString());
                    objStartup.TotalAmtPayable = commonLib.fnCheckNull(grdReportDetails.Rows[i].Cells[iAmountDueColIndex].Value.ToString());
                    objStartup.Remarks = rtxtRemarks.Text;
                    objStartup.TranDate = commonLib.ReportingDateStringHHMMSS(dtTransasactionDate);
                    objStartup.TranSource = "Vendor Start-up Data ";
                    objStartup.TransactionSubHead = "Plant & Machinery";
                    objStartup.CreatedBy = Global.gUserID;
                    strReturn = objStartup.PostVendorOutstanding();
                    commonLib.ShowDBMessage(strReturn);
                }
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnLicenseKey_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                commonLib.showUIMessage("Enter the value for Key gegneration!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            txtOutput.Text = commonLib.GetLicenseKey(txtInput.Text.Trim());

        }

        private void cmdLicenceValidity_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                commonLib.showUIMessage("Enter the value for Key gegneration!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            txtOutput.Text = commonLib.GetEncryptedPassword(txtInput.Text.Trim());

        }
    }
}