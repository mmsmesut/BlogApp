﻿using BlogApp.Data.Manager;
using BlogApp.Data.Models;
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
            List<Article> data = Service.ArticleManager.GetArticles();            
            return View(data);
        }

        //public ActionResult GetArticles() {
        //    List<Article> data = Service.ArticleManager.GetArticles();
        //    return View("ArticleListPartial", data);
        //}

        public PartialViewResult PopularArticlesPartial()
        {
            //var lastFiveArticles = Db.Articles.OrderByDescending(x => x.CreateDate).Take(5);
            var lastFiveArticles = Service.ArticleManager.GetPopularArticles();
            return PartialView(lastFiveArticles);
        }


        public List<Article> GetArticlesByCategory(ArticleFilter filter = null)
        {
            var data = Service.ArticleManager.GetArticlesByCategory(filter);
            return data;
        }

        
    }
}