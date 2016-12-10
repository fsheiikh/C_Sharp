using ShoppingCartMVC.Contexts;
using ShoppingCartMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {   

            return View();
        }

        [HttpGet]
        [Route("products")]
        public ActionResult Products()
        {
            var db = new ShoppingCartDBContext();

            var products = db.ProductCategoryItems.ToList();
            return View(products);
        }
    }
}