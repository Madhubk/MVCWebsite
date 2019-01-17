using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description Madhu  application page test.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to 20cube.";

            return View();
        }
    }
}