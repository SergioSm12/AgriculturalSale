using AgriculturalSale.Models;
using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Data.ViewModels
{
    public class NewLocationVM
    {
        public int Id { get; set; }

        [Display(Name ="Sidewalk")]
        [Required(ErrorMessage ="Sidewalk is required")]

        public string SideWalk { get; set; }

        [Display(Name = "Details")]
        [Required(ErrorMessage = "Details is required")]
        public string Details { get; set; }

        [Display(Name = "Municipality")]
        [Required(ErrorMessage = "Municipality is required")]
        public int MunicipalityId { get; set; }
    }
}
