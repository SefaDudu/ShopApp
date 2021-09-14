using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //dependency injection ile IProduct Service çağrıldığında IproductManager eklenmiş olacak.
        private IProductService _productService;
        public HomeController(IProductService productService )
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}
