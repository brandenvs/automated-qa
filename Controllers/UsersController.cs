using AWAIT.DAL;
using Await_DotNet_PrototypeVersion_2.Areas.Identity;
using Await_DotNet_PrototypeVersion_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Await_DotNet_PrototypeVersion_2.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly AwaitDbContext? _context;
        private readonly UserManager<User> _userManager;

        public UsersController(ILogger<UsersController> logger, AwaitDbContext dbContext, UserManager<User> userManager)
        {
            _logger = logger;
            _context = dbContext;
            _userManager = userManager;
        }
        public IActionResult Account()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginTCAS(CreateAccountViewModel model)
        {
            return Content("500");
        }
        [HttpPost]
        public async Task<IActionResult> CreateTCAS(CreateAccountViewModel model)
        {
            var newUser = new User
            {
                UserName = model.UserName,
                Email = model.EmailAddress,
                PhoneNumber = model.PhoneNumber,
                CompanyName = model.CompanyName
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(error => error.Description);
                return Content(errors.First());
            }

            return Content("200");
        }
    }
}
