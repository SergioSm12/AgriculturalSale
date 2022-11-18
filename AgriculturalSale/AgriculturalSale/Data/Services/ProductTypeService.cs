using AgriculturalSale.Data.Base;
using AgriculturalSale.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Data.Services
{
    public class ProductTypeService : EntityBaseRepository<ProductType>, IProductTypeService
    {
        public ProductTypeService(ApplicationDbContext context) : base(context) { }
    }
}
