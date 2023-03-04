using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Playground.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Products.ToList();

            return View(data);
        }
    }
}
