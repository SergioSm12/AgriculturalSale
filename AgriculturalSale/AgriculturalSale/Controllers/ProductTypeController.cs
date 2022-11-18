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

        public async Task<IActionResult> Index() {
            var data = await this._service.GetAllAsync();
            return View(data);
        }

        //Get: ProductType/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(" ImageUrl, Name, Details")] ProductType productType)
        {
            if (!ModelState.IsValid) {
                return View(productType);
            }
            await this._service.AddAsync(productType);
            return RedirectToAction(nameof(Index));

        }
        //get  product type 
        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        { 
            var productTypeDetails = await this._service.GetByIdAsync(id);

            if (productTypeDetails == null) return View("NotFound");
            return View(productTypeDetails);
           
        }

        //get productType/Details

        public async Task<IActionResult> Edit(int id) {
        
            var productTypeDetails = await this._service.GetByIdAsync(id);
            if (productTypeDetails == null) return View("NotFound");
            return View(productTypeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageUrl,Name,Details")] ProductType productType) {
            if (!ModelState.IsValid) {
                return View(productType);
            }
            if (id == productType.Id)
            {
               await this._service.UpdateAsync(id, productType);
                return RedirectToAction(nameof(Index));  
            }
            return View(productType);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var productTypeDetails = await this._service.GetByIdAsync(id);
            if (productTypeDetails == null) {
                return View("NotFound");
            }
            return View(productTypeDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id, [Bind("Id, ImageUrl, Name, Details")] ProductType productType)
        {
            var productTypeDetails = await this._service.GetByIdAsync(id);
            if (productTypeDetails == null) return View("NotFound");

            await this._service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
