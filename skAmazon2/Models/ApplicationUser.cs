//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNet.Identity.EntityFramework;

namespace skAmazon2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationUser : IdentityUser
    {
        public override string Id { get; set; }
        public override string UserName { get; set; }
        public override string PasswordHash { get; set; }
        public override string SecurityStamp { get; set; }
        public string Discriminator { get; set; }
    }
}
