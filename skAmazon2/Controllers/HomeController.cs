using skAmazon2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace skAmazon2.Controllers
{
    public class HomeController : Controller
    {
        private skAmazon5Entities db = new skAmazon5Entities();

        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult Browse(List<Product> items)
        {
            return View(items);
        }

        public ActionResult Home()
        {
            var items = from i in db.Products select i;
            
            return View(items.ToList());
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
    }
}