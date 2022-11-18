using AgriculturalSale.Data.Base;
using AgriculturalSale.Models;

namespace AgriculturalSale.Data.Services
{
    public class MunicipalityService :EntityBaseRepository<Municipality>, IMunicipalityService
    {
        public MunicipalityService(ApplicationDbContext context) : base(context) { }
    }
}
