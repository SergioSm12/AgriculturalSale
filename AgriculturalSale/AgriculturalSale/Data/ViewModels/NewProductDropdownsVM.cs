using AgriculturalSale.Models;

namespace AgriculturalSale.Data.ViewModels
{
    public class NewProductDropdownsVM
    {
        public List<ProductType> ProductTypes { get; set; }
        public List<Location> Locations { get; set; }
        public List<SaleDetail> SaleDetails { get; set; }

        public NewProductDropdownsVM()
        {
            ProductTypes = new List<ProductType>();
            Locations = new List<Location>();
        }

    }
}
