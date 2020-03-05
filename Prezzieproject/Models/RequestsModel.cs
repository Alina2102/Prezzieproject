using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class RequestsModel
    {
        public int souvenirID { get; set; }
        public string userName { get; set; }
        public int amount { get; set; }
        public double reward { get; set; }
        public string status { get; set; }

    }
}