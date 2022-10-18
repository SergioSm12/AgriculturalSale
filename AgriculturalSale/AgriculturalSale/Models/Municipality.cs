using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Municipality
    {
        [Key]
        public int Id{ get; set; }
        public string name { get; set; }
        public List<Location> locations { get; set; }
    }
}
