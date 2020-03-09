using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Manager
{
    public class BaseManager
    {
        protected BlogModelDbContext _Context { get; set; }

        public BaseManager(BlogModelDbContext ctx) {
            _Context = ctx ?? new BlogModelDbContext(DataService.ConnectionStringName);
        }

    }
}
