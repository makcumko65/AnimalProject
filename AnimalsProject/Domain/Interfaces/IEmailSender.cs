using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEmailSender
    {
        Task Send(string email, string subject, string message);
    }
}
