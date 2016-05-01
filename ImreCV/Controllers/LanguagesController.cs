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
    public class LanguagesController : Controller
    {
        //private DataBaseContext db = new DataBaseContext();
        private readonly ILanguageRepository _languageRepository = new LanguageRepository(new DataBaseContext());
        // GET: Languages
        public ActionResult Index()
        {
            //var languages = db.Languages.Include(l => l.Person);
            return View(_languageRepository.All);
        }

        // GET: Languages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Language language = _languageRepository.GetById(id);
            if (language == null)
            {
                return HttpNotFound();
            }
            return View(language);
        }

        // GET: Languages/Create
        public ActionResult Create()
        {
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname");
            return View();
        }

        // POST: Languages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LanguageId,Name,Communication,Presentation,Reading,Listening,Writing,PersonId")] Language language)
        {
            if (ModelState.IsValid)
            {
                _languageRepository.Add(language);
                _languageRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", language.PersonId);
            return View(language);
        }

        // GET: Languages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Language language = _languageRepository.GetById(id);
            if (language == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", language.PersonId);
            return View(language);
        }

        // POST: Languages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LanguageId,Name,Communication,Presentation,Reading,Listening,Writing,PersonId")] Language language)
        {
            if (ModelState.IsValid)
            {
                _languageRepository.Update(language);
                _languageRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Firstname", language.PersonId);
            return View(language);
        }

        // GET: Languages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Language language = _languageRepository.GetById(id);
            if (language == null)
            {
                return HttpNotFound();
            }
            return View(language);
        }

        // POST: Languages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Language language = _languageRepository.GetById(id);
            _languageRepository.Delete(language);
            _languageRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _languageRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
