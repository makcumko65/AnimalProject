using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EmailSender: IEmailSender
    {
        private readonly IConfiguration Configuration;

        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Configuration["SendGrid:SendGridKey"], subject, message, email);
        }

        private Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(Configuration["SendGrid:SenderEmail"], Configuration["SendGrid:SendGridUser"]),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}

