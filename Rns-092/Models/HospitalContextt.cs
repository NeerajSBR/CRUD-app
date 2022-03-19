using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rns_092.Models
{
    public class HospitalContextt
    {
        public class HospitalContext : DbContext
        {
            public DbSet<patientdb> patient { get; set; }
            public DbSet<Doctors> doc { get; set; }

            public DbSet<Appointment>  apt { get; set; }
        }
    }
}