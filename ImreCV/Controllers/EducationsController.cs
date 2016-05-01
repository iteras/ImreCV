using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace ImreCV.Controllers
{
    public class EducationsController : Controller
    {
        //  private DataBaseContext db = new DataBaseContext();
        private readonly IEducationRepository _educationRepository = new EducationRepository(new DataBaseContext());
        private readonly IPersonRepository _personRepository = new PersonRepository(new DataBaseContext());
        // GET: Educations
        public ActionResult Index()
        {
            //var educations = db.Educations.Include(e => e.Person);
            return View(_educationRepository.All);
        }

        // GET: Educations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = _educationRepository.GetById(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // GET: Educations/Create
        public ActionResult Create()
        {
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname");
            // DropDownList DropDownList = new SelectedList(_educationRepository.All, nameof(Person.PersonId)), nameof(Person.Firstname)

            return View();
        }

        // POST: Educations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EducationId,Name,SchoolName,From,Until,Information,PersonId")] Education education)
        {
            if (ModelState.IsValid)
            {
                _educationRepository.Add(education);
                _educationRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", education.PersonId);
            return View(education);
        }

        // GET: Educations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = _educationRepository.GetById(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", education.PersonId);
            return View(education);
        }

        // POST: Educations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EducationId,Name,SchoolName,From,Until,Information,PersonId")] Education education)
        {
            if (ModelState.IsValid)
            {
                _educationRepository.Update(education);
                _educationRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", education.PersonId);
            return View(education);
        }

        // GET: Educations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = _educationRepository.GetById(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // POST: Educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Education education = _educationRepository.GetById(id);
            _educationRepository.Delete(education);
            _educationRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _educationRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
