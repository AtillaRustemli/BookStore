using MimeKit;

namespace CodeAcademy_Final_Project.Services.EmailService
{
    public interface IEmailService
    {
        MimeMessage CreateEmail(string subject, string message, List<string> addresses, string path);
        void SendEmail(MimeMessage message);

    }
}
