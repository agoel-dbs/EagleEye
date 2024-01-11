using Dropbox.Api;
using Dropbox.Api.Files;
using EagleEye.DBLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye.Lib
{
    class DropBox
    {
        private static string destFilePath;

        static public void DataBackupDropbox()
        {
            try
            {
                string strDbFileName = commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("DB_FILE_NAME"));
                string strBkupFileName;
                ParameterDetails objParam = new ParameterDetails();
                objParam.ParaCode = "BKUP_FILE_NAME";
                strBkupFileName = objParam.GetParameterValue();

                //string SourcestrFilePath = ConfigurationManager.AppSettings.Get("DB_PATH");

                string strFilePath = "";
                if (ConfigurationManager.AppSettings.Get("CONFIG_DB_PATH").Trim() == "Y")
                {

                    strFilePath =  ConfigurationManager.AppSettings.Get("DB_PATH").Trim();
                }
                else
                {
                    // This will get the current WORKING directory (i.e. \bin\Debug)
                    string workingDirectory = Environment.CurrentDirectory;
                    // or: Directory.GetCurrentDirectory() gives the same result
                    // This will get the current PROJECT directory
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                    strFilePath = projectDirectory.Replace("\\", "/") + "/DataFile/EagleEyeDB.db";
                }


                string DestinationFilePath = strFilePath.Replace(strDbFileName, "") + strBkupFileName;
                //remove already reated backup

                if (File.Exists(DestinationFilePath))
                {
                    File.Delete(DestinationFilePath);
                }

                // copythe db copy
                File.Copy(strFilePath, DestinationFilePath, true);
                destFilePath = DestinationFilePath;
                var task = Task.Run((Func<Task>)Run);
                task.Wait();

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        static async Task Run()
        {
            try
            {
                string token = Global.gDropboxToken;
                using (var dbx = new DropboxClient(token))
                {
                    string file = destFilePath;
                    //string folder = "/" + Global.gDropBoxFolderName + "/" + DateTime.Now.DayOfWeek.ToString();// "/Public";
                    string folder = "/" + Global.gDropBoxFolderName ;
                    string filename = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") +
                                       "_" + commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("DB_FILE_NAME"));
                    string url = "";

                    using (var mem = new MemoryStream(File.ReadAllBytes(file)))
                    {
                        var updated = dbx.Files.UploadAsync(folder + "/" + filename, WriteMode.Overwrite.Instance, body: mem);
                        updated.Wait();
                        var tx = dbx.Sharing.CreateSharedLinkWithSettingsAsync(folder + "/" + filename);
                        tx.Wait();
                        url = tx.Result.Url;
                    }

                    if (url != "")
                    {
                        // insert a record in table
                        AdminTask objAdmin = new AdminTask();
                        objAdmin.ActivityType = "DB_BACKUP";
                        objAdmin.CreatedBy = Global.gUserID;
                        objAdmin.SetBackupEntry();

                        // set parameter values
                        ParameterDetails objParam = new ParameterDetails();
                        objParam.ParaCode = "DROP_BOX_FILE_NAME";
                        objParam.ParaValue = filename;
                        objParam.SetParameterValue();
                    }

                }
            }
            catch (Exception e)
            {
                //commonLib.showUIMessage(e.Message , MessageBoxButtons.OK, MessageBoxIcon.Stop);

                throw e;
            }
        }




    }
}
