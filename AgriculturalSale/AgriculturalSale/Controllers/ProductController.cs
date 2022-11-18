using AgriculturalSale.Data;
using AgriculturalSale.Data.Services;
using AgriculturalSale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(pt=> pt.ProductType, l=> l.Location);
            return View(data);
        }
    }
}
