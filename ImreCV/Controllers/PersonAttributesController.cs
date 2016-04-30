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
    public class PersonAttributesController : Controller
    {
        //private DataBaseContext db = new DataBaseContext();
        private readonly IPersonAttributeRepository _personAttributeRepository = new PersonAttributeRepository(new DataBaseContext());
        // GET: PersonAttributes
        public ActionResult Index()
        {
            //var personAttributes = db.PersonAttributes.Include(p => p.Person);
            return View(_personAttributeRepository.All);
        }

        // GET: PersonAttributes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAttribute personAttribute = _personAttributeRepository.GetById(id);
            if (personAttribute == null)
            {
                return HttpNotFound();
            }
            return View(personAttribute);
        }

        // GET: PersonAttributes/Create
        public ActionResult Create()
        {
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname");
            return View();
        }

        // POST: PersonAttributes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonAttributeId,Personality,StrongSides,TouchNeedingSides,Interrest,PersonId")] PersonAttribute personAttribute)
        {
            if (ModelState.IsValid)
            {
                _personAttributeRepository.Add(personAttribute);
                _personAttributeRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", personAttribute.PersonId);
            return View(personAttribute);
        }

        // GET: PersonAttributes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAttribute personAttribute = _personAttributeRepository.GetById(id);
            if (personAttribute == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", personAttribute.PersonId);
            return View(personAttribute);
        }

        // POST: PersonAttributes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonAttributeId,Personality,StrongSides,TouchNeedingSides,Interrest,PersonId")] PersonAttribute personAttribute)
        {
            if (ModelState.IsValid)
            {
                _personAttributeRepository.Update(personAttribute);
                _personAttributeRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", personAttribute.PersonId);
            return View(personAttribute);
        }

        // GET: PersonAttributes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAttribute personAttribute = _personAttributeRepository.GetById(id);
            if (personAttribute == null)
            {
                return HttpNotFound();
            }
            return View(personAttribute);
        }

        // POST: PersonAttributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonAttribute personAttribute = _personAttributeRepository.GetById(id);
            _personAttributeRepository.Delete(personAttribute);
            _personAttributeRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _personAttributeRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
