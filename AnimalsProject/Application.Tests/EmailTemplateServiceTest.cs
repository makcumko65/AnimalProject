using Application.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
namespace Application.Tests
{
    [TestFixture]
    public class EmailTemplateServiceTest
    {
        [Test]
        public void GetTemlateContent_ReturnsHtml_AsString()
        {
            var hostingMock = new Mock<IHostingEnvironment>();

            var configurationMock = new Mock<IConfiguration>();

            hostingMock.Setup(host => host.WebRootPath).Returns(@"C:\Users\vynar\source\repos\InternalProject\AnimalProject\AnimalsProject\Api\wwwroot");

            configurationMock.Setup(config => config["EmailTemplate"]).Returns("EmailConfirmationTemplate.html");

            var emailTemplateService = new EmailTemplateService(configurationMock.Object, hostingMock.Object);

            var content = emailTemplateService.GetTemplateContent();
            var expected = "<h1>Welcome to Pet Adoption Service!</h1>\r\n<p>Please confirm your email by <a href='{0}'>Clicking here</a></p>";

            Assert.IsNotNull(content);
            Assert.AreEqual(content, expected);
        }
    }
}
