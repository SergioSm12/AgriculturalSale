using AgriculturalSale.Data.Services;
using AgriculturalSale.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturalSale.Controllers
{
    public class MunicipalityController : Controller
    {
        private readonly IMunicipalityService _service;

        public MunicipalityController(IMunicipalityService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await this._service.GetAllAsync();
            return View(data);
        }

        //Get : Municipality/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("name")] Municipality municipality)
        {
            if (!ModelState.IsValid)
            {
                return View(municipality);
            }
            await _service.AddAsync(municipality);
            return RedirectToAction(nameof(Index));
        }

        //get Municipality por id
        public async Task<IActionResult> Details(int id)
        {
            var municipalityDetails = await _service.GetByIdAsync(id);

            if (municipalityDetails == null) return View("NotFound");
            return View(municipalityDetails);

        }

        //Get for Edit
        public async Task<IActionResult> Edit(int id)
        {
            var municipalityDetails = await _service.GetByIdAsync(id);
            if (municipalityDetails == null) return View("NotFound");
            return View(municipalityDetails);

        }

        //Post for edit 
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, name")] Municipality municipality)
        {
            if (!ModelState.IsValid)
            {

                return View(municipality);

            }
            if (id == municipality.Id)
            {
                await _service.UpdateAsync(id, municipality);
                return RedirectToAction(nameof(Index));

            }
            return View(municipality);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var municipalityDetails = await _service.GetByIdAsync(id);
            if (municipalityDetails == null)
            {
                return View("NotFound");
            }
            return View(municipalityDetails);

        }

        [HttpPost, ActionName("Delete")]

        public async Task<ActionResult> DeleteConfirmed(int id, [Bind("Id,name")] Municipality municipality)
        {
            var municipalityDetails = await _service.GetByIdAsync(id);
            if (municipalityDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
