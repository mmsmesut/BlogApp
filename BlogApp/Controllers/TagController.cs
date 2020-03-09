using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class TagController : Controller
    {

        BlogModelDbContext db = new BlogModelDbContext();

        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult TagPartialView() {
            return PartialView(db.Tags.ToList());
        }

    }
}