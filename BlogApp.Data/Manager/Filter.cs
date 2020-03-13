using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlogApp.Data.Manager
{
    public class Filter
    {
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public bool TakeTotalCount { get; set; }
        public bool TakeTotal { get; set; }
        public Filter()
        {
            Take = 10;
            Skip = 0;
            TakeTotal = false;
            TakeTotal = false;
        }
    }

    //Article ile ilgili filitreleme işlemlerinde bu class kullanılır 
    public class ArticleFilter : Filter {

        public DateTime CreateDate { get; set; }
        public Category Category { get; set; }
        public Tag Tag { get; set; }        
        public int UserId { get; set; } //İlgili Yazarın Article'larını listelerken kullanırız 
    }

    public class UserFilter : Filter {
    }    
}
