using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;
namespace DLU.Areas.Admin.Controllers.TaiKhoan
{
    public class Resetpassword
    {
            //public void SendMail(string ToGmail, string TieuDe, string ThôngTin)
            //{
            //    var fromEmailAddress = "dinhvanlanh96@gmail.com";
            //    var fromEmailDisplayName ="DLU";
            //    var fromEmailPassword = "0966334404";
            //    var smtpHost = "smtp.gmail.com";
            //    var smtpPort = "587";
            //    bool enabledSsl = true;        
            //    MailMessage message = new MailMessage(new MailAddress(fromEmailAddress, fromEmailDisplayName), new MailAddress(ToGmail));
            //    message.Subject = TieuDe;
            //    message.IsBodyHtml = true;
            //    message.Body = ThôngTin;
            //    var client = new SmtpClient();
            //    client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            //    client.Host = smtpHost;
            //    client.EnableSsl = enabledSsl;
            //    client.Port = !string.IsNullOrEmpty(smtpPort) ? Convert.ToInt32(smtpPort) : 0;
            //    client.Send(message);


            //}
        public static void SendEmail(string mailNhan, string tieuDe, string NoiDung)
        {
            MailMessage mail = new MailMessage("hethong.online.dlu@gmail.com", mailNhan);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            NetworkCredential NetworkCred = new NetworkCredential("hethong.online.dlu@gmail.com", "hethong123456789");
            client.Credentials = NetworkCred;
            mail.Subject = tieuDe;
            mail.Body = NoiDung;
            client.Send(mail);
        }
        
    }
}