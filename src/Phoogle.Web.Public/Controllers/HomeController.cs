using Microsoft.AspNetCore.Mvc;
using Phoogle.Web.Controllers;

namespace Phoogle.Web.Public.Controllers
{
    public class HomeController : PhoogleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}