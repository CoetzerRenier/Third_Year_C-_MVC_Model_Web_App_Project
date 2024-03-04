using Microsoft.AspNetCore.Mvc;

namespace GroovyBooks1.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
