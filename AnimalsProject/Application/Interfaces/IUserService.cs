using Application.DTO;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(AdminDto model);

        Task<string> LoginAsync(AdminDto model);

        Task<bool> ConfirmEmailAsync(string userId, string token);
    }
}
