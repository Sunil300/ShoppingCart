using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShoppingCart.Controllers
{
    public class RegisterController : Controller
    {
        ShoppingContext db = new ShoppingContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost, ActionName("Login")]
        [ValidateAntiForgeryToken]
        public ActionResult LoginPost(User u)
        {

            var v = db.UserTable.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
            
            if (v != null)
            {
                Session["log"] = v.UserName.ToString();
                FormsAuthentication.SetAuthCookie(u.UserName,false);
                return RedirectToAction("Index","Products");
            }

            ModelState.AddModelError("", "Invalid UserName or Password");
            return View();
        }


        public ActionResult AfterLogin()
        {
            if (Session["log"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost, ActionName("Register")]
        public ActionResult RegisterPost()
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                TryUpdateModel(user);
                db.UserTable.Add(user);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}