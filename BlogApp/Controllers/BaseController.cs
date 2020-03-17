using BlogApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Data;

namespace BlogApp.Controllers
{
    public class BaseController : Controller
    {
        ////_db adında "BlogModelDbContext" türünde bir private değişken
        ////tanımlanır 
        //private static BlogModelDbContext _db;

        ///*                 
        // Amacımız Daha önce BlogModelDbContext türünde bir değişken 
        // oluşmuş
        // ise bir daha oluşturmamak 
        // "Db" adında "BlogModelDbContext" türünde bir public değişken 
        // tanımlanır 
        //*/
        //public static BlogModelDbContext Db {
        //    get {
        //        if (_db == null)
        //            _db = new BlogModelDbContext();
        //        return _db;
        //    }
        //}


        private static DataService _Service;

        public static DataService Service {
            get {
                if (_Service == null) {
                    _Service = new DataService();
                }
                return _Service;
            }
            
        }


    }
}