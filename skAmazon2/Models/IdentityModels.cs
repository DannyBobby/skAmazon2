﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace skAmazon2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
   

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=skAmazonEntities")
        {
        }
    }
}