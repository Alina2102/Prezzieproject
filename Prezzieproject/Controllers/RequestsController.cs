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

            var requestsList = new List<RequestsModel>{
                new RequestsModel() { souvenirName = "Brezel", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Spätzle", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Toast", countrySouv = "Germany" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Kuchen", countrySouv = "Italien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Käse", countrySouv = "Frankreich" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Tomaten", countrySouv = "Italien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now },
                new RequestsModel() { souvenirName = "Bananen", countrySouv = "Spanien" , descriptionSouv = "Ich möchte Aufbackbrezeln vom Aldi Süd!", requestDate = DateTime.Now }
            };
            return View(requestsList);
        }

        public ActionResult Edit(RequestsModel robject)
        {
            // open specified request as an edit view
            return View(robject);
        }

        public ActionResult Details(RequestsModel robject)
        {
            return View(robject);
        }

        public ActionResult Delete(RequestsModel robject)
        {
            // Delete robject in DB...
            return RedirectToAction("Index");
        }

    }
}