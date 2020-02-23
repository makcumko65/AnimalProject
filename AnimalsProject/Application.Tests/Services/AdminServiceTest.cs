using Api;
using Application.DTO;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Identity;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Services
{
    [TestFixture]
    public class AdminServiceTest
    {

        private IMainAdminService _mainAdminService;
         
        private List<IdentityUser> identityUsers;
        public AdminServiceTest()
        {

            identityUsers = new List<IdentityUser>
            {
                new IdentityUser
                {
                    UserName = "test@test.it",
                    Id = Guid.NewGuid().ToString(),
                    Email = "test@test.it"
                },
                new IdentityUser
                {
                    UserName = "test2@test.it",
                    Id = Guid.NewGuid().ToString(),
                    Email = "test2@test.it"
                }
            };
        }

        [Test]
        public async Task AddEmailOfNewAdmin_ReturnTrue()
        {
            //Arrange
            var model = new AdminEmailDto
            {
                Email = "test3@test.it"
            };
            var fakeUserManager = new Mock<FakeUserManager>();
            fakeUserManager.Setup(x => x.CreateAsync(It.IsAny<IdentityUser>()))
                           .ReturnsAsync(IdentityResult.Success);

            _mainAdminService = new MainAdminService(fakeUserManager.Object);

            //Act
            var result = await _mainAdminService.AddEmailOfNewAdminAsync(model);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task AddExistingEmail_ReturnFalse()
        {
            //Arrange
            var model = new AdminEmailDto
            {
                Email = "test@test.it"
            };
            var fakeUserManager = new Mock<FakeUserManager>();          
            fakeUserManager.Setup(x => x.CreateAsync(It.IsAny<IdentityUser>()))
                           .ReturnsAsync(IdentityResult.Failed());

            _mainAdminService = new MainAdminService(fakeUserManager.Object);

            //Act
            var result = await _mainAdminService.AddEmailOfNewAdminAsync(model);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
