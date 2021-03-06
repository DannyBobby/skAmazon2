//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace skAmazon2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            this.OrderLineItems = new HashSet<OrderLineItem>();
        }
    
        public int OrderId { get; set; }
        public string UserID { get; set; }
        public int DeliveryAddressID { get; set; }
        public int PaymentMethodID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int ShippingOptionID { get; set; }
    
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual ShippingOption ShippingOption { get; set; }
        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; }
    }
}
