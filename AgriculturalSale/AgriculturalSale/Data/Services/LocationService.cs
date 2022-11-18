using AgriculturalSale.Data.Base;
using AgriculturalSale.Data.ViewModels;
using AgriculturalSale.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Data.Services
{
    public class LocationService : EntityBaseRepository<Location>, ILocationService
    {

        private readonly ApplicationDbContext _context;

        public LocationService(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task AddNewLocationAsync(NewLocationVM data)
        {
            var newLocation = new Location()
            {
                SideWalk = data.SideWalk,
                Details = data.Details,
                MunicipalityId = data.MunicipalityId,
            };
            await _context.Location.AddAsync(newLocation);
            await _context.SaveChangesAsync();
        }

        public Task DeleteLocationAsync(NewLocationVM data)
        {
            throw new NotImplementedException();
        }

        public async Task<Location> GetLocationByIdAsync(int id)
        {
            var LocationDetails = await _context.Location
                .Include(m => m.Municipality)
                .FirstOrDefaultAsync(Municipality => Municipality.Id == id);
            return LocationDetails;
        }

        public async Task<NewLocationDropdownsVM> GetNewLocationDropdownsValues()
        {
            var response = new NewLocationDropdownsVM()
            {
                Municipalities = await _context.Municipality.OrderBy(m => m.name).ToListAsync(),
            };

            return response;
        }

        public async Task UpdateLocationAsync(NewLocationVM data)
        {
            var dbLocation = await _context.Location.FirstOrDefaultAsync(l => l.Id == data.Id);
            if (dbLocation != null)
            {
                dbLocation.SideWalk = data.SideWalk;
                dbLocation.Details = data.Details;
                dbLocation.MunicipalityId = data.MunicipalityId;

                await _context.SaveChangesAsync();
            }
        }
    }
}
