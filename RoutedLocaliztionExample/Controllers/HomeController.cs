using RoutedLocaliztionExample.ActionFilters;
using RoutedLocaliztionExample.Models;
using RoutedLocaliztionExample.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace RoutedLocaliztionExample.Controllers
{
    [Internationalization]
    public class HomeController : Controller
    {
        
        // Localize string without any external impact
        public ActionResult Index()
        {
            // Get string from strongly typed localzation resources
            var vm = new FullViewModel { LocalisedString = Strings.SomeLocalisedString };
            return View(vm);
        }
        // Get language from query string (by binder)
        public ActionResult LangFromQueryString(string lang)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
            
            var vm = new FullViewModel { LocalisedString = Strings.SomeLocalisedString };
            return View("Index", vm);
        }

        // Get language in action filter (from route parameter)
        [Internationalization]
        public ActionResult LangFromRouteInActionFilter()
        {
            var vm = new FullViewModel { LocalisedString = Strings.SomeLocalisedString };
            return View("Index", vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}