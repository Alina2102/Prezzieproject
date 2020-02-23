using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prezzieproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requests()
        {
            ViewBag.Message = "Here you can see the requests.";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Here you can change your profile settings and can manage your requests.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}