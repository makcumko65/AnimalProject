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
    public class UserService: IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly IHostingEnvironment _environment;

        private readonly IConfiguration _configuration;

        private readonly IEmailSender _emailService;

        public UserService(UserManager<IdentityUser> userManager, 
            IConfiguration configuration, 
            IEmailSender emailService, 
            IHostingEnvironment envorinment)
        {
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
            _environment = envorinment;
        }

        public async Task<bool> RegisterAsync(AdminDto model)
        {
            if (model == null)
                return false;

            var admin = await _userManager.FindByEmailAsync(model.Email);

            if(admin == null)
            {
                return false;
            }

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
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null || !user.EmailConfirmed)
                return null;

            
            var result = await _userManager.CheckPasswordAsync(user, model.Password);

            if (!result)
                return null;

            var tokenService = new TokenService(_configuration, _userManager);

            return await tokenService.GenerateJwtToken(model.Email, user);
            
        }

        public async Task<bool> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return false;

            var decodedToken = WebEncoders.Base64UrlDecode(token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManager.ConfirmEmailAsync(user, normalToken);

            return result.Succeeded;
        }
    }
}
