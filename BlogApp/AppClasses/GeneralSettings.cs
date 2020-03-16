using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BlogApp.AppClasses
{
    public class GeneralSettings
    {
        public static Size ImageSmallSize {
            get {
                Size sSize = new Size();
                sSize.Width = Convert.ToInt32(ConfigurationManager.AppSettings["ImgSmallWidth"]);
                sSize.Height = Convert.ToInt32(ConfigurationManager.AppSettings["ImgSmallHeight"]);
                return sSize;
            }
        }

        public static Size ImageMediumSize {
            get {
                Size mSize = new Size();
                mSize.Width = Convert.ToInt32(ConfigurationManager.AppSettings["ImgMediumWidth"]);
                mSize.Height = Convert.ToInt32(ConfigurationManager.AppSettings["ImgMediumHeight"]);
                return mSize;
            }
        }

        public static Size ImageLargeSize {
            get {
                Size lSize = new Size();
                lSize.Width = Convert.ToInt32(ConfigurationManager.AppSettings["ImgLargeWidth"]);
                lSize.Height = Convert.ToInt32(ConfigurationManager.AppSettings["ImgLargeHeight"]);
                return lSize;
            }
        }
    }
}
