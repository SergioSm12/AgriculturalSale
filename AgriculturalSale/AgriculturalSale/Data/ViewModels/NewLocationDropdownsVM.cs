using AgriculturalSale.Models;

namespace AgriculturalSale.Data.ViewModels
{
    public class NewLocationDropdownsVM
    {
        public List<Municipality> Municipalities { get; set; }

        public NewLocationDropdownsVM()
        {
            Municipalities = new List<Municipality>();
        }
    }
}
