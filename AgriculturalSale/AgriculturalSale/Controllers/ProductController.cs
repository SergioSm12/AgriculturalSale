using AgriculturalSale.Data;
using AgriculturalSale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext contex)
        {
            this._context = contex;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Product.Include(pt => pt.ProductType).OrderBy(pt => pt.Name).ToListAsync();
            return View(data);
        }
    }
}
