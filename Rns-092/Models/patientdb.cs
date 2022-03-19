using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rns_092.Models
{
    public class patientdb
    {
        public int id { get; set; }
        
        [Display(Name = "NAME")]
        public string name { get; set; }

        public float temp { get; set; }
        public string allergies { get; set; }

    }
    
}