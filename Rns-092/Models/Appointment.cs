using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rns_092.Models
{
    public class Appointment
    {
        public int id { get; set; }

        public DateTime appointDate { get; set; }
        [ForeignKey("pt")]
        public int ptID { get; set; }
        
        public patientdb pt { get; set; }
        [ForeignKey("doc")]
        public int docid { get; set; }

        public Doctors doc { get; set; }


    }
}