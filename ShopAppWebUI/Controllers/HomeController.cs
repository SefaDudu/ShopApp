using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopAppWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppWebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(new ProductListModel()
            {

                Products = _productService.GetAll()
            }) ;
        }
    }
}
