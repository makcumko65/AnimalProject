using Application.DTO;
using SendGrid;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<Response> RegisterAsync(AdminDto model);

        Task<string> LoginAsync(AdminDto model);

        Task<bool> ConfirmEmailAsync(string userId, string token);
    }
}
