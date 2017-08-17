using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Phoogle.Web.Controllers
{
    public class HomeController : PhoogleControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
