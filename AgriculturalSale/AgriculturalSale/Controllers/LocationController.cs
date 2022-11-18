using AgriculturalSale.Data.Services;
using AgriculturalSale.Data.ViewModels;
using AgriculturalSale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace AgriculturalSale.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {

            this._service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await this._service.GetAllAsync(m => m.Municipality);
            return View(data);
        }

        //get create 
        public async Task<IActionResult> Create()
        {
            var locationDropDownsData = await this._service.GetNewLocationDropdownsValues();
            ViewBag.Municipalities = new SelectList(
                   locationDropDownsData.Municipalities, "Id", "name"
                );
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewLocationVM location)
        {
            if (!ModelState.IsValid)
            {
                var locationDropDownsdata = await this._service.GetNewLocationDropdownsValues();
                ViewBag.Municipalities = new SelectList(locationDropDownsdata.Municipalities, "Id", "name");
                return View(location);
            }

            await _service.AddNewLocationAsync(location);
            return RedirectToAction(nameof(Index));

        }

        //get details
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetLocationByIdAsync(id);
            return View(data);

        }

        public async Task<IActionResult> Edit(int id)
        {
            var locationDetails = await this._service.GetLocationByIdAsync(id);
            if (locationDetails == null) return View("NotFound");


            var response = new NewLocationVM()
            {
                Id = locationDetails.Id,
                SideWalk = locationDetails.SideWalk,
                Details = locationDetails.Details,
                MunicipalityId = locationDetails.MunicipalityId,
            };

            var locationDropDownsdata = await this._service.GetNewLocationDropdownsValues();
            ViewBag.Municipalities = new SelectList(locationDropDownsdata.Municipalities, "Id", "name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewLocationVM location)
        {
            if (id != location.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var locationDropDownsData = await this._service.GetNewLocationDropdownsValues();
                ViewBag.Municipalities = new SelectList(locationDropDownsData.Municipalities, "Id", "name");

                return View(location);
            }

            await _service.UpdateLocationAsync(location);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var locationDetails = await _service.GetLocationByIdAsync(id);
            if (locationDetails == null)
            {
                return View("NotFound");
            }
            return View(locationDetails);
        }

    }
}
