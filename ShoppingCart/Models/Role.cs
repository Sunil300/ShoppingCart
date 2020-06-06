using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User Users  { get; set; }
    }
}