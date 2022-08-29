using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Features { get; set; }

    }
}
