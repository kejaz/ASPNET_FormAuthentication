using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuthentication.Controllers
{
    public class SecurityController : Controller
    {
        public ActionResult Login() 
        {
            return View();
        }
        public ActionResult CheckUser(FormCollection frm)
        {
           // if((frm["txtUserId"].ToString() == "01") &&  (frm["frmPassword"].ToString() =="01"))
            if(Request.Form["txtUserId"] == "01" && Request.Form["txtPassword"] == "01")
            {
                FormsAuthentication.SetAuthCookie(Request.Form["txtUserId"], true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}