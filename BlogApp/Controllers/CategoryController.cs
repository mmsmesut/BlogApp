using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BlogApp.Controllers
{
    public class CategoryController : BaseController 
    {       
        // GET: Category
        public ActionResult Index(int id)
        {            
            return View(id);
        }

        public PartialViewResult ArticleList(int id) {

            var data = Service.CategoryManager.GeyAllArticleByCategory(id);
            return PartialView("ArticleListPartial",data);
        }



        public PartialViewResult KategoriPartial() {
            //var list = Db.Categories.ToList();
            var list = Service.CategoryManager.GetAllCategories();
            return PartialView(list);
        }
    }
}