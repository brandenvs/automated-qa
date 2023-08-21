using AWAIT.DAL;
using Await_DotNet_PrototypeVersion_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Await_DotNet_PrototypeVersion_2.Controllers
{
    public class LandingController : Controller
    {
        private readonly ILogger<LandingController> _logger;
        private readonly AwaitDbContext? _context;


        public LandingController(ILogger<LandingController> logger, AwaitDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public IActionResult Welcome(int action)
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