using Application.DTO;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(AdminRegisterDto model);

        Task<string> LoginAsync(AdminLoginDto model);

        Task<bool> ConfirmEmailAsync(string userId, string token);
    }
}
