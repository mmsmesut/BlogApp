using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {

        BlogModelDbContext db = new BlogModelDbContext();


        // GET: Category
        public ActionResult Index()
        {
            return View();

            //
        }

        public PartialViewResult KategoriPartial() {
            return PartialView(db.Categories.ToList());
        }
    }
}