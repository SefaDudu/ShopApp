using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class Product
    {
        //bir ürünün birden fazla kategorisi olabilir.
        //birden çok ilişki için
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
