using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> AddEmailOfNewAdminAsync(AdminEmailDto model)
        {
            if (ModelState.IsValid && await _adminService.AddEmailOfNewAdminAsync(model))
            {
                return Ok(model);
            }
            return BadRequest(model);
        }
    }
}
