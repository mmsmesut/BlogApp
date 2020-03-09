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


        public List<Article> GetPopularArticles() {
            //return _Context.Articles.OrderByDescending(x => x.CreateDate).Take(4).ToList();

            return _Context.Database.SqlQuery<Article>("Select * from Articles").ToList();
        }
    }
}
