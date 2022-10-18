using AgriculturalSale.Models;

namespace AgriculturalSale.Data.Services
{
    public interface IProductTypeService
    {
        Task<IEnumerable<ProductType>> GetAllAsync();
        Task<ProductType> GetByIdAsync(int id);
        Task AddAsync(ProductType productType);
        Task UpdateAsync(ProductType productType);
        void DeleteAsync(int id);


    }
}
