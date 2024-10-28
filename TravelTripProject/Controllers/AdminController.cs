using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace TravelTripProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context context = new Context();
        // GET: Admin
        public ActionResult Index(int p = 1)
        {
            var values = context.Blogs.ToList().ToPagedList(p, 5);
            return View(values);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var value = context.Blogs.Find(id);
            context.Blogs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BlogGetir(int id)
        {
            var value = context.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult BlogGetir(Blog blog)
        {
            var value = context.Blogs.Find(blog.ID);
            value.Tarih = blog.Tarih;
            value.Aciklama = blog.Aciklama;
            value.Baslik = blog.Baslik;
            value.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi(int p = 1)
        {
            var yorumlar = context.Yorumlars.ToList().ToPagedList(p, 5);
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var value = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(value);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        [HttpGet]
        public ActionResult YorumGetir(int id)
        {
            var value = context.Yorumlars.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult YorumGetir(Yorumlar yorum)
        {
            var value = context.Yorumlars.Find(yorum.ID);
            value.Yorum = yorum.Yorum;
            value.KullaniciAdi = yorum.KullaniciAdi;
            value.Mail = yorum.Mail;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult Hakkımızda(int id=1)
        {
            var value = context.Hakkimizdas.Find(id);
            return View(value);
        }
    }
}