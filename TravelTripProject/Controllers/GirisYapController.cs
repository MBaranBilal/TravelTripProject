using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Siniflar;


namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        Context context=new Context();
        // GET: GirisYap
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var values=context.Admins.FirstOrDefault(x=>x.Kullanici==admin.Kullanici && x.Sifre==admin.Sifre);
            if (values != null) 
            {
                FormsAuthentication.SetAuthCookie(values.Kullanici,false);
                Session["Kullanici"]=values.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }          
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","GirisYap");
        }

    }
}