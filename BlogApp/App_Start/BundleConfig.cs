using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BlogApp.App_Start
{
    public class BundleConfig
    {       
        public static void RegisterBundles(BundleCollection bundles) {

            //Script Dosyaları için bir "Scripts" adında bir bundle -> ScriptBundle oluşturulur 
            bundles.Add(new ScriptBundle("~/Content/Scripts").Include(
                "~/Content/style/js/jquery.min.js",
                "~/Content/style/js/bootstrap.min.js",
                "~/Content/style/js/plugins.js",
                "~/Content/style/js/scripts.js"
                ));

            //Css dosyaları için bir "LayoutCss" adlı bundle -> StyleBundle oluşturulur 
            bundles.Add(new StyleBundle("~/Content/LayoutCss").Include("" +
                "~/Content/style/css/bootstrap.min.css",
                "~/Content/style/css/plugins.css",
                "~/Content/style/css/color/red.css",
                "~/Content/style.css",
                "~/Content/style/type/fontello.css",
                "~/Content/style/type/bebas.css"
                ));

#if DEBUG
            //EnableOptimizations özelliği eklenmelidir  
            BundleTable.EnableOptimizations = false;
#else
        BundleTable.EnableOptimizations = true;
#endif
        }
    }
    }
