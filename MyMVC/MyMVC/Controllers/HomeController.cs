using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    //[RoutePrefix("")]
    public class HomeController : Controller
    {   

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("news/{id}")] //{id?: int} optional, {id: int=1} default
        public ActionResult NewsDetail(int id)
        {
            return View("About");
        }

   
    }
}