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
            ViewBag.Message = "Madhu is a good boy";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "job accounting finished by Madhu under by Madhu controll";

            return View();
        }
        public ActionResult Logindata()
        {
            ViewBag.Message = "Welcome to 20cube";

            return View();
        }
        
    }
}