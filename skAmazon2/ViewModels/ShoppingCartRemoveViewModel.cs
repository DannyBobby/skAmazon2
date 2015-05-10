using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace skAmazon2.ViewModels
{

    // allows you to remove items from the cart, and updates the view
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
    }
}