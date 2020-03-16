using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Manager
{
    public class CategoryManager : BaseManager
    {
        public CategoryManager(BlogModelDbContext ctx = null) : base(ctx) {

        }

        public List<Category> GetAllCategories() {
            return _Context.Categories.ToList();
        }

        public List<Article> GeyAllArticleByCategory(int id) {
            return _Context.Articles.Where(a => a.CategoryId == id).ToList();
        }

    }
}
