using AgriculturalSale.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Municipality : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        public List<Location>? locations { get; set; }
    }
}
