using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class RoleUserMap
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public  string RoleName { get; set; }
        public int MyProperty { get; set; }
    }
}