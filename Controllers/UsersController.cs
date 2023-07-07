using Microsoft.AspNetCore.Mvc;

namespace Await_DotNet_PrototypeVersion_2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
