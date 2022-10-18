using AgriculturalSale.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Data.Services
{
    public class ProductTypeService :IProductTypeService
    {
        private readonly ApplicationDbContext _context;

        public ProductTypeService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task AddAsync(ProductType productType)
        {
            await _context.ProductType.AddAsync(productType);
            await _context.SaveChangesAsync();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductType>> GetAllAsync()
        {
            var result = await _context.ProductType.ToListAsync();
            return result;
        }

        public Task<ProductType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductType productType)
        {
            throw new NotImplementedException();
        }
    }
}
