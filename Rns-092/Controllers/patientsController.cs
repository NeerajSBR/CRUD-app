using Rns_092.Models;
using System.Collections.Generic;
using System.Linq;
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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost,ActionName("Create")]

        public ActionResult Createor(patientdb kc)
        {
            if (ModelState.IsValid)
            {
                hc.patient.Add(kc);
                hc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            return View(hc.patient.Find(id));
        }
        public ActionResult Delete(int id)
        {
            return View(hc.patient.Find(id));
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult Deleteor(int id)
        {
            patientdb lc = hc.patient.Find(id);
            hc.patient.Remove(lc);
            hc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}