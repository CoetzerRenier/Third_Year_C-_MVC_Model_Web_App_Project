using GroovyBooks1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroovyBooks1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

<<<<<<< Updated upstream
        public IActionResult MyPage()
        {
            return View();
        }

=======
>>>>>>> Stashed changes
        [HttpPost]
        public IActionResult Submit()
        {
                      
            return RedirectToAction("Index");
        }
<<<<<<< Updated upstream

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Profiles()
        {
            return View();
        }

        public IActionResult Carts()
        {
            return View();
        }
=======
>>>>>>> Stashed changes
    }

}
