using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Data.Manager;


namespace BlogApp.Data
{
    public class DataService
    {
        public int UserId { get; set; }


        private static BlogModelDbContext _Context;

        public static string ConnectionStringName {

            get {
                return System.Configuration.ConfigurationManager.ConnectionStrings["BlogDbContext"].ConnectionString;
            }    
        }

        public DataService()
        {
            _Context = new BlogModelDbContext(ConnectionStringName);
        }
        
        public CategoryManager _CategoryManager;

        public CategoryManager CategoryManager {
            get {
                if (_CategoryManager == null)
                    _CategoryManager = new CategoryManager(_Context);
                return _CategoryManager;
               }
        }

        private TagManager _TagManager;
        public TagManager TagManager {
            get {
                if (_TagManager == null)
                    _TagManager = new TagManager(_Context);
                return _TagManager;
            }
        }


        private  ArticleManager _ArticleManager;
        public  ArticleManager ArticleManager {
            get 
                {
                if (_ArticleManager == null)
                    _ArticleManager = new ArticleManager(_Context);
                return _ArticleManager;
            }
        }

    }
}
