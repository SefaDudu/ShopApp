using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopAppWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppWebUI.Controllers
{
    public class ShopController : Controller
    {
        IProductService _productService;
        public ShopController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Product product = _productService.GetPRoductDetails((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailsModel
            {
                Product = product,
                Categories= product.ProductCategories.Select(i=>i.Category).ToList()

            }); 
        }
        //  /products/telefon?page=1
        public IActionResult List(string category ,int page=1)
        {
            const int pageSize = 3;
            return View(new ProductListModel() { 
            Products= _productService.GetProductsByCategory(category, page, pageSize)
            });
        }
    }
}
