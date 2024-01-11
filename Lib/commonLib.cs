using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using Spire.Pdf.Print;
using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Image = iText.Layout.Element.Image;
using EagleEye.Lib;
using EagleEye.DBLayer;
using System.Data;
using System.Globalization;

namespace EagleEye
{
    class commonLib
    {
        static string APPNODE = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Properties.Settings";
        static DateTime now = DateTime.Now;
        //static string msgBoxCaption = "Test";



        static public void CreatePDFDocument(string pSource, string pTarget, string pImageSource ,string pDuplicateInvoice)
        {
            try
            {
                float reprintHeight = float.Parse(Global.gInvReprintHeight);
                float reprintWidth = float.Parse(Global.gInvReprintWidth);

                // check if file already exisit the move to Duplicate
                if (File.Exists(pTarget) )
                {
                    File.Move(pTarget,pDuplicateInvoice);
                }
                

                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(pTarget));

                iText.Kernel.Geom.Rectangle envelope = new iText.Kernel.Geom.Rectangle(reprintHeight, reprintWidth);

                // Document to add layout elements: paragraphs, images etc
                Document document = new Document(pdfDocument, new PageSize(envelope));
                // Load image from disk
                ImageData imageData = ImageDataFactory.Create(pImageSource);
                // Create layout image object and provide parameters. Page number = 1
                Image image = new Image(imageData);//.ScaleAbsolute(100, 200).SetFixedPosition(1, 25, 25);
                                                   // This adds the image to the page
                document.Add(image);

                // Don't forget to close the document.
                // When you use Document, you should close it rather than PdfDocument instance
                document.Close();
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        // print pdf file

        static public void PrintPDFFile(string pFileWNameWithPath)
        {
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(pFileWNameWithPath);

            //Use the default printer to print all the pages
            //doc.PrintDocument.Print();

            //Set the printer and select the pages you want to print

            //PrintDialog dialogPrint = new PrintDialog();
            //dialogPrint.AllowPrintToFile = true;
            //dialogPrint.AllowSomePages = true;
            //dialogPrint.PrinterSettings.MinimumPage = 1;
            //dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            //dialogPrint.PrinterSettings.FromPage = 1;
            //dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            //dialogPrint.PrinterSettings.DefaultPageSettings.PaperSize = PaperKind.C5Envelope;

            //IEnumerable paperSizes = doc.PrintSettings.PaperSize PaperSizes.Cast;

            //IEnumerable<PaperSize> paperSizes = doc.PaperSizes.Cast<PaperSize>();

            //PaperSize printPaperSize = PaperKind.C5Envelope; // paperSizes.First(size => size.Kind == PaperKind.A4);
            //if (dialogPrint.ShowDialog() == DialogResult.OK)
            //{
            //    //SizeF size = doc.Pages[0].Size;
            //int rotation = (int)doc.Pages[0].Rotation;
            // rotation += (int) Spire.Pdf.PdfPageRotateAngle.RotateAngle270;
            //doc.Pages[0].Rotation = (Spire.Pdf.PdfPageRotateAngle)rotation;
            //PaperSize paper = new PaperSize();// (int)size.Width / 90 * 100, (int)size.Height / 80 * 100);
            //paper.RawKind = (int)PaperKind.C5Envelope;

            //Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            //doc.LoadFromFile(FileName);
            doc.PrintSettings.SelectSinglePageLayout(Spire.Pdf.Print.PdfSinglePageScalingMode.ActualSize);
            doc.Print();

            //doc.PrintSettings.PaperSize = paper;
            //doc.PrintSettings.SelectSinglePageLayout(PdfSinglePageScalingMode.ShrinkOversized,true);

            //doc.PrintSettings.PaperSize =paper;
            //doc.Print();




            //doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
            //doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
            //doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;
            //doc.PageSettings.Size = Spire.Pdf.PdfPageSize.HalfLetter;
            //PrintDocument printDoc = doc.PrintDocument;

            //}


        }

        static public void MoveFile(string pSource, string pDestination,string pDuplicateFilePath)
        {
            try
            {
                // if source file exists
                if (File.Exists(pSource))
                {
                    //if desitination file exists then move the exisitng file to Duplicate 
                    if (File.Exists(pDestination))
                    {
                        // if file exists in duplicate folder then remove it
                        if (File.Exists(pDuplicateFilePath))
                        {
                            RemoveFile(pDuplicateFilePath);
                        }
                        // copy the file from processed to Duplicate
                        File.Move(pDestination, pDuplicateFilePath);
                        
                    }
                    // copy file from to Processed folder
                    File.Move(pSource, pDestination);

                }
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        static public void RemoveFile(string pFileNamewithPath)
        {
            try
            {
                if (File.Exists(pFileNamewithPath))
                {
                    File.Delete(pFileNamewithPath);

                }
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, Global.gMsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        static public void SetMyButtonIcon(Button pBtnControl, string pStrImagePath)
        {
            try
            {
                // Assign an image to the button.
                pBtnControl.Image = System.Drawing.Image.FromFile(pStrImagePath);
                // Align the image and text on the button.
                pBtnControl.ImageAlign = ContentAlignment.TopLeft;
                pBtnControl.TextAlign = ContentAlignment.MiddleLeft;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        static public void ManageFormLayout(Panel pMainPanel,
                                                Label pHeaderLabel
                                                , string pHeaderLabelText
                                                , Label pFooterLabel
                                                , string pFooterLabelText
                                                , Form pFrm)
        {
            try
            {

                pMainPanel.Left = (pFrm.Width / 2) - (pMainPanel.Width / 2);
                pMainPanel.Top = (pFrm.Height / 2) - (pMainPanel.Height / 2);
                ;

                // Header label
                pHeaderLabel.Size = new Size(pMainPanel.Width, 50);
                pHeaderLabel.Text = pHeaderLabelText;
                pHeaderLabel.BorderStyle = BorderStyle.FixedSingle;
                pHeaderLabel.Font = new Font("Arial", 24, FontStyle.Bold);
                pHeaderLabel.Top = 0;
                pHeaderLabel.Left = 0;

                // Footer label
                pFooterLabel.Size = new Size(pMainPanel.Width, 25);
                pFooterLabel.Text = pFooterLabelText;
                pFooterLabel.BorderStyle = BorderStyle.FixedSingle;
                pFooterLabel.Font = new Font("Arial", 10, FontStyle.Regular);
                pFooterLabel.Top = pMainPanel.Height - pFooterLabel.Height;
                pFooterLabel.Left = 0;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        static public void ManageFormLayout(Panel pMainPanel
                                            , Label pHeaderLabel
                                             , string pHeaderLabelText
                                                        )
        {
            try
            {

                // Header label
                pHeaderLabel.Size = new Size(pMainPanel.Width, 50);
                pHeaderLabel.Text = pHeaderLabelText;
                pHeaderLabel.BorderStyle = BorderStyle.FixedSingle;
                pHeaderLabel.Font = new Font("Arial", 24, FontStyle.Bold);
                pHeaderLabel.Top = 0;
                pHeaderLabel.Left = 0;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        static public string GetRavanvaFileSourcePath()
        {
            try
            {
                string strDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                return strDesktop + Global.gSourcePath;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        static public string GetInvoiceFilePath()
        {
            try
            {
                string strDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                return strDesktop + Global.gProcessedInvoicePath;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, Global.gMsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }


        static public string GetCancelledInvoiceFilePath()
        {
            try
            {
                string strDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                return strDesktop + Global.gCancelledInvoicePath; ;
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        static public string GetDuplicateInvoiceFilePath()
        {
            try
            {
                string strDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                return strDesktop + Global.gDuplicateInvoicePath; ;
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        static public string fnCheckNull1(string pStrValue)
        {

            try
            {
                if (pStrValue == null)
                    return "";

                return pStrValue.Trim();
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }
        static public int fnCheckNull(string pStrValue)
        {

            try
            {
                return Convert.ToInt32(pStrValue);
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }

        }
        static public int fnCheckNull(double pStrValue)
        {

            try
            {
                return Convert.ToInt32(pStrValue);
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }

        }

        static public void showUIMessage(string pStrMsg, string pStrCaption, MessageBoxButtons msgButton, MessageBoxIcon msgIcon)
        {
            MessageBox.Show(pStrMsg, pStrCaption, msgButton, msgIcon);
        }

        static public void showUIMessage(string pStrMsg, MessageBoxButtons msgButton, MessageBoxIcon msgIcon)
        {
            MessageBox.Show(pStrMsg, Global.gMsgBoxCaption, msgButton, msgIcon);
        }


        static public void UpdateConfigKey(string pStrKey, string pNewValue)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[pStrKey] != null)
                    config.AppSettings.Settings[pStrKey].Value = pNewValue;
                else
                    config.AppSettings.Settings.Add(pStrKey, pNewValue);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private static String ones(String Number)
        {
            try
            {
                int _Number = fnCheckNull(Number);
                String name = "";
                switch (_Number)
                {

                    case 1:
                        name = "One";
                        break;
                    case 2:
                        name = "Two";
                        break;
                    case 3:
                        name = "Three";
                        break;
                    case 4:
                        name = "Four";
                        break;
                    case 5:
                        name = "Five";
                        break;
                    case 6:
                        name = "Six";
                        break;
                    case 7:
                        name = "Seven";
                        break;
                    case 8:
                        name = "Eight";
                        break;
                    case 9:
                        name = "Nine";
                        break;
                }
                return name;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        private static String tens(String Number)
        {
            try
            {
                int _Number = fnCheckNull(Number);
                String name = null;
                switch (_Number)
                {
                    case 10:
                        name = "Ten";
                        break;
                    case 11:
                        name = "Eleven";
                        break;
                    case 12:
                        name = "Twelve";
                        break;
                    case 13:
                        name = "Thirteen";
                        break;
                    case 14:
                        name = "Fourteen";
                        break;
                    case 15:
                        name = "Fifteen";
                        break;
                    case 16:
                        name = "Sixteen";
                        break;
                    case 17:
                        name = "Seventeen";
                        break;
                    case 18:
                        name = "Eighteen";
                        break;
                    case 19:
                        name = "Nineteen";
                        break;
                    case 20:
                        name = "Twenty";
                        break;
                    case 30:
                        name = "Thirty";
                        break;
                    case 40:
                        name = "Fourty";
                        break;
                    case 50:
                        name = "Fifty";
                        break;
                    case 60:
                        name = "Sixty";
                        break;
                    case 70:
                        name = "Seventy";
                        break;
                    case 80:
                        name = "Eighty";
                        break;
                    case 90:
                        name = "Ninety";
                        break;
                    default:
                        if (_Number > 0)
                        {
                            name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                        }
                        break;
                }
                return name;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        static public String ConvertWholeNumber(String pNumber)
        {
            string word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX    
                bool isDone = false;//test if already translated    
                double dblAmt = Math.Round(Convert.ToDouble(pNumber));
                string Number = dblAmt.ToString();
                //if ((dblAmt > 0) && number.StartsWith("0"))    
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric    
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    String place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        case 1://ones' range    

                            word = ones(Number);
                            isDone = true;
                            break;
                        case 2://tens' range    
                            word = tens(Number);
                            isDone = true;
                            break;
                        case 3://hundreds' range    
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range    
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions' range    
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range    
                        case 11:
                        case 12:

                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)    
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }

                        //check for trailing zeros    
                        //if (beginsZero) word = " and " + word.Trim();    
                    }
                    //ignore digit grouping names    
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }

        public static Boolean IsValidLicense(string pLicenseNo, string pLicenseKey)
        {

            try
            {
                string strLicenceNo = pLicenseNo;

                if (GetLicenseKey(strLicenceNo) == pLicenseKey)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

        }

        private void setPageSize(string pFileName)
        {
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(pFileName);

            SizeF size = doc.Pages[0].Size;

            PaperSize paper = new PaperSize("Custom", (int)size.Width / 72 * 100, (int)size.Height / 72 * 100);
            paper.RawKind = (int)PaperKind.Custom;
            doc.PrintSettings.PaperSize = paper;
            doc.PrintSettings.SelectSinglePageLayout(PdfSinglePageScalingMode.FitSize, true);
            doc.Print();
        }

        public static string GetLicenseKey(string pLicenseNo)
        {

            try
            {
                string strLicenceNo = "*&#" + pLicenseNo + "2yASD";
                return EncodeText(strLicenceNo);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }

        private static string GetLicenseValidityDate(string pCurrentDateDDMMYYYY)
        {

            try
            {
                string strLicenceDate = "*&#" + pCurrentDateDDMMYYYY + "2yASD";
                return EncodeText(pCurrentDateDDMMYYYY);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }

        public static string GetEncryptedPassword(string pstrPassword)
        {

            try
            {
                 string strPassword = "~&#" + pstrPassword + "3PsdC*";
                return EncodeText(strPassword);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }


        public static string GetDecryptedPassword(string pstrPassword)
        {

            try
            {
                int pos1;
                int pos2;


                string strPwdSalted = DecodeText(pstrPassword);
                pos1 = strPwdSalted.IndexOf("~&#");
                pos2 = strPwdSalted.IndexOf("3PsdC*");

                strPwdSalted = strPwdSalted.Replace("~&#", "");
                strPwdSalted = strPwdSalted.Replace("3PsdC*", "");
                return strPwdSalted;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }

        }


        /// encrypte 
        /// 


        public static string EncodeText(string pInput)
        {
            try
            {
                byte[] encData_byte = new byte[pInput.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(pInput);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        //this function Convert to Decord your Password
        public static string DecodeText(string pEncodedData)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(pEncodedData);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
        }

        public static void ControlSetting(Control pControl)
        {
            try
            {
                string strCtrlTypeRaw;
                string strCtrlType;

                string strQualiefiedString;
                ParameterDetails objParam = new ParameterDetails();

                if (Global.gControlQualification == null)
                {
                    objParam.ParaCode = "CONTROl_QUALIFICATION";
                    Global.gControlQualification = objParam.GetParameterValue();
                }

                strQualiefiedString = Global.gControlQualification;


                int pos;
                string strBackColorPropName;
                string strForeColorPropName;

                strCtrlTypeRaw = pControl.GetType().BaseType.Name.ToUpper();

                if (strCtrlTypeRaw == "FORM")
                    strCtrlType = strCtrlTypeRaw;
                else
                {
                    strCtrlType = pControl.GetType().ToString().ToUpper();
                    pos = pControl.GetType().ToString().IndexOf(strQualiefiedString);
                    strCtrlType = strCtrlType.Substring(strQualiefiedString.Length);
                }

                strBackColorPropName = strCtrlType + "_BACKCOLOR";

                objParam.ParaCode = strBackColorPropName;
                SetControlBackColor(pControl, objParam.GetParameterValue());

                strForeColorPropName = strCtrlType + "_FORECOLOR";
                objParam.ParaCode = strForeColorPropName;

                SetControlForeColor(pControl, objParam.GetParameterValue());

                foreach (Control ctrl in pControl.Controls)
                {
                    //string strControlNames = ctrl.Name;
                    // string strControlTypes = ctrl.GetType().ToString().ToUpper();
                    ControlSetting(ctrl);
                }

            }
            catch (Exception e)
            {


            }

        }
        private static void SetControlBackColor(Control pControl, string pColorString)
        {
            try
            {
                string[] strArrcustomColor;

                if (pColorString == null)
                {
                    return;

                }
                strArrcustomColor = Regex.Split(pColorString, ",");
                pControl.BackColor = Color.FromArgb(fnCheckNull(strArrcustomColor[0].ToString()),
                                                    fnCheckNull(strArrcustomColor[1].ToString()),
                                                    fnCheckNull(strArrcustomColor[2].ToString()));

            }
            catch (Exception e)
            {

            }
        }
        private static void SetControlForeColor(Control pControl, string pColorString)
        {
            try
            {
                string[] strArrcustomColor;

                if (pColorString == null)
                {
                    return;

                }
                strArrcustomColor = Regex.Split(pColorString, ",");
                pControl.ForeColor = Color.FromArgb(fnCheckNull(strArrcustomColor[0].ToString()),
                                                    fnCheckNull(strArrcustomColor[1].ToString()),
                                                    fnCheckNull(strArrcustomColor[2].ToString()));

            }
            catch (Exception e)
            {

            }
        }


        static public string GetParamFilterRowValue( DataTable pDt, string pParamCode )
        {
            try
            {
                string sFilterstring = " para_code = '" + pParamCode + "'";
                DataRow[] dr = pDt.Select(sFilterstring);
                return dr[0]["para_value"].ToString();
            }
            catch (Exception e)
            {
                return "";
            }

        }

        static public void PopulateGlobalParameter()
        {
            try
            {
                DataTable Dt;
                ParameterDetails objParam = new ParameterDetails();
                Dt= objParam.GetParameterValueAll();

                Global.gSellerGSTIN = GetParamFilterRowValue(Dt, "SELLER_GSTIN");
                Global.gSourcePath = GetParamFilterRowValue(Dt, "SOURCE_PATH");

                Global.gRavannaFileName = GetParamFilterRowValue(Dt, "RAVANNA_FILE_NAME");
                Global.gProcessedInvoicePath = GetParamFilterRowValue(Dt, "PROCESSED_INVOICE_PATH");

                Global.gCancelledInvoicePath = GetParamFilterRowValue(Dt, "CANCELLED_INVOICE_PATH");
                Global.gDuplicateInvoicePath = GetParamFilterRowValue(Dt, "DUPLICATE_INVOICE_PATH");

                Global.gStartLineNo = commonLib.fnCheckNull(GetParamFilterRowValue(Dt, "START_LINE_FROM"));

                Global.gLine0 = GetParamFilterRowValue(Dt, "LINE_0");
                Global.gLine1 = GetParamFilterRowValue(Dt, "LINE_1");
                Global.gLine2 = GetParamFilterRowValue(Dt, "LINE_2");
                Global.gLine3 = GetParamFilterRowValue(Dt, "LINE_3");
                Global.gLine4 = GetParamFilterRowValue(Dt, "LINE_4");
                Global.gLine5 = GetParamFilterRowValue(Dt, "LINE_5");
                Global.gLine6 = GetParamFilterRowValue(Dt, "LINE_6");
                Global.gLine7 = GetParamFilterRowValue(Dt, "LINE_7");
                Global.gLine8 = GetParamFilterRowValue(Dt, "LINE_8");
                Global.gLine9 = GetParamFilterRowValue(Dt, "LINE_9");
                Global.gLine10 = GetParamFilterRowValue(Dt, "LINE_10");
                Global.gLine11 = GetParamFilterRowValue(Dt, "LINE_11");
                Global.gLine12 = GetParamFilterRowValue(Dt, "LINE_12");
                Global.gLine13 = GetParamFilterRowValue(Dt, "LINE_13");
                Global.gLine14 = GetParamFilterRowValue(Dt, "LINE_14");
                Global.gLine15 = GetParamFilterRowValue(Dt, "LINE_15");
                Global.gLine16 = GetParamFilterRowValue(Dt, "LINE_16");
                Global.gLine17 = GetParamFilterRowValue(Dt, "LINE_17");
                Global.gLine18 = GetParamFilterRowValue(Dt, "LINE_18");
                Global.gLine19 = GetParamFilterRowValue(Dt, "LINE_19");
                Global.gLine20 = GetParamFilterRowValue(Dt, "LINE_20");
                Global.gLine21 = GetParamFilterRowValue(Dt, "LINE_21");
                

                Global.gInvNo = fnCheckNull(GetParamFilterRowValue(Dt, "INV_NO"));
                Global.gInvNoVirtual = fnCheckNull(GetParamFilterRowValue(Dt, "INV_NO_V"));
                Global.gInvNoPrefix = GetParamFilterRowValue(Dt, "INV_NO_PREFIX");
                Global.gInvFileSufix = GetParamFilterRowValue(Dt, "INV_FILE_SUFIX");
                Global.gBmpFileSufix= GetParamFilterRowValue(Dt, "BMP_FILE_SUFIX");
                Global.gGeneratePdfInvoice = GetParamFilterRowValue(Dt, "GENERATE_PDF_INVOICE");
                Global.gRavannaFileSufix = GetParamFilterRowValue(Dt, "RAVANNA_FILE_SUFIX");
                Global.gBlankTemplate = GetParamFilterRowValue(Dt, "BLANK_TEMPLATE");



                Global.gSellerName= GetParamFilterRowValue(Dt, "SELLER_NAME");

                Global.gSellerAdd1= GetParamFilterRowValue(Dt, "SELLER_ADD1");

                Global.gSellerAdd2 = GetParamFilterRowValue(Dt, "SELLER_ADD2");

                Global.gSellerAdd3 = GetParamFilterRowValue(Dt, "SELLER_ADD3");

                Global.gBankName= GetParamFilterRowValue(Dt, "BANK_NAME");

                Global.gIfscCode= GetParamFilterRowValue(Dt, "IFSC_CODE");

                Global.gBankAccountNo= GetParamFilterRowValue(Dt, "ACCOUNT_NO");

                Global.gBankAdd1 = GetParamFilterRowValue(Dt, "BANK_ADD1");

                Global.gBankAdd2= GetParamFilterRowValue(Dt, "BANK_ADD2");

                Global.gCertifyClause= GetParamFilterRowValue(Dt, "CERTIFY_CLAUSE");

                Global.gInstruction = GetParamFilterRowValue(Dt, "INSTRUCTION");

                Global.gInvCurrency = GetParamFilterRowValue(Dt, "INV_CURRENCY");

                Global.gInvCurrencySep = GetParamFilterRowValue(Dt, "INV_CURRENCY_SEP");

                Global.gInvPrintHeightRatio = GetParamFilterRowValue(Dt, "INV_PRINT_HEIGHT_RATIO");

                Global.gInvPrintCopy = GetParamFilterRowValue(Dt, "INV_PRINT_COPY");

                Global.gInvReprintHeight = GetParamFilterRowValue(Dt, "INV_REPRINT_HEIGHT");

                Global.gInvReprintWidth = GetParamFilterRowValue(Dt, "INV_REPRINT_WIDTH");


                Global.gCgstTax= GetParamFilterRowValue(Dt, "CGST_TAX");

                Global.gSgstTax= GetParamFilterRowValue(Dt, "SGST_TAX");


                Global.gIgstTax= GetParamFilterRowValue(Dt, "IGST_TAX");

                Global.gLicenseInfo = GetParamFilterRowValue(Dt, "LICENSE_INFO");

                Global.gLicesseKey= GetParamFilterRowValue(Dt, "LICESSE_KEY");
                Global.gMsgBoxCaption= GetParamFilterRowValue(Dt, "MSG_BOX_CAPTION");
                Global.gControlQualification= GetParamFilterRowValue(Dt, "CONTROl_QUALIFICATION");
                Global.gFormBackcolor = GetParamFilterRowValue(Dt, "FORM_BACKCOLOR");
                Global.gPanelBackcolor= GetParamFilterRowValue(Dt, "PANEL_BACKCOLOR");
                Global.gLabelForecolor = GetParamFilterRowValue(Dt, "LABEL_FORECOLOR");
                Global.gBkupdbname = GetParamFilterRowValue(Dt, "BKUPDBNAME");

                Global.gBkupdevice = GetParamFilterRowValue(Dt, "BKUPDEVICE");

                
                Global.gInvalidPwdAttempt = GetParamFilterRowValue(Dt, "INVALID_PWD_ATTEMPT");

                Global.gHSNCode = GetParamFilterRowValue(Dt, "HSN_CODE");

                Global.gAddNew= GetParamFilterRowValue(Dt, "ADD_NEW");

                Global.gAdminRoleID = GetParamFilterRowValue(Dt, "ADMIN_ROLE_ID");

                Global.gUnitRateSearchPattern = GetParamFilterRowValue(Dt, "UNIT_RATE_SEARCH");

                               
                Global.gAdminSecPass = "KiYjS2FrdXJpQDk2M0RCUzJ5QVNE";


                Global.gPrintRavannaNo = GetParamFilterRowValue(Dt, "PRINT_RAVANNA");


                Global.gPrintInvoiceSlip = GetParamFilterRowValue(Dt, "PRINT_INVOICE_SLIP");


                Global.gAutoBackupEnable= GetParamFilterRowValue(Dt, "DB_AUTO_BKUP");


                Global.gBkupType = GetParamFilterRowValue(Dt, "BKUP_TYPE");


                Global.gDropBoxFolderName = GetParamFilterRowValue(Dt, "DROP_FOLDER_NAME");

                Global.gDropboxToken = GetParamFilterRowValue(Dt, "DROP_BOX_TOKEN");

                Global.gCheckDuplicateInvoice = GetParamFilterRowValue(Dt, "CHECK_DUPLICATE_INVOICE");

                // version

                Global.gVer = GetParamFilterRowValue(Dt, "VER");
                Global.gReleasedApplicationVersion = GetParamFilterRowValue(Dt, "VER");

                Global.gContactUs = GetParamFilterRowValue(Dt, "CONTACT_US");

                //DB variables

                if (ConfigurationManager.AppSettings.Get("APP_RUN_MODE").ToUpper() == "SINGLE")
                {
                    Global.gIsNull = " ifnull ";
                    Global.gLength = " length";
                    Global.gLastInsertedRowId = " last_insert_rowid()";
                }
                else
                {
                    Global.gIsNull = "  isnull ";
                    Global.gLength = " len";
                    Global.gLastInsertedRowId = " SCOPE_IDENTITY() ";
                }




                //objParam.ParaCode = "SOURCE_PATH";
                //Global.gSourcePath = objParam.GetParameterValue();
                //objParam.ParaCode = "RAVANNA_FILE_NAME";
                //Global.gRavannaFileName = objParam.GetParameterValue();
                //objParam.ParaCode = "PROCESSED_INVOICE_PATH";
                //Global.gProcessedInvoicePath = objParam.GetParameterValue();
                //objParam.ParaCode = "CANCELLED_INVOICE_PATH";
                //Global.gCancelledInvoicePath = objParam.GetParameterValue();
                //objParam.ParaCode = "DUPLICATE_INVOICE_PATH";
                //Global.gDuplicateInvoicePath = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_0";
                //Global.gLine0 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_1";
                //Global.gLine1 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_2";
                //Global.gLine2 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_3";
                //Global.gLine3 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_4";
                //Global.gLine4 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_5";
                //Global.gLine5 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_6";
                //Global.gLine6 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_7";
                //Global.gLine7 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_8";
                //Global.gLine8 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_9";
                //Global.gLine9 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_10";
                //Global.gLine10 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_11";
                //Global.gLine11 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_12";
                //Global.gLine12 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_13";
                //Global.gLine13 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_14";
                //Global.gLine14 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_15";
                //Global.gLine15 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_16";
                //Global.gLine16 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_17";
                //Global.gLine17 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_18";
                //Global.gLine18 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_19";
                //Global.gLine19 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_20";
                //Global.gLine20 = objParam.GetParameterValue();
                //objParam.ParaCode = "LINE_21";
                //Global.gLine21 = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_NO";
                //Global.gInvNo = fnCheckNull(objParam.GetParameterValue());
                //objParam.ParaCode = "INV_NO_V";
                //Global.gInvNoVirtual = fnCheckNull(objParam.GetParameterValue());
                //objParam.ParaCode = "INV_NO_PREFIX";
                //Global.gInvNoPrefix = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_FILE_SUFIX";
                //Global.gInvFileSufix = objParam.GetParameterValue();
                //objParam.ParaCode = "BMP_FILE_SUFIX";
                //Global.gBmpFileSufix = objParam.GetParameterValue();
                //objParam.ParaCode = "GENERATE_PDF_INVOICE";
                //Global.gGeneratePdfInvoice = objParam.GetParameterValue();
                //objParam.ParaCode = "RAVANNA_FILE_SUFIX";
                //Global.gRavannaFileSufix = objParam.GetParameterValue();
                //objParam.ParaCode = "BLANK_TEMPLATE";
                //Global.gBlankTemplate = objParam.GetParameterValue();
                //objParam.ParaCode = "SELLER_NAME";
                //Global.gSellerName = objParam.GetParameterValue();
                //objParam.ParaCode = "SELLER_ADD1";
                //Global.gSellerAdd1 = objParam.GetParameterValue();
                //objParam.ParaCode = "SELLER_ADD2";
                //Global.gSellerAdd2 = objParam.GetParameterValue();
                //objParam.ParaCode = "SELLER_ADD3";
                //Global.gSellerAdd3 = objParam.GetParameterValue();
                //objParam.ParaCode = "BANK_NAME";
                //Global.gBankName = objParam.GetParameterValue();
                //objParam.ParaCode = "IFSC_CODE";
                //Global.gIfscCode = objParam.GetParameterValue();
                //objParam.ParaCode = "ACCOUNT_NO";
                //Global.gBankAccountNo = objParam.GetParameterValue();
                //objParam.ParaCode = "BANK_ADD1";
                //Global.gBankAdd1 = objParam.GetParameterValue();
                //objParam.ParaCode = "BANK_ADD2";
                //Global.gBankAdd2 = objParam.GetParameterValue();
                //objParam.ParaCode = "CERTIFY_CLAUSE";
                //Global.gCertifyClause = objParam.GetParameterValue();
                //objParam.ParaCode = "INSTRUCTION";
                //Global.gInstruction = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_CURRENCY";
                //Global.gInvCurrency = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_CURRENCY_SEP";
                //Global.gInvCurrencySep = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_PRINT_HEIGHT_RATIO";
                //Global.gInvPrintHeightRatio = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_PRINT_COPY";
                //Global.gInvPrintCopy = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_REPRINT_HEIGHT";
                //Global.gInvReprintHeight = objParam.GetParameterValue();
                //objParam.ParaCode = "INV_REPRINT_WIDTH";
                //Global.gInvReprintWidth = objParam.GetParameterValue();
                //objParam.ParaCode = "CGST_TAX";
                //Global.gCgstTax = objParam.GetParameterValue();
                //objParam.ParaCode = "SGST_TAX";
                //Global.gSgstTax = objParam.GetParameterValue();
                //objParam.ParaCode = "IGST_TAX";
                //Global.gIgstTax = objParam.GetParameterValue();
                //objParam.ParaCode = "LICENSE_INFO";
                //Global.gLicenseInfo = objParam.GetParameterValue();
                //objParam.ParaCode = "LICESSE_KEY";
                //Global.gLicesseKey = objParam.GetParameterValue();
                //objParam.ParaCode = "MSG_BOX_CAPTION";
                //Global.gMsgBoxCaption = objParam.GetParameterValue();
                //objParam.ParaCode = "CONTROl_QUALIFICATION";
                //Global.gControlQualification = objParam.GetParameterValue();
                //objParam.ParaCode = "FORM_BACKCOLOR";
                //Global.gFormBackcolor = objParam.GetParameterValue();
                //objParam.ParaCode = "PANEL_BACKCOLOR";
                //Global.gPanelBackcolor = objParam.GetParameterValue();
                //objParam.ParaCode = "LABEL_FORECOLOR";
                //Global.gLabelForecolor = objParam.GetParameterValue();
                //objParam.ParaCode = "BKUPDBNAME";
                //Global.gBkupdbname = objParam.GetParameterValue();
                //objParam.ParaCode = "BKUPDEVICE";
                //Global.gBkupdevice = objParam.GetParameterValue();
                //objParam.ParaCode = "VER";
                //Global.gVer = objParam.GetParameterValue();
                //objParam.ParaCode = "INVALID_PWD_ATTEMPT";
                //Global.gInvalidPwdAttempt = objParam.GetParameterValue();
                //objParam.ParaCode = "HSN_CODE";
                //Global.gHSNCode = objParam.GetParameterValue();
                //objParam.ParaCode = "ADD_NEW";
                //Global.gAddNew = objParam.GetParameterValue();

                //objParam.ParaCode = "ADMIN_ROLE_ID";
                //Global.gAdminRoleID = objParam.GetParameterValue();

                //objParam.ParaCode = "UNIT_RATE_SEARCH";
                //Global.gUnitRateSearchPattern = objParam.GetParameterValue();

                //Global.gAdminSecPass= "KiYjS2FrdXJpQDk2M0RCUzJ5QVNE";


                //objParam.ParaCode = "PRINT_RAVANNA";
                //Global.gPrintRavannaNo  = objParam.GetParameterValue();

                //objParam.ParaCode = "PRINT_INVOICE_SLIP";
                //Global.gPrintInvoiceSlip = objParam.GetParameterValue();

                //// backup related infor
                //objParam.ParaCode = "DB_AUTO_BKUP";
                //Global.gAutoBackupEnable= objParam.GetParameterValue();

                //objParam.ParaCode = "BKUP_TYPE";
                //Global.gBkupType = objParam.GetParameterValue();

                //objParam.ParaCode = "DROP_FOLDER_NAME";
                //Global.gDropBoxFolderName = objParam.GetParameterValue();

                //objParam.ParaCode = "DROP_BOX_TOKEN";
                //Global.gDropboxToken = objParam.GetParameterValue();

                //objParam.ParaCode = "CHECK_DUPLICATE_INVOICE";
                //Global.gCheckDuplicateInvoice = objParam.GetParameterValue();


                //// version

                //objParam.ParaCode = "VER";
                //Global.gReleasedApplicationVersion = objParam.GetParameterValue();

                //objParam.ParaCode = "CONTACT_US";
                //Global.gContactUs = objParam.GetParameterValue();





            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }



        // user based global parameter
        static public void PopulateLoginBasedGlobalParameter()
        {
            try
            {
                //Populate SMTP Details
                DataTable DT;
                EmailManagement objEmail = new EmailManagement();

                if (Global.gMailID == string.Empty || Global.gMailID == null)
                {

                    objEmail.UserId = Global.gUserID.ToUpper();
                    DT = objEmail.GetMailSetting();
                    if (DT != null && DT.Rows.Count > 0)
                    {
                        DataRow row = DT.Rows[0];
                        Global.gMailID = row["mail_id"].ToString();
                        Global.gMailPWd = row["mail_pwd"].ToString();
                        Global.gSMTPRK = fnCheckNull(row["smtp_rk"].ToString());
                        Global.gSMTPAddress = row["smtp_address"].ToString();
                        Global.gSMTPSSLPort = fnCheckNull(row["ssl_port"].ToString());
                        Global.gSSLAuthRequired = row["auth_required"].ToString();
                    }
                }



            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }




        static public void PopulateCombo(DataTable pDT, ComboBox pCmb)
        {
            pCmb.DataSource = pDT;
            pCmb.DisplayMember = "Value";
            pCmb.ValueMember = "Code";

        }

        static public void PopulateCombo(DataTable pDT, ComboBox pCmb, Boolean pSelectItem)
        {
            pCmb.DataSource = pDT;
            pCmb.DisplayMember = "Value";
            pCmb.ValueMember = "Code";

            if (pSelectItem == true)
            {
                if (pCmb.Items.Count > 0)
                {
                    pCmb.SelectedIndex = 0;
                }
            }
            else
            {
                pCmb.SelectedIndex = -1;

            }

        }


        static public void ShowDBMessage(string pInput)
        {

            //Display Message
            int InfoType = commonLib.GetInformationType(pInput);
            string Info = commonLib.GetInformation(pInput);
            if (InfoType < Global.gErrorNoLowerLimit)
            {
                commonLib.showUIMessage(Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                commonLib.showUIMessage(Info, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        static public string ShowDBMessage(string pInput , string pGetErrorType)
        {

            try
            {
                //Display Message
                int InfoType = commonLib.GetInformationType(pInput);
                string Info = commonLib.GetInformation(pInput);
                if (InfoType < Global.gErrorNoLowerLimit)
                {
                    commonLib.showUIMessage(Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "1";
                }
                else
                {
                    commonLib.showUIMessage(Info, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return "0";
                }
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "0";
            }


        }

        static public int GetInformationType(string pInput)
        {
            try
            {
                string[] strMsg = pInput.Split('~');
                return fnCheckNull(strMsg[0]);
            }
            catch (Exception e)
            {
                return 1000;
            }

        }
        static public string GetInformation(string pInput)
        {
            try
            {
                string[] strMsg = pInput.Split('~');
                return (strMsg[1]);
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        static public Decimal fnCheckDecimal(string pInputstr)
        {
            try
            {
                return Convert.ToDecimal(pInputstr);
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        static public DateTime ConvertStringtoDate(string pDateString)
        {

            try
            {
                pDateString = pDateString.Replace('-', '/');
                return DateTime.ParseExact(pDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

        }

        static public DateTime ConvertStringtoDateHHMMSS(string pDateString)
        {

            try
            {
                pDateString = pDateString.Replace('-', '/');
                return DateTime.ParseExact(pDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

        }


        static public DateTime ConvertSqlStringtoDate(string pDateString)
        {

            try
            {
                return DateTime.ParseExact(pDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

        }

        static public DateTime ConvertSqlStringtoDateHHMMSS(string pDateString)
        {

            try
            {
                return DateTime.ParseExact(pDateString, "yyyy-MM-dd 00:00:00", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

        }


        static public string ConvertTranDateFormat(DateTime   pDateTime)
        {

            try
            {
                return pDateTime.ToString("yyyy-MM-dd 00:00:00");
                //return pDateTime.ToString("yyyy-MM-dd");
            }
            catch (Exception e)
            {
                return DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            }

        }


        static public void PopulateBuyerCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "buyer_master";
                objCommonDBFunc.CodeColumnName = "buyer_rk";
                objCommonDBFunc.DisplayColumnName = "name";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulateBuyerCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll,bool pFirstItemSelected)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "buyer_master";
                objCommonDBFunc.CodeColumnName = "buyer_rk";
                objCommonDBFunc.DisplayColumnName = "name";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
                ComboFirstItemSelected(pComobo, pFirstItemSelected);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static private void ComboFirstItemSelected( ComboBox pComobo ,bool pFirstItemSelected)
        {

            if (pFirstItemSelected)
            {
                if (pComobo.Items.Count > 0)
                {
                    pComobo.SelectedIndex = 0;
                }
            }


        }


        static public void PopulateSaleItemCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "vw_item_master_sale";
                objCommonDBFunc.CodeColumnName = "ItemRk";
                objCommonDBFunc.DisplayColumnName = "ItemDesc";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulateItemCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "item_master";
                objCommonDBFunc.CodeColumnName = "item_rk";
                objCommonDBFunc.DisplayColumnName = "item_desc";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulatePurchaseItemCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "vw_item_master_purchase";
                objCommonDBFunc.CodeColumnName = "ItemRk";
                objCommonDBFunc.DisplayColumnName = "ItemDesc";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        static public void PopulateVendorCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "vendor_master";
                objCommonDBFunc.CodeColumnName = "vendor_rk";
                objCommonDBFunc.DisplayColumnName = "name";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulateParamMasterCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "param_master";
                objCommonDBFunc.CodeColumnName = "para_code";
                objCommonDBFunc.DisplayColumnName = "para_value";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        static public void PopulateParamMasterCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll, bool pFirstItemSelected)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "param_master";
                objCommonDBFunc.CodeColumnName = "para_code";
                objCommonDBFunc.DisplayColumnName = "para_value";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
                ComboFirstItemSelected(pComobo, pFirstItemSelected);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulateParamMasterComboCodeDisplaySame(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "param_master";
                objCommonDBFunc.CodeColumnName = "para_value";
                objCommonDBFunc.DisplayColumnName = "para_value";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        static public void PopulateExpenseHeadCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "expense_master";
                objCommonDBFunc.CodeColumnName = "expense_rk";
                objCommonDBFunc.DisplayColumnName = "expense_desc";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void PopulateLedgerExpenseHeadCombo(ComboBox pComobo, string pAddNew, string pDataFilter, string pShowAll)

        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "vw_Cash_Ledger_sub_headwise";
                objCommonDBFunc.CodeColumnName = "SubHead";
                objCommonDBFunc.DisplayColumnName = "SubHead";
                objCommonDBFunc.ShowAddNew = pAddNew;
                objCommonDBFunc.DataFilter = pDataFilter;
                objCommonDBFunc.ShowAll = pShowAll;
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, pComobo, false);
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        static public string GetComboSelectedValue(ComboBox pComobo)

        {
            try
            {
                if (pComobo.SelectedIndex > -1 )
                    return pComobo.SelectedValue.ToString();
               else
                    return "";
            }
            catch (Exception e)
            {
                return "";
            }

        }

        static public string GetComboSelectedText(ComboBox pComobo)

        {
            try
            {
                return pComobo.GetItemText(pComobo.SelectedItem);
            }
            catch (Exception e)
            {
                return "";
            }

        }


        static public void SetCustomDateFormat(DateTimePicker dt)
        {
            try
            {
                dt.Format = DateTimePickerFormat.Custom;
                dt.CustomFormat = "dd-MMM-yyyy";
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public string ReportingDateString(DateTimePicker dt)
        {
            try
            {
                return dt.Value.ToString("yyyy-MM-dd");
            }
            catch (Exception e)
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }

        }

        static public string ReportingDateStringHHMMSS(DateTimePicker dt)
        {
            try
            {
                return dt.Value.ToString("yyyy-MM-dd 00:00:00");
            }
            catch (Exception e)
            {
                return DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            }

        }



        static public string ReportingDateStringHHMMSS(DateTime dt)
        {
            try
            {
                return dt.ToString("yyyy-MM-dd 00:00:00");
            }
            catch (Exception e)
            {
                return dt.ToString("yyyy-MM-dd 00:00:00");
            }

        }



        static public void DataBackupAuto()
        {
            try
            {
                string strBackupEnable;
                int Result;

                //// check if auotbackup is enabled
                //ParameterDetails objParam = new ParameterDetails();
                //objParam.ParaCode = "DB_AUTO_BKUP";
                //strBackupEnable = objParam.GetParameterValue();
                //// check if autobackup is enabled

                //if (strBackupEnable == "N")
                //    return;

                // check if the backup for the day has been taken or not if not then take the backup 

                AdminTask objAdmin = new AdminTask();
                objAdmin.ActivityType = "DB_BACKUP";
                objAdmin.ActivityDate = GetReportingDateFormat();
                Result =  fnCheckNull(objAdmin.AutoDBBackupTaken());

                if (Result > 0)
                    return;

                DataBackup();

            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        static public void DataBackup()
        {
            try
            {

                if (ConfigurationManager.AppSettings.Get("BKUP_TYPE") == "M")
                    DataBackupMail();
                else
                    DropBox.DataBackupDropbox();

            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        static public void DataBackupMail()
        {


            try
            {

                string strDbFileName = commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("DB_FILE_NAME"));
                string strBkupFileName;

                // check if mail setup exists
                if (fnCheckNull1(Global.gMailID) == "")
                    return;

                // check if autobackup has valid email

                AdminTask objAdmin = new AdminTask();
                string strToMailID = fnCheckNull1(objAdmin.AutoDBBackupToMailID());

                if (strToMailID == "")
                    return;

                ParameterDetails objParam = new ParameterDetails();
                objParam.ParaCode = "BKUP_FILE_NAME";
                strBkupFileName = objParam.GetParameterValue();

                string workingDirectory = Environment.CurrentDirectory;
                // or: Directory.GetCurrentDirectory() gives the same result
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                string SourcestrFilePath = projectDirectory.Replace("\\", "/") + "/DataFile/" + strDbFileName;
                string DestinationFilePath = projectDirectory.Replace("\\", "/") + "/DataFile/" + strBkupFileName;
                //remove already reated backup

                if (File.Exists(DestinationFilePath))
                {
                    File.Delete(DestinationFilePath);
                }

                // copythe db copy
                File.Copy(SourcestrFilePath, DestinationFilePath, true);


                MailingFunc.HighPriorty = true;
                MailingFunc.To = strToMailID;
                MailingFunc.Subject = "Data backup";
                MailingFunc.MailingUserID = Global.gMailID;
                MailingFunc.MailingPWD = commonLib.GetDecryptedPassword(Global.gMailPWd);

                MailingFunc.Body = "Database Backup is attached";
                MailingFunc.AttachmentPath = DestinationFilePath;
                
                // set smtp details
                MailingFunc.SMPTPPort = Global.gSMTPSSLPort;
                MailingFunc.EnableSSL = true;
                MailingFunc.SmtpClient = Global.gSMTPAddress;

                // in case mailed file needs to be removed
                MailingFunc.SendEmailAsync();

            }
            catch (Exception e)
            {

            }

        }

        static public string GetReportingDateFormat()
        {
            try
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
            catch (Exception e)
            {
                return "";

            }
        }

        static public string GetReportingDateFormat(int pDaysInterval)
        {
            try { 
            return DateTime.Now.AddMonths(pDaysInterval).ToString("yyyy-MM-dd");
            }
            catch (Exception e)
            {
                return "";

            }
        }


        static public bool KeyPressNumber(KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;

            }
        }


        static public bool KeyPressDecimal(KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;

            }
        }


        static public bool KeyPressDecimalMinus(KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;

            }
        }

        static public DataTable AddSummaryColumnDataTable(string[] pColumnName, DataTable pdt)
        {
            try
            {
                if (pdt.Rows.Count == 0)
                    return pdt;
                int countColumn = pColumnName.Length;
                int iRowCount;
                decimal[] total = new decimal[countColumn];
                //string[] value = { "", "", "" };

                foreach (DataRow row in pdt.Rows)
                {
                    for (int i = 0; i < countColumn; i++)
                    {
                        total[i] += fnCheckDecimal(row[pColumnName[i]].ToString());
                    }

                }
                // add new row for total
                pdt.Rows.Add();
                iRowCount = pdt.Rows.Count - 1;
                for (int i = 0; i < countColumn; i++)
                {
                    pdt.Rows[iRowCount][pColumnName[i]] = total[i].ToString();
                }
                pdt.Rows[iRowCount][0] = "Grand Total";
                return pdt;
            }
            catch (Exception ex)
            {
                return pdt;

            }

        }

        static public DataTable AddSummaryColumnDataTable(string[] pColumnName, DataTable pdt , int pGrandTotalColIndex)
        {
            try
            {
                if (pdt.Rows.Count == 0)
                    return pdt;
                int countColumn = pColumnName.Length;
                int iRowCount;
                decimal[] total = new decimal[countColumn];
                //string[] value = { "", "", "" };

                foreach (DataRow row in pdt.Rows)
                {
                    for (int i = 0; i < countColumn; i++)
                    {
                        total[i] += fnCheckDecimal(row[pColumnName[i]].ToString());
                    }

                }
                // add new row for total
                pdt.Rows.Add();
                iRowCount = pdt.Rows.Count - 1;
                for (int i = 0; i < countColumn; i++)
                {
                    pdt.Rows[iRowCount][pColumnName[i]] = total[i].ToString();
                }
                pdt.Rows[iRowCount][pGrandTotalColIndex] = "Grand Total";
                return pdt;
            }
            catch (Exception ex)
            {
                return pdt;

            }

        }



    }



}
