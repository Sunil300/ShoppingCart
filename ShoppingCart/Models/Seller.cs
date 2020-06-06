using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string SellerName { get; set; }

    }
}