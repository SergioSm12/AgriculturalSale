using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Data.ViewModels
{
    public class NewProductVM
    {

        public int Id { get; set; }
        [Display(Name="Product Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageUrl { get; set; }
        [Display(Name = "Details")]
        [Required(ErrorMessage = "Details is required")]
        public string Details { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Stock is required")]
        public string stock { get; set; }

        [Display(Name = "Select Product Type")]
        [Required(ErrorMessage = "product type is required")]
        public int ProductTypeId { get; set; }

        [Display(Name = "Select Location")]
        [Required(ErrorMessage = "Location is required")]
        public int LocationId { get; set; }
        

    }
}
