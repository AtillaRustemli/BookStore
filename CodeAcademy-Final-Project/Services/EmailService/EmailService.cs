using CodeAcademy_Final_Project.Models.EmailModel;
using MailKit.Net.Smtp;
using MimeKit;

namespace CodeAcademy_Final_Project.Services.EmailService
{
    public class EmailService:IEmailService
    {
        private const string templatePath = @"Views/shared/{0}.cshtml";
        private readonly EmailConfig _smtpConfig;
        public EmailService(EmailConfig smtpConfig)
        {
            _smtpConfig = smtpConfig;
        }
        public MimeMessage CreateEmail(string subject, string message, List<string> addresses, string path)
        {
            var to = new List<MailboxAddress>();
            foreach (var address in addresses)
            {
                to.Add(new MailboxAddress(string.Empty, address));
            }
            var builder = new BodyBuilder();
            builder.Attachments.Add(path);
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.From));
            emailMessage.To.AddRange(to);
            emailMessage.Subject = subject;
            emailMessage.Body = builder.ToMessageBody();

            return emailMessage;

        }
        public void SendEmail(MimeMessage message)
        {
            using (var client = new SmtpClient())
            {
                try
                {

                    client.Connect("smtp.gmail.com", _smtpConfig.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_smtpConfig.From, _smtpConfig.Password);
                    client.Send(message);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }

            }

        }
    }
}
