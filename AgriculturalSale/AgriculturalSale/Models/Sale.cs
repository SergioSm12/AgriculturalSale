﻿using System.ComponentModel.DataAnnotations;

namespace AgriculturalSale.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

    }
}
