using System;
using MailKit.Net.Smtp;
using MimeKit;
using ShData;
using ShScheduler.ViewModels;

namespace ShScheduler.Smtp
{
    static class Mailer
    {
        public static void SendEmail(EmailMessage em)
        {
            var smtp = DataAccess.ReadSmtp();
            if (smtp == null)
                throw new Exception("You don't have any email account specified");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Scheduler", smtp.Email));
            message.To.Add(new MailboxAddress(em.To, em.ToEmail));
            message.Subject = em.Subject;

            message.Body = new TextPart("plain")
            {
                Text = em.Body
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(smtp.Smtp, smtp.Port, smtp.UseSsl);


                client.Authenticate(smtp.Email, smtp.Password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
