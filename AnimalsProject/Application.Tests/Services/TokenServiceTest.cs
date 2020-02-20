using Application.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Tests.Services
{
    [TestFixture]
    public class TokenServiceTest
    {
        [Test]
        public async Task GenereteTokenAsync_DoesNotReturnNull_OrEmptyString()
        {
            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(config => config["JwtAuth:JwtIssuer"]).Returns("https://localhost:5001");
            configurationMock.Setup(config => config["JwtAuth:ExpireDays"]).Returns("30");
            configurationMock.Setup(config => config["JwtAuth:JwtKey"]).Returns("SoME_RAnD0M_KEY_DO_N0T_SHarE");

            var user = new IdentityUser()
            {
                Id = "1",
                Email = "pets.adoption.service@gmail.com",
                NormalizedEmail = "PETS.ADOPTION.SERVICE@GMAIL.COM"
            };

            var roles = new List<string>() { "SuperUser" };

            var fakeUserManager = new Mock<FakeUserManager>();
            fakeUserManager.Setup(manager => manager.GetRolesAsync(user)).ReturnsAsync(roles);

            var tokenService = new TokenService(configurationMock.Object, fakeUserManager.Object);
            var generatedToken = await tokenService.GenerateJwtToken(user);

            Assert.IsNotNull(generatedToken);
            Assert.AreNotEqual(generatedToken, "");
        }
    }
}
