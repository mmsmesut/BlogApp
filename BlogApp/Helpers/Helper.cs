using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Helpers
{
    public class Helper
    {
        //Static "ShortenContent" adlı bir metod oluşturuyoruz 
        public static string ShortenContent(string data)
        {
            if (data.Length > 300)
                return data.Substring(0, 300);
            else
                return data;
        }
    }
}