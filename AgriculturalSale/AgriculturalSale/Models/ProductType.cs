using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public string Features { get; set; }
        public string ImageUrl { get; set; }    
        //RelationShips
        public List<Product> Products { get; set; }
    }
}
