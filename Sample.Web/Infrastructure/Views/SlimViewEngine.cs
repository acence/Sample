using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Infrastructure.Views
{
    public class SlimViewEngine : RazorViewEngine
    {
        public SlimViewEngine()
        {
            AreaViewLocationFormats = new string[] { "~/{2}/Views/{1}/{0}.cshtml", "~/{2}/Views/Shared/{0}.cshtml" };
            AreaMasterLocationFormats = new string[] { "~/{2}/Views/{1}/{0}.cshtml", "~/{2}/Views/Shared/{0}.cshtml" };
            AreaPartialViewLocationFormats = new string[] { "~/{2}/Views/{1}/{0}.cshtml", "~/{2}/Views/Shared/{0}.cshtml" };
            ViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            MasterLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            PartialViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            FileExtensions = new string[] { "cshtml" };
        }
    }
}