using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class Category
    {
        //birden çok olan kısmın çok tarafına
        //public List<Product> products { get; set; }
        //bir kategorinin birden fazla ürünü olabilir.

        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
