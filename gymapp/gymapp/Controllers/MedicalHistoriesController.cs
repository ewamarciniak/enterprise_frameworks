using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gymapp.Models;

namespace gymapp.Controllers
{
    public class MedicalHistoriesController : Controller
    {
        private GymAppDBContext db = new GymAppDBContext();

        // GET: /MedicalHistories/
        public ActionResult Index()
        {
            return View(db.MedicalHistores.ToList());
        }

        // GET: /MedicalHistories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalhistory = db.MedicalHistores.Find(id);
            if (medicalhistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalhistory);
        }

        // GET: /MedicalHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MedicalHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MedicalHistoryID,RecentlyHospitalized,HighBloodPressure,HighCholesterol,Diabetes,HeartAttackOrStroke,HeartConditions,BackProblems,Allergies,Medication,ChronicIlnesses,Other")] MedicalHistory medicalhistory)
        {
            if (ModelState.IsValid)
            {
                db.MedicalHistores.Add(medicalhistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicalhistory);
        }

        // GET: /MedicalHistories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalhistory = db.MedicalHistores.Find(id);
            if (medicalhistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalhistory);
        }

        // POST: /MedicalHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MedicalHistoryID,RecentlyHospitalized,HighBloodPressure,HighCholesterol,Diabetes,HeartAttackOrStroke,HeartConditions,BackProblems,Allergies,Medication,ChronicIlnesses,Other")] MedicalHistory medicalhistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalhistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicalhistory);
        }

        // GET: /MedicalHistories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalhistory = db.MedicalHistores.Find(id);
            if (medicalhistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalhistory);
        }

        // POST: /MedicalHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalHistory medicalhistory = db.MedicalHistores.Find(id);
            db.MedicalHistores.Remove(medicalhistory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
