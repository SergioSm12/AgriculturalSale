using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class SaleDetail
    {
        [Key]
        public int Id { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }

    }
}
