using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfOrderDal:EfCoreGenericRepository<Order,ShopContext>,IOrderDal
    {
    }
}
