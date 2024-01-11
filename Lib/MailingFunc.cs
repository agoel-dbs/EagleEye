using EagleEye.DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye.Lib
{
class MailingFunc
    {
        
        static public string MailingUserID { get; set; }
        static public string MailingPWD { get; set; }
        static public string SmtpClient { get; set; }
        static public string To { get; set; }
        static public string CC { get; set; }
        static public string Subject { get; set; }
        static public string Body { get; set; }
        static public Boolean HighPriorty { get; set; }
        static public string AttachmentPath { get; set; }


        static public int SMPTPPort { get; set; }

        static public Boolean EnableSSL { get; set; }

        
        static public string SendEmail()
        {

                string strMsg;
                MailMessage message;
                SmtpClient smtp;

                message = new MailMessage();

                if (HighPriorty == true)
                {
                    message.Priority = MailPriority.High;
                }

                message.Subject = Subject;
                message.From = new MailAddress(MailingUserID);
                message.Body = Body;
                message.To.Add(new MailAddress(To));
                if (CC!= null && CC.Trim().Length > 3)
                    message.CC.Add(new MailAddress(CC)); ;

            if (AttachmentPath.Length > 0)
            {
                if (System.IO.File.Exists(AttachmentPath))
                {
                    Attachment objAttachment = new Attachment(AttachmentPath);
                    objAttachment.Name = Path.GetFileName(AttachmentPath); 
                    message.Attachments.Add(objAttachment);

                }
            }

            // set smtp details
            smtp = new SmtpClient(SmtpClient);
            smtp.Port = SMPTPPort;
            smtp.EnableSsl = EnableSSL;
            smtp.Credentials = new NetworkCredential(MailingUserID, MailingPWD);
            try
            {
                smtp.Send(message);
                return "Mail sent sucessfuly!!!";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        static public void SendEmailAsync()
        {

            string strMsg;
            MailMessage message;
            SmtpClient smtp;

            message = new MailMessage();

            if (HighPriorty == true)
            {
                message.Priority = MailPriority.High;
            }

            message.Subject = Subject;
            message.From = new MailAddress(MailingUserID);
            message.Body = Body;
            message.To.Add(new MailAddress(To));
            if (CC != null && CC.Trim().Length > 3)
                message.CC.Add(new MailAddress(CC)); ;

            if (AttachmentPath.Length > 0)
            {
                if (System.IO.File.Exists(AttachmentPath))
                {
                    Attachment objAttachment = new Attachment(AttachmentPath);
                    objAttachment.Name = Path.GetFileName(AttachmentPath);
                    message.Attachments.Add(objAttachment);
                    
                }
            }

            // set smtp details
            smtp = new SmtpClient(SmtpClient);
            smtp.Port = SMPTPPort;
            smtp.EnableSsl = EnableSSL;
            smtp.Credentials = new NetworkCredential(MailingUserID, MailingPWD);
            try
            {
                smtp.SendAsync(message, message.Subject);
                smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            }
            catch (Exception e)
            {

            }

        }

        private static void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled == true)
                {
                    commonLib.showUIMessage("Email sending cancelled", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (e.Error != null)
                {
                    commonLib.showUIMessage(e.Error.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    AdminTask objAdmin = new AdminTask();
                    objAdmin.ActivityType = "DB_BACKUP";
                    objAdmin.CreatedBy = Global.gUserID;
                    objAdmin.SetBackupEntry();

                    commonLib.showUIMessage("Backup created and mailed sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            finally
            {
            
            
            }

        }
    }
}
