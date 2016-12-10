using ShoppingCartMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Contexts
{
    public class ShoppingCartDBContext: DbContext
    {
        public ShoppingCartDBContext()
            : base("Server=(local);Database=ShoppingCart;Trusted_Connection=True;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ShoppingCartDBContext>(null);

            modelBuilder.Entity<ProductCategoryItem>()
                .HasRequired(p => p.Product);

            modelBuilder.Entity<ProductCategoryItem>()
                .HasRequired(p => p.ProductCategory);

        }

        public virtual DbSet<ProductCategoryItem> ProductCategoryItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}