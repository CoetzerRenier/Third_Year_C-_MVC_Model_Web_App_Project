using JR_Books_MkII.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JR_Books_MkII.Controllers
{
    public class ProductsController : Controller
    {
        private readonly JrbooksContext _context;

        public ProductsController(JrbooksContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Products.ToListAsync());
        }
    }
}
