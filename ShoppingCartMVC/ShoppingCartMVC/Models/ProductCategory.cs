using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
    }
}