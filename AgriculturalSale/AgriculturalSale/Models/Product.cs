using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriculturalSale.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Features { get; set; }
        public double Price { get; set; }

        //RelationShips
        public List<SaleDetail> saleDetails { get; set; }

        //foreignkey
        public int ProducTypeId { get; set; }
        [ForeignKey("ProducTypeId")]
        public ProductType ProductType { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }



    }
}
