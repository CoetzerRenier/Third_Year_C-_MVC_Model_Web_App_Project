using Microsoft.AspNetCore.Mvc;

namespace GroovyBooks1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
