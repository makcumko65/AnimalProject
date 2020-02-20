using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMainAdminService _adminService;

        public AdminController(IMainAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewEmailAsync(AdminEmailDto model)
        {
            if (ModelState.IsValid && await _adminService.AddEmailAsync(model))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public IEnumerable<IdentityUser> GetUnconfirmedAdmins()
        {
            return _adminService.GetUnconfirmedAdmins();
        }
    }
}
