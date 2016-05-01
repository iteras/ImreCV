using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace ImreCV.Controllers
{
    public class ExpectationsController : Controller
    {
        //private DataBaseContext db = new DataBaseContext();
        private readonly IExpectationRepository _expectationRepository = new ExpectationRepository(new DataBaseContext());
        private readonly IPersonRepository _personRepository = new PersonRepository(new DataBaseContext());


        // GET: Expectations
        public ActionResult Index()
        {
           // var expectations = db.Expectations.Include(e => e.Person);
            return View(_expectationRepository.All);
        }

        // GET: Expectations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = _expectationRepository.GetById(id);
            if (expectation == null)
            {
                return HttpNotFound();
            }
            return View(expectation);
        }

        // GET: Expectations/Create
        public ActionResult Create()
        {
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname");
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
                _expectationRepository.Add(expectation);
                _expectationRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", expectation.PersonId);
            return View(expectation);
        }

        // GET: Expectations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = _expectationRepository.GetById(id);
            if (expectation == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", expectation.PersonId);
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
                _expectationRepository.Update(expectation);
                _expectationRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", expectation.PersonId);
            return View(expectation);
        }

        // GET: Expectations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expectation expectation = _expectationRepository.GetById(id);
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
            Expectation expectation = _expectationRepository.GetById(id);
            _expectationRepository.Delete(expectation);
            _expectationRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _expectationRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
