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
    
    public partial class OrderLineItem
    {
        public int LineItemID { get; set; }
        public int OrderId { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    
        public virtual CustomerOrder CustomerOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}
