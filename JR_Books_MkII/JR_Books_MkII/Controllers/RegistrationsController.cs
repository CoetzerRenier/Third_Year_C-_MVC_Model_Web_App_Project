using Microsoft.AspNetCore.Mvc;

namespace JR_Books_MkII.Controllers
{
    public class RegistrationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
