
using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class TagController : BaseController
    {
        
        // GET: Tag
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult ArticleList(int id) {
            List<Article> data = Service.TagManager.GeyAllArticleByTag(id);
            return PartialView("ArticleListPartial", data);
        }

        public PartialViewResult TagPartialView() {
            //return PartialView(Db.Tags.ToList());
            return PartialView(Service.TagManager.GetAllTags());
        }

    }
}