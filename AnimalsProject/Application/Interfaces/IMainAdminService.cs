using Application.DTO;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMainAdminService
    {
        Task<bool> AddEmailAsync(AdminEmailDto model);
        IEnumerable<IdentityUser> GetUnconfirmedAdmins();
    }
}
