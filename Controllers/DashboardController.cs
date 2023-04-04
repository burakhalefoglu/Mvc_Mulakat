using Microsoft.AspNetCore.Mvc;

namespace Mvc_Mulakat.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("dashboard");
        }
    }
}
