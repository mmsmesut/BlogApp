using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {

        BlogModelDbContext db = new BlogModelDbContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Makala listeleme için bir partial view oluştururuz , ve daha sonra bu partial view'i index içine gömeceğiz
        //ArticleListPartial'i Partialview yapmamızın amacı b irden çok yerden kullamabiliriz,çağırabiliriz 
        //MakaleListele ,Partialview'i

        //public PartialViewResult ArticleListPartial()
        //{
        //    return PartialView(db.Articles.ToList());
        //}


        public ActionResult Articlelist()
        {
            var aList = db.Articles.ToList();
            return View("MakaleListelePartial", "Shared", aList);

        }


        public PartialViewResult PopularArticlesPartial() {
            var lastFiveArticles = db.Articles.OrderByDescending(x => x.CreateDate).Take(5);
            return PartialView(lastFiveArticles);
        }
    }
}