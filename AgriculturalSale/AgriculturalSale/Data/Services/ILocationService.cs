using AgriculturalSale.Data.Base;
using AgriculturalSale.Data.ViewModels;
using AgriculturalSale.Models;

namespace AgriculturalSale.Data.Services
{
    public interface ILocationService:IEntityBaseRepository<Location>
    {
        Task<Location> GetLocationByIdAsync(int id );
        Task<NewLocationDropdownsVM> GetNewLocationDropdownsValues();
        Task AddNewLocationAsync(NewLocationVM data);
        Task UpdateLocationAsync(NewLocationVM data);
        Task DeleteLocationAsync(NewLocationVM data);


    }
}
