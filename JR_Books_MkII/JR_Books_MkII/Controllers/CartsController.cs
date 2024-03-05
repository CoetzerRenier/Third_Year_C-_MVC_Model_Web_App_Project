using Microsoft.AspNetCore.Mvc;

namespace JR_Books_MkII.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
