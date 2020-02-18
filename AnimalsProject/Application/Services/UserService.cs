using Application.DTO;
using Application.Interfaces;
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

        private readonly IConfiguration _configuration;

        private readonly IEmailSender _emailService;

        public UserService(UserManager<IdentityUser> userManager, IConfiguration configuration, IEmailSender emailService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
        }

        public async Task<bool> RegisterAsync(AdminRegisterDto model)
        {
            if (model == null)
                return false;

            var identityUser = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(identityUser, model.Password);

            if (result.Succeeded)
            {
                var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(identityUser);

                var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
                var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

                string url = $"{_configuration["JwtAuth:JwtIssuer"]}/api/auth/confirmemail?userid={identityUser.Id}&token={validEmailToken}";
                
                await _emailService.SendEmailAsync(identityUser.Email, "Confirm your email", $"<h1>Welcome to Auth Demo</h1>" +
                    $"<p>Please confirm your email by <a href='{url}'>Clicking here</a></p>");

                return true;
            }
            return false;
        }

        public async Task<string> LoginAsync(AdminLoginDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
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
