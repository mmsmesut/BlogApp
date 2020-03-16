using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Manager
{
    public class TagManager : BaseManager
    {
        public TagManager(BlogModelDbContext ctx = null) : base(ctx) { }


        public List<Tag> GetAllTags() {
            return _Context.Tags.ToList();
        }

        public List<Article> GeyAllArticleByTag(int id)
        {
            //return _Context.Articles.Where(a => a.Tags.Any(t=>t.TagId==id)).ToList();

            string sqlQuery = @"
                                  declare @tagId INT = {0}
                                  Select * from Article a
                                  inner join ArticleTag t
                                  on a.ArticleId = t.ArticleId
                                  and t.TagId=@tagId";
            return _Context.Database.SqlQuery<Article>(sqlQuery, id).ToList();
        }
    }
}
