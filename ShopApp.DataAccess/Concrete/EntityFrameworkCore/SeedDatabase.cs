using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
   public static class SeedDatabase
    {

        public static void Seed()
        {
            var contex = new ShopContext();
            if (contex.Database.GetPendingMigrations().Count()==0)
            {
                if (contex.Categories.Count()==0)
                {
                    contex.Categories.AddRange(Categories);
                    contex.AddRange(ProductCategories);
                }
                if (contex.Products.Count() == 0)
                {
                    contex.Products.AddRange(Products);
                }
                contex.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
        };
      
        private static Product[] Products =
     {
            new Product(){Name="Samsung S5",
                Price=2000,
                ImageUrl="1.jpg",
                 Description="<p>Güzel Telefon </p>"
            
            },
             new Product(){Name="Samsung S6",
                Price=3000,
                ImageUrl="1.jpg",
                Description="<p>Güzel Telefon </p>"

            },
              new Product(){Name="Samsung S7",
                Price=3000,
                ImageUrl="1.jpg",
                Description="<p>Güzel Telefon </p>"

            },
               new Product(){Name="Samsung S8",
                Price=3000,
                ImageUrl="1.jpg",
                Description="<p>Güzel Telefon </p>"

            },
                new Product(){Name="Samsung S9",
                Price=3000,
                ImageUrl="1.jpg",
                Description="<p>Güzel Telefon </p>"

            },
        };
        private static ProductCategory[] ProductCategories =
      {
            new ProductCategory(){ Product=Products[0] ,Category=Categories[0]},
            new ProductCategory(){ Product=Products[0] ,Category=Categories[2]},
            new ProductCategory(){ Product=Products[1] ,Category=Categories[0]},
            new ProductCategory(){ Product=Products[1] ,Category=Categories[1]},
            new ProductCategory(){ Product=Products[2] ,Category=Categories[2]},
        };
    }
}
