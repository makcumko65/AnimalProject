using SendGrid;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmailService
    {
        Task<Response> SendEmailAsync(string email, string subject, string message);
    }
}
