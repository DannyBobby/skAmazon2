using skAmazon2.Models;
using skAmazon2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace skAmazon2.Controllers
{
    public class HomeController : Controller
    {
        private skAmazonEntities db = new skAmazonEntities();

        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult Order()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
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