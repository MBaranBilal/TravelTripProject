using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context context=new Context();
        BlogYorum by = new BlogYorum();
        // GET: Blog
        public ActionResult Index()
        {
            //var values=context.Blogs.ToList();
            by.Deger1=context.Blogs.ToList();
            by.Deger3=context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            by.Deger2 = context.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blog = context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1=context.Blogs.Where(x=>x.ID==id).ToList();
            by.Deger2 = context.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorum)
        {
            context.Yorumlars.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }
    }
}