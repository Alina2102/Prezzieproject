using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class CustomerModel
    {
        [Key]
        public string username { get; set; }
        public string countryUser { get; set; }

        // Relation to Profil
        public ProfileModel profile { get; set; }
        public string email { get; set; }

        // Relation to Request 
        public virtual ICollection<RequestsModel> requests { get; set; }
        public int requestID { get; set; }

        // Relation to Souvenir
        public virtual ICollection<SouvenirModel> souvenirs { get; set; }
        public string souvenirID { get; set; }
    }
}