using BenjaminTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BenjaminTest
{
    public class Functions
    {

        public static string SendEmailAttachment(string subject, string body)
        {
            string message = "",
                username = "btrako19@gmail.com",
                password = "";


            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("btrako19@gmail.com");
                mail.To.Add("btrako19@gmail.com");
                mail.Subject = subject;
                mail.Body = body;

                System.Net.Mail.Attachment attachment;

                DirectoryInfo d = new DirectoryInfo(@"C:/Screenshot/");
                FileInfo[] Files = d.GetFiles("*.jpeg", SearchOption.AllDirectories);

                foreach (FileInfo file in Files)
                {
                    attachment = new System.Net.Mail.Attachment(file.FullName);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 465;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                mail.Dispose();

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }
    }
}