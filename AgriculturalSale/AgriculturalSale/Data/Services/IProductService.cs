using AgriculturalSale.Data.Base;
using AgriculturalSale.Data.ViewModels;
using AgriculturalSale.Models;

namespace AgriculturalSale.Data.Services
{
    public interface IProductService :IEntityBaseRepository<Product>
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<NewProductDropdownsVM> GetNewProductDropdownsValues();
        Task AddNewProductAsync(NewProductVM data);
        Task UpdateProductAsync(NewProductVM data);
        Task DeleteProductAsync(NewProductVM data);

    }
}
