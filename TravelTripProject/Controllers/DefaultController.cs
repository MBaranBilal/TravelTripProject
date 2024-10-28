using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context=new Context();
        public ActionResult Index()
        {
            var values=context.Blogs.OrderByDescending(x=>x.ID).Take(5).ToList();
            return View(values);
        }

        public ActionResult About() 
        {
            return View();
        }

        public PartialViewResult partial1()
        {
            var values=context.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult partial2()
        {
            var values=context.Blogs.Where(x=>x.ID==1).ToList();
            return PartialView(values);
        }

        public PartialViewResult partial3() 
        {
            var values = context.Blogs.Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult partial4()
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult partial5()
        {
            var values=context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(values);
        }

    }
}