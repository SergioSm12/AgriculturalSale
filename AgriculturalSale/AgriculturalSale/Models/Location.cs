using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public String Municipality { get; set; }
        public String SideWalk {get; set; }
        public String Details { get; set; }

    }
}
