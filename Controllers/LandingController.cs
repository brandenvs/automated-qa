using Await_DotNet_PrototypeVersion_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Await_DotNet_PrototypeVersion_2.Controllers
{
    public class LandingController : Controller
    {
        private readonly ILogger<LandingController> _logger;

        public LandingController(ILogger<LandingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}