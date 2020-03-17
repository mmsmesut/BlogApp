using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Manager
{
    public  class ArticleManager : BaseManager
    {


        public ArticleManager(BlogModelDbContext ctx = null) : base(ctx) {

        }



        public List<Article> GetArticles()
        {
            //string sqlQuery = @"Select * from Article ";

            var data = _Context.Articles.ToList();
            

            return data;
        }


        public List<Article> GetPopularArticles() {
            
            //1.Yöntem
            //var data = _Context.Articles.OrderByDescending(x => x.CreateDate).Take(5).ToList();


            //2.Yöntem 
            string sqlQuery = @"
            Select a.* , i.LargeSize,i.SmalSize,i.LargeSize from Article a
            inner join [Image] i
            on a.ImageId = i.ImageId";

            var data = _Context.Database.SqlQuery<Article>(sqlQuery).ToList();

            var images = _Context.Database.SqlQuery<Image>("Select * from Image").ToList();

            foreach (Article a in data)
            {
                a.Image = images.Where(_ => _.ImageId == a.ImageId).FirstOrDefault();
            }
            
            return data;
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
