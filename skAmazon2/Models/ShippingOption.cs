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
    
    public partial class ShippingOption
    {
        public ShippingOption()
        {
            this.OrderLineItems = new HashSet<OrderLineItem>();
        }
    
        public int ShippingOptionId { get; set; }
        public string Description { get; set; }
        public decimal ShippingPrice { get; set; }
    
        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; }
    }
}
