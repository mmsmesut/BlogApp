using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BlogApp.Controllers
{
    public class HomeController : BaseController
    {        
        // GET: Home
        public ActionResult Index()
        {
            //var data = Db.Database.SqlQuery<Category>("Select * from Category").ToList();
            //var count = data.Count;
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
            //var aList = Db.Articles.ToList();

            var catList = Service.CategoryManager.GetAllCategories();

            return View("MakaleListelePartial", "Shared", catList);

        }


        public PartialViewResult PopularArticlesPartial() {
            //var lastFiveArticles = Db.Articles.OrderByDescending(x => x.CreateDate).Take(5);
            var lastFiveArticles = Service.ArticleManager.GetPopularArticles();
            return PartialView(lastFiveArticles);
        }
    }
}