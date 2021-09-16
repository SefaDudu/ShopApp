using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> getPopularProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category, int page , int pageSize)
        {
            using (var db=new ShopContext())
            {
                var products = db.Products.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a=>a.Category.Name.ToLower() ==category.ToLower()));
                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }
        // bu methodu  producta ait olan categoryleri çekmek için kullanırız.
        public Product GetProductDetails(int id)
        {
            using (var Context = new ShopContext())
            {
                return Context.Products
                    .Where(i => i.Id == id)
                    //include ile birlikte productcategory tablosuna indik
                    .Include(i => i.ProductCategories)
                    //burada producta ait olan category getirdik.
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();

            }
        }

   
    }
}
