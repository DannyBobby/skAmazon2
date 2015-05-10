using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace skAmazon2.Models
{
    public class Checkout
    {
        public string shipaddress { get; set; }

        public string billaddress { get; set; }

        public string ccnumber { get; set; }

        public string ccname { get; set; }

        public int ccexpirationdate { get; set; }
    }
}