using AgriculturalSale.Data.Base;
using AgriculturalSale.Data.ViewModels;
using AgriculturalSale.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Data.Services
{
    public class ProductService : EntityBaseRepository<Product>, IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                Name= data.Name,
                ImageUrl= data.ImageUrl,
                Details=data.Details,
                Price= data.Price,
                stock=data.stock,
                ProducTypeId=data.ProductTypeId,
                LocationId=data.LocationId

            };
            await _context.Product.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }

        public Task DeleteProductAsync(NewProductVM data)
        {
            throw new NotImplementedException();
        }

        public async Task<NewProductDropdownsVM> GetNewProductDropdownsValues()
        {
            var response = new NewProductDropdownsVM()
            {
                ProductTypes = await _context.ProductType.OrderBy(pt=> pt.Name).ToListAsync(),
                Locations =await _context.Location.OrderBy(l=>l.SideWalk).ToListAsync()
            };
            return response;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var productDetails = await _context.Product
                .Include(pt => pt.ProductType)
                .Include(l => l.Location)
                .FirstOrDefaultAsync(p=>p.Id == id);

            return productDetails;
        }

        public Task UpdateProductAsync(NewProductVM data)
        {
            throw new NotImplementedException();
        }
    }

}
