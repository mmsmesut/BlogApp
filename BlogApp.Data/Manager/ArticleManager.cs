using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Manager
{
    public class ArticleManager : BaseManager
    {


        public ArticleManager(BlogModelDbContext ctx = null) : base(ctx) {

        }



        public List<Article> GetArticles()
        {        
            return _Context.Database.SqlQuery<Article>("Select * from Article ").ToList();
        }


        public List<Article> GetPopularArticles() {
            //return _Context.Articles.OrderByDescending(x => x.CreateDate).Take(4).ToList();

            return _Context.Database.SqlQuery<Article>("Select * from Article").ToList();
        }

        public List<Article> GetArticlesByCategory(ArticleFilter filter=null) {

            string sqlQuery = @"
                               Declare @CategoryId INT  = {0}
                               Select * from Article 
                               Where CategoryId = @CategoryId";

            return _Context.Database.SqlQuery<Article>(sqlQuery, filter.Category.CategoriId).ToList();   
        }


        public List<Article> GetArticlesByAuthor(ArticleFilter filter = null)
        {

            string sqlQuery = @"
                               Declare @AuthorId INT  = {0}
                               Select * from Article 
                               Where CategoryId = @AuthorId";

            return _Context.Database.SqlQuery<Article>(sqlQuery, filter.UserId).ToList();
        }

    }
}
