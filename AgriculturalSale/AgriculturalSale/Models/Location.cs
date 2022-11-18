using AgriculturalSale.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriculturalSale.Models
{
    public class Location: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string SideWalk { get; set; }
        public string Details { get; set; }

        //RelationShips
        public List<Product> Products { get; set; }
        //foreing key 
        public int MunicipalityId { get; set; }
        [ForeignKey("MunicipalityId")]
        public Municipality Municipality { get; set; }
    }
}
