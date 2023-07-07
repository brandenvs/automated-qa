using Microsoft.AspNetCore.Mvc;

namespace Await_DotNet_PrototypeVersion_2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
