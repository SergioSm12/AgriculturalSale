using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Details is required")]
        public string Details { get; set; }
        [Required(ErrorMessage ="Image is Required")]
        public string ImageUrl { get; set; }    
        //RelationShips
        public List<Product>? Products { get; set; }
    }
}
