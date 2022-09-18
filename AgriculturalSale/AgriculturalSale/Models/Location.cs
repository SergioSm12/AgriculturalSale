using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string  Municipality { get; set; }
        public string SideWalk {get; set; }
        public string Details { get; set; }

        //RelationShips
        public List<Product> Products { get; set; }

    }
}
