using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriculturalSale.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        //Relation Ships 
        public List<SaleDetail> SaleDetails { get; set; }

        public int MethodOfPaymentId { get; set; }
        [ForeignKey("MethodOfPaymentId")]
        public MethodOfPayment MethodOfPayment { get; set; }


    }
}
