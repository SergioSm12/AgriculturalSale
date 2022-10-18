using AgriculturalSale.Data.Services;
using AgriculturalSale.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturalSale.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _service;

        public ProductTypeController(IProductTypeService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Details,ImageUrl")] ProductType productType)
        {
            if (!ModelState.IsValid)
            {
                return View(productType);
            }
            await _service.AddAsync(productType);
            return RedirectToAction(nameof(Index));
        }
    }
}
