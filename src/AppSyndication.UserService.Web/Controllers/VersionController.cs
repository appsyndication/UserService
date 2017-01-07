using System.Reflection;
using AppSyndication.UserService.Model;
using AppSyndication.UserService.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppSyndication.UserService.Web.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    public class VersionController : Controller
    {
        // GET version/server
        [HttpGet]
        public VersionModel Get()
        {
            var attribute = typeof(VersionController).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var modelVersion = new ModelVersion();

            return new VersionModel { ModelVersion = modelVersion.Version, ServerVersion = attribute?.InformationalVersion };
        }
    }
}
