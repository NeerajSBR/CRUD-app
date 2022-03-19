using System;
using Rns_092.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Rns_092.Models.HospitalContextt;

namespace Rns_092.Controllers
{
    public class DoctorController : Controller
    {
        HospitalContext dc = new HospitalContext();
        // GET: Doctor
        public ActionResult Index()
        {
            List<Doctors> dclist = dc.doc.ToList();
            return View(dclist);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Doctors kc)
        {
            if (ModelState.IsValid)
            {
                dc.doc.Add(kc);
                dc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]

        public ActionResult Delete(int id)
        {
            return View(dc.doc.Find(id));
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeletePost(int id)
        {
            Doctors lc = dc.doc.Find(id);
            dc.doc.Remove(lc);
            dc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost,ActionName("Edit")]

        public ActionResult Editor(Doctors hc)
        {
            if (ModelState.IsValid)
            {
                dc.Entry(hc).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(hc);
        }
    }
}