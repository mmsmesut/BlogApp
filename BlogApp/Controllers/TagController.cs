
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class TagController : BaseController
    {

        //BlogModelDbContext db = new BlogModelDbContext();

        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TagPartialView() {
            //return PartialView(Db.Tags.ToList());
            return PartialView(Service.TagManager.GetAllTags());
        }

    }
}