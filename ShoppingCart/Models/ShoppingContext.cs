using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ShoppingContext:DbContext
    {
        public ShoppingContext()
            :base("DbConnection")
        {
        }
        public DbSet<User> UserTable { get; set; }
        public DbSet<Role> RoleTable { get; set; }
        public DbSet<Seller> SellerTable { get; set; }

        public System.Data.Entity.DbSet<ShoppingCart.Models.Product> Products { get; set; }
    }
}