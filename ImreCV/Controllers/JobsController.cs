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
    public class JobsController : Controller
    {
        //private DataBaseContext db = new DataBaseContext();
        private readonly IJobRepository _jobRepository = new JobRepository(new DataBaseContext());
        private readonly IPersonRepository _personRepository = new PersonRepository(new DataBaseContext());


        // GET: Jobs
        public ActionResult Index()
        {
            //var jobs = db.Jobs.Include(j => j.Person);
            return View(_jobRepository.All);
        }

        // GET: Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _jobRepository.GetById(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: Jobs/Create
        public ActionResult Create()
        {
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname");
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobId,Company,JobName,From,Until,StillWorking,JobExplanation,PurposeOfLeaving,PersonId")] Job job)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.Add(job);
                _jobRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", job.PersonId);
            return View(job);
        }

        // GET: Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _jobRepository.GetById(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", job.PersonId);
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobId,Company,JobName,From,Until,StillWorking,JobExplanation,PurposeOfLeaving,PersonId")] Job job)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.Update(job);
                _jobRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonId = new SelectList(_personRepository.All, "PersonId", "Firstname", job.PersonId);
            return View(job);
        }

        // GET: Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _jobRepository.GetById(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = _jobRepository.GetById(id);
            _jobRepository.Delete(job);
            _jobRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _jobRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
