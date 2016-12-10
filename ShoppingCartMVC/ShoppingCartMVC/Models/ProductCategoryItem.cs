using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{
    [Table("ProductCategoryItems")]
    public class ProductCategoryItem
    {   
        [Key]
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Product Product { get; set; } 
        
    }
}