using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

        Product GetPRoductDetails(int id);
        List<Product> GetPopularProducts();
        //kategori ismine göre o isimde olan kategori içindeki ürünleri listeler
        List<Product> GetProductsByCategory( string category ,int page, int pageSize);
        Product GetById(int id);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
