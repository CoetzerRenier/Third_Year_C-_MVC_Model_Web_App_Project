using Microsoft.AspNetCore.Mvc;

namespace GroovyBooks1.Controllers
{
    public class ProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
