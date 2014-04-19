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
    public class GymClassesController : Controller
    {
        private GymAppDBContext db = new GymAppDBContext();

        // GET: /GymClasses/
        public ActionResult Index()
        {
            var gymclasses = db.GymClasses.Include(g => g.Activity).Include(g => g.Room);
            return View(gymclasses.ToList());
        }

        // GET: /GymClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymClass gymclass = db.GymClasses.Find(id);
            if (gymclass == null)
            {
                return HttpNotFound();
            }
            return View(gymclass);
        }

        // GET: /GymClasses/Create
        public ActionResult Create()
        {
            ViewBag.ActivityID = new SelectList(db.Activities, "ActivityID", "Name");
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Name");
            return View();
        }

        // POST: /GymClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="GymClassID,RoomID,ActivityID,ClassDate,DurationInMinutes")] GymClass gymclass)
        {
            if (ModelState.IsValid)
            {
                db.GymClasses.Add(gymclass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivityID = new SelectList(db.Activities, "ActivityID", "Name", gymclass.ActivityID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Name", gymclass.RoomID);
            return View(gymclass);
        }

        // GET: /GymClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymClass gymclass = db.GymClasses.Find(id);
            if (gymclass == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivityID = new SelectList(db.Activities, "ActivityID", "Name", gymclass.ActivityID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Name", gymclass.RoomID);
            return View(gymclass);
        }

        // POST: /GymClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="GymClassID,RoomID,ActivityID,ClassDate,DurationInMinutes")] GymClass gymclass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gymclass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivityID = new SelectList(db.Activities, "ActivityID", "Name", gymclass.ActivityID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Name", gymclass.RoomID);
            return View(gymclass);
        }

        // GET: /GymClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymClass gymclass = db.GymClasses.Find(id);
            if (gymclass == null)
            {
                return HttpNotFound();
            }
            return View(gymclass);
        }

        // POST: /GymClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GymClass gymclass = db.GymClasses.Find(id);
            db.GymClasses.Remove(gymclass);
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
