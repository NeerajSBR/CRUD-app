using Rns_092.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Rns_092.Models.HospitalContextt;

namespace Rns_092.Controllers
{
    public class patientsController : Controller
    {
        HospitalContext hc = new HospitalContext();
        // Get : Patients
        public ActionResult Index()
        {
            List<patientdb> ptlist = hc.patient.ToList();
            return View(ptlist);
        }
    }
}