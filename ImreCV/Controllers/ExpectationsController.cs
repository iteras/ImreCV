using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using Domain;

namespace ImreCV.Controllers
{
    public class ExpectationsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Expectations
        public ActionResult Index()
        {
            var expectations = db.Expectations.Include(e => e.Person);
            return View(expectations.ToList());
        }

        // GET: Expectations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = db.Expectations.Find(id);
            if (expectation == null)
            {
                return HttpNotFound();
            }
            return View(expectation);
        }

        // GET: Expectations/Create
        public ActionResult Create()
        {
            ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname");
            return View();
        }

        // POST: Expectations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExpectationId,PreferedJob,DesiredJob,DesiredJobTime,Location,PersonId")] Expectation expectation)
        {
            if (ModelState.IsValid)
            {
                db.Expectations.Add(expectation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", expectation.PersonId);
            return View(expectation);
        }

        // GET: Expectations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = db.Expectations.Find(id);
            if (expectation == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", expectation.PersonId);
            return View(expectation);
        }

        // POST: Expectations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExpectationId,PreferedJob,DesiredJob,DesiredJobTime,Location,PersonId")] Expectation expectation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expectation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", expectation.PersonId);
            return View(expectation);
        }

        // GET: Expectations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = db.Expectations.Find(id);
            if (expectation == null)
            {
                return HttpNotFound();
            }
            return View(expectation);
        }

        // POST: Expectations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expectation expectation = db.Expectations.Find(id);
            db.Expectations.Remove(expectation);
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
