﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class skAmazon5Entities : DbContext
    {
        public skAmazon5Entities()
            : base("name=skAmazon5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<OrderLineItem> OrderLineItems { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SavedItem> SavedItems { get; set; }
        public virtual DbSet<ShippingOption> ShippingOptions { get; set; }
        public virtual DbSet<skAmazonUser> skAmazonUsers { get; set; }
        public virtual DbSet<skAmazonUserPassword> skAmazonUserPasswords { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
    }
}
