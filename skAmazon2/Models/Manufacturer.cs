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
    
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int ManufacturerID { get; set; }
        public string ManufName { get; set; }
        public string ManufStreetAddress { get; set; }
        public string ManufCity { get; set; }
        public string ManufState { get; set; }
        public string ManufZIP { get; set; }
        public string ManufWebsite { get; set; }
        public string ManufPhoneNumber { get; set; }
        public string ManufFaxNumber { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}