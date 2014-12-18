using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Caching;
using Microsoft.Ajax.Utilities;

namespace CachingDemo.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            const string key = "books";
            var books = CacheEngine.Get<List<Book>>(key); 

            if (books == null)
            {
                books = BookData.GetBooks();
                CacheEngine.Add(key, books);
            }

            ViewBag.books = books;
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
    }
}