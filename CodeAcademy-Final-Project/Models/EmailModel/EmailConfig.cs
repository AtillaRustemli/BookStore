namespace CodeAcademy_Final_Project.Models.EmailModel
{
    public class EmailConfig
    {
        public EmailConfig()
        {
            From = "atillaproject52@gmail.com";
            SmtpServer = "smtp.gmail.com";
            Port = 465;
            UserName = "AtillasProject";
            Password = "uuxvfomkqlbunnlk";
        }
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
