using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MainAdminService : IMainAdminService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public MainAdminService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> AddEmailOfNewAdminAsync(AdminEmailDto model)
        {        
            var identityUser = new IdentityUser { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(identityUser);
            return result.Succeeded;
        }
    }
}
