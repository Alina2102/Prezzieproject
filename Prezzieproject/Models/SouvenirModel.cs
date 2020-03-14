using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prezzieproject.Models
{
    public class SouvenirModel
    {
        [Key]
        public string souvenirID { get; set; }
        public string descriptionSouv { get; set; }

        // Relation to Request 
        public virtual RequestsModel request { get; set; }
        public string username { get; set; }


        // Relation to SouvenirInfo
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public virtual SouvenirInfoModel? souvenirInfo { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string souvenirName { get; set; }
        public string countrySouv { get; set; }
    }
}