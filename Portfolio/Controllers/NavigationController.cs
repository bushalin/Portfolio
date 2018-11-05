using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Works()
        {
            return View();
        }

        public ActionResult Blogs()
        {
            return View();
        }
    }
}