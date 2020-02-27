using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prezzieproject.Models;

namespace Prezzieproject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        { 
            return View();
        }

        // GET: OwnRequests
        public ActionResult OwnRequests()
        {
            var requestsList = new List<RequestsModel>{
                new RequestsModel() { name = "Brezel", country = "Germany", description = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now }
            };
            return View(requestsList);
        }

    }
}