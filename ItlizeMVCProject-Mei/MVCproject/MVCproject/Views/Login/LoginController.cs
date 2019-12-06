using MVCProject_Service;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCproject.Views.Login
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Submit(UserLogin user) 
        {
            Service sev = new Service();
            if (sev.Userlogin(user.Email, user.Password))
            { return RedirectToAction("Index", "Home"); }
            else { return View("Login"); }
        }
    }
}