using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ShoppingContext db = new ShoppingContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            db.UserTable.ToList();
            db.RoleTable.ToList();
            db.SellerTable.ToList();
            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost, ActionName("Login")]
        //[ValidateAntiForgeryToken]
        //public ActionResult LoginPost(User u)
        //{
            
        //       var v = db.UserTable.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
        //            if (v != null)
        //            {
        //                Session["log"] = v.UserName.ToString();
                        
        //                return RedirectToAction("AfterLogin");
        //            }
           

        //    return View(u);
        //}
        //public ActionResult AfterLogin()
        //{
        //    if (Session["log"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("login");
        //    }
        //}

        //public ActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost,ActionName("Register")]
        //public ActionResult RegisterPost()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = new User();
        //        TryUpdateModel(user);
        //        db.UserTable.Add(user);
        //        db.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}
       
    }
}