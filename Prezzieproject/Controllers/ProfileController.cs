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
                new RequestsModel() { userName = "Brezel", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Spätzle", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Toast", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Kuchen", countrySouv = "Italien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Käse", countrySouv = "Frankreich" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Tomaten", countrySouv = "Italien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { userName = "Bananen", countrySouv = "Spanien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now }
            };
            return View(requestsList);
        }

    }
}