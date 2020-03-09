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
    }
}
