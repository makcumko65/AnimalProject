using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Application.Services
{
    public class EmailTemplateService
    {
        private readonly string PathToTemplate;

        public EmailTemplateService(IConfiguration configuration, IHostingEnvironment environment)
        {
         
            PathToTemplate = environment.WebRootPath + "\\" + configuration["EmailTemplate"];
        }

        public string GetTemplateContent()
        {
            return File.ReadAllText(PathToTemplate);
        }
    }
}
