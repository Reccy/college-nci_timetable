using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NCIOnlineTimetable.Models;

namespace NCIOnlineTimetable.Controllers
{
    public class SlotController : Controller
    {
        private TimetableContext db = new TimetableContext();

        // GET: Slot
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Slots.ToList());
        }

        // GET: Slot/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slot slot = db.Slots.Find(id);
            if (slot == null)
            {
                return HttpNotFound();
            }
            return View(slot);
        }

        // GET: Slot/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Slot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Name,StartTime,EndTime,Day")] Slot slot)
        {
            if (ModelState.IsValid)
            {
                db.Slots.Add(slot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(slot);
        }

        // GET: Slot/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slot slot = db.Slots.Find(id);
            if (slot == null)
            {
                return HttpNotFound();
            }
            return View(slot);
        }

        // POST: Slot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Name,StartTime,EndTime,Day")] Slot slot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(slot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(slot);
        }

        // GET: Slot/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slot slot = db.Slots.Find(id);
            if (slot == null)
            {
                return HttpNotFound();
            }
            return View(slot);
        }

        // POST: Slot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Slot slot = db.Slots.Find(id);
            db.Slots.Remove(slot);
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
