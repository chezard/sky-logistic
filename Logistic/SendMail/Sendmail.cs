using System.Net.Mail;
using System.Net;

namespace Logistic.SendMail
{
    public class Sendmail
    {
        
        public static async Task SendMessage(string mailTo, string messageSubject, string messageBody)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("t9339342@gmail.com", "gcxnvekdntsaxive");
            //client.Credentials = new NetworkCredential("t9339342@gmail.com", "guohybiscgvgirax");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("t9339342@gmail.com", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            try
            {
                await client.SendMailAsync(message);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
