using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<bool> AddEmailAsync(AdminEmailDto model)
        {
            if (model == null)
            {
                return false;
            }

            var identityUser = new IdentityUser { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(identityUser);

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }

        public IEnumerable<IdentityUser> GetUnconfirmedAdmins()
        {
            return _userManager.Users.Where(u => u.PasswordHash == null).ToList();
        }
    }
}
