using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class ProfileModel
    {
        public string email { get; set; }
        public string username { get; set; }
        public string passwort { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string descriptionUser { get; set; }
        public DateTime birthday { get; set; }
        
    }
}