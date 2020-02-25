using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prezzieproject.Models;

namespace Prezzieproject.Controllers
{
    public class RequestsController : Controller
    {
        // GET: Requests
        public ActionResult Index()
        {

            var requestsList = new List<RequestsModel>
            {
                new RequestsModel()
                { name = "Brezel", country = "Germany", description = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now }

            }

            return View();
        }

    }
}