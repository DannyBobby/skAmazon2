using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using skAmazon2.Models;

namespace skAmazon2.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        // We should check to see if they have anything in their cart

        skAmazonEntities storeDB = new skAmazonEntities();
        const string PromoCode = "FREE";

        //
        // GET: /Checkout/
        public ActionResult AddressAndPayment()
        {
            // Set up our ViewModel
            CheckOutViewModel viewModel = new CheckOutViewModel();            

            string userID = GetUserID(User.Identity.Name);

            // Get the user info
            
            viewModel.User = (from u in storeDB.ApplicationUsers
                              where u.Id == userID
                              select u).FirstOrDefault();

            // Get payment info
            viewModel.PaymentMethods = (from p in storeDB.PaymentMethods
                                        where p.UserID == userID
                                        select p).ToList();

            // Get payment info
            viewModel.ShippingAddresses = (from a in storeDB.CustomerAddresses
                                           where a.UserId == userID
                                           select a).ToList();

            viewModel.ShippingOptions = (from o in storeDB.ShippingOptions
                                         
                                         select o).ToList();

            // Get the user's Shopping Cart info
            //var cart = ShoppingCart.GetCart(this.HttpContext);
            //viewModel.Cart.CartItems = cart.GetCartItems();
            //viewModel.Cart.CartTotal = cart.GetTotal();            

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values, CheckOutViewModel model)
        {
            var order = new CustomerOrder();
            TryUpdateModel(order);

            try
            {            
                    // Enter order information from form submission
                    order.UserID = GetUserID(User.Identity.Name);
                    order.DeliveryAddressID = 5; //model.SelectedShippingAddress;
                    order.PaymentMethodID = 3; //model.SelectedPaymentMethod; //3
                    order.OrderDate = DateTime.Now;
                    order.ShippingOptionID = 2; //model.SelectedShippingOption; //2   

                    //Save Order
                    storeDB.CustomerOrders.Add(order);
                    storeDB.SaveChanges();

                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.OrderId });
                
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            string userID = GetUserID(User.Identity.Name);

            // Validate customer owns this order
            bool isValid = storeDB.CustomerOrders.Any(
                o => o.OrderId == id &&
                o.UserID == userID);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }

        public string GetUserID(string username)
        {
            var user = (from u in storeDB.ApplicationUsers
                        where u.UserName == username
                        select u).FirstOrDefault();

            return user.Id;
        }
	}
}