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
            ViewBag.Message = "Madhu balan 20cube user";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "job accounting finished by Madhu";

            return View();
        }
    }
}