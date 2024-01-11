using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Lib
{
    class Global
    {
        static public string gUserID;
        static public string  gSellerGSTIN;
        static public string gSourcePath;
        static public string gRavannaFileName;
        static public string gProcessedInvoicePath;
        static public string gCancelledInvoicePath;
        static public string gDuplicateInvoicePath;
        static public string gLine0;
        static public string gLine1;
        static public string gLine2;
        static public string gLine3;
        static public string gLine4;
        static public string gLine5;
        static public string gLine6;
        static public string gLine7;
        static public string gLine8;
        static public string gLine9;
        static public string gLine10;
        static public string gLine11;
        static public string gLine12;
        static public string gLine13;
        static public string gLine14;
        static public string gLine15;
        static public string gLine16;
        static public string gLine17;
        static public string gLine18;
        static public string gLine19;
        static public string gLine20;
        static public string gLine21;
        static public int gInvNo;
        static public int gInvNoVirtual;
        static public string gInvNoPrefix;
        static public string gInvFileSufix;
        static public string gBmpFileSufix;
        static public string gGeneratePdfInvoice;
        static public string gRavannaFileSufix;
        static public string gBlankTemplate;
        static public string gSellerName;
        static public string gSellerAdd1;
        static public string gSellerAdd2;
        static public string gSellerAdd3;
        static public string gBankName;
        static public string gIfscCode;
        static public string gBankAccountNo;
        static public string gBankAdd1;
        static public string gBankAdd2;
        static public string gCertifyClause;
        static public string gInstruction;
        static public string gInvCurrency;
        static public string gInvCurrencySep;
        static public string gInvPrintHeightRatio;
        static public string gInvPrintCopy;
        static public string gInvReprintHeight;
        static public string gInvReprintWidth;
        static public string gCgstTax;
        static public string gSgstTax;
        static public string gIgstTax;
        static public string gLicenseInfo;
        static public string gLicesseKey;
        static public string gMsgBoxCaption;
        static public string gControlQualification;
        static public string gFormBackcolor;
        static public string gPanelBackcolor;
        static public string gLabelForecolor;
        static public string gBkupdbname;
        static public string gBkupdevice;
        static public string gVer;
        static public string gInvalidPwdAttempt;
        static public string gHSNCode;
        static public string gAddNew;
        static public string gAdminRoleID;
        static public string gUnitRateSearchPattern;

        // variable to hold the values for Invocing

        static public int gInvoiceRk;
        static public int gStartLineNo;
        static public string gRavaanaNo;
        static public string gDistrict;
        static public string gCrusherName;
        static public string gLicenseNo;
        static public string gSellerGST;
        static public string gMaterial;
        static public string gBuyerName;
        static public string gBuyerAddress;
        static public string gBuyerGST;
        static public string gRoute;
        static public string gVechileNo;

        static public decimal gInvoiceQty;
        static public string gDispatchDateTime;
        static public string gPassValidityUpto;
        static public string gRate;
        static public decimal gIGSTAmt;
        static public decimal gSGSTAmt;
        static public decimal gCGSTAmt;
        static public decimal gTotalInvAmt;
        static public decimal gItemUnitRate;
        static public string gPrintRavannaNo;

        // Invoice Slip Prinintg
        static public string gPrintInvoiceSlip; 


        // SMTP Details of User

        static public string gMailID;
        static public string gMailPWd;
        static public string gSMTPAddress;
        static public int gSMTPRK;
        static public int gSMTPSSLPort;
        static public string gSSLAuthRequired;

                          
        // constatncr
        static public int gErrorNoLowerLimit = 99;

        // Secret Pass
        static public string gAdminSecPass = "KiYjS2FrdXJpQDk2M0RCUzJ5QVNE";
        static public bool gSpecialAdminPower = false;


        // Backup Realted info

        static public string gAutoBackupEnable;
        static public string gBkupType;
        static public string gDropBoxFolderName;
        static public string gDropboxToken;


        // Duplicate file format to be used for (Duplicate file)

        static public string gCheckDuplicateInvoice ;

        static public DateTime gLoginTime = DateTime.Now;


        //version control

        static public string gCurrentApplicationVersion = "1.0.0.6";
        static public string gReleasedApplicationVersion ;
        static public string gContactUs;
        static public int gAdvanceDaysofLicenceExpiry;



        // Database function related global variables
        static public string gIsNull = " ifnull";
        static public string gLength = " length";
        static public string gLastInsertedRowId = " last_insert_rowid()";

    }
}
