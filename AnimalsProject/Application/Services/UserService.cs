using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly IHostingEnvironment _environment;

        private readonly IConfiguration _configuration;

        private readonly IEmailSender _emailService;

        public UserService(UserManager<IdentityUser> userManager,
                           SignInManager<IdentityUser> signInManager,
                           IConfiguration configuration,
                           IEmailSender emailService,
                           IHostingEnvironment envorinment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _emailService = emailService;
            _environment = envorinment;
        }

        public async Task<bool> RegisterAsync(AdminDto model)
        {
            if (model == null)
                return false;

            var normalizedEmail = model.Email.ToUpper();
            var admin = await _userManager.FindByEmailAsync(normalizedEmail);

            if (admin == null)
            {
                return false;
            }

            admin.UserName = model.Email;

            var result = await _userManager.AddPasswordAsync(admin, model.Password);

            if (result.Succeeded)
            {
                var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(admin);

                var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
                var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

                string url = $"{_configuration["JwtAuth:JwtIssuer"]}/api/account/confirmemail?userid={admin.Id}&token={validEmailToken}";

                var emailTemplateService = new EmailTemplateService(_configuration, _environment);

                var formatedTemplateContent = string.Format(emailTemplateService.GetTemplateContent(), url);

                await _emailService.SendEmailAsync(admin.Email, "Confirmation email", formatedTemplateContent);

                return true;
            }
            return false;
        }

        public async Task<string> LoginAsync(AdminDto model)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (signInResult.Succeeded)
            {
                var normalizedEmail = model.Email.ToUpper();

                var user = await _userManager.FindByEmailAsync(normalizedEmail);

                var tokenService = new TokenService(_configuration, _userManager);

                return await tokenService.GenerateJwtToken(model.Email, user);
            }
            return null;

        }

        public async Task<bool> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return false;

            if (!await AddUserToDefaultRole(user))
            {
                return false;
            }

            var decodedToken = WebEncoders.Base64UrlDecode(token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManager.ConfirmEmailAsync(user, normalToken);

            return result.Succeeded;
        }

        private async Task<bool> AddUserToDefaultRole(IdentityUser user)
        {
            var usersInRoles = await _userManager.GetUsersInRoleAsync("SuperAdmin");

            IdentityResult addedToRole;

            if (usersInRoles == null || usersInRoles.Count == 0)
            {
                addedToRole = await _userManager.AddToRoleAsync(user, "SuperAdmin");
            }
            else
            {
                addedToRole = await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (addedToRole.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
