using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        IEnumerable<Product> getPopularProducts();
        List<Product> GetProductsByCategory(string category, int page , int pageSize);
        Product GetProductDetails(int id);

    }
}
