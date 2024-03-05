using Microsoft.AspNetCore.Mvc;

namespace JR_Books_MkII.Controllers
{
    public class ProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
