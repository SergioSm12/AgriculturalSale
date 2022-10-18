using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class MethodOfPayment
    {
        [Key]
        public int Id { get; set; }
        public string  name { get; set; }
        public List<Sale> sales { get; set; }
    }
}
