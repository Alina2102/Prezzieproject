using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class SouvenirInfoModel
    {
        [Key]
        public string souvenirName { get; set; }
        [Key]
        public string countrySouv { get; set; }
        public double price { get; set; }

        // Realtion to Souvenir
        public virtual SouvenirModel souvenir { get; set; }
        public string souvenirID { get; set; }
    }
}