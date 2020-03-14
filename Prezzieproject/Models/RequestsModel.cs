using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class RequestsModel { 
        [Key]
        public int requestID { get; set; }
        public int amount { get; set; }
        public double reward { get; set; }
        public string status { get; set; }
        public DateTime requestDate { get; set; }

        // Relation to Souvenir
        public virtual SouvenirModel souvenir { get; set;}
        public int souvenirID { get; set; }

        // Relation to Customer
        public virtual CustomerModel customer { get; set; }
        public string userName { get; set; }

    }
}