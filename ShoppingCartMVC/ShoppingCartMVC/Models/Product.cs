using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{   
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

    }
}