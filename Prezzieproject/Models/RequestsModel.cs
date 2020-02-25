using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class RequestsModel
    {
        public string name { get; set; }
        public string country { get; set; }
        public string description { get; set; }
        public DateTime requestDate { get; set; }

    }
}