using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using skAmazon2.ViewModels;

namespace skAmazon2.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class CheckOutViewModel
    {
        public ApplicationUser User { get; set; }

        public ShoppingCartViewModel Cart { get; set; }

        public int SelectedPaymentMethod { get; set; }

        public List<PaymentMethod> PaymentMethods { get; set; }

        public int SelectedShippingAddress { get; set; }

        public List<CustomerAddress> ShippingAddresses { get; set; }

        public int SelectedShippingOption { get; set; }

        public List<ShippingOption> ShippingOptions { get; set; }

        public List<OrderLineItem> OrderLineItems { get; set; }
    }
}