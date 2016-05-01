using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using ImreCV.ViewModels;

namespace ImreCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository _personRepository = new PersonRepository(new DataBaseContext());
        private readonly IComputerSkillRepository _computerSkill = new ComputerSkillRepository(new DataBaseContext());
        private readonly IEducationRepository _educationRepository = new EducationRepository(new DataBaseContext());
        private readonly IExpectationRepository _expectationRepository = new ExpectationRepository(new DataBaseContext());
        private readonly IJobRepository _jobRepository = new JobRepository(new DataBaseContext());
        private readonly ILanguageRepository _languageRepository = new LanguageRepository(new DataBaseContext());
        private readonly IPersonAttributeRepository _personAttributeRepository = new PersonAttributeRepository(new DataBaseContext());




        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CVModel()
        {
            CVModel cvModel = new CVModel();
            cvModel.AllPersons = _personRepository.All;
            cvModel.ComputerSkills = _computerSkill.All;
            cvModel.Educations = _educationRepository.All;
            cvModel.Expectations = _expectationRepository.All;
            cvModel.Jobs = _jobRepository.All;
            cvModel.Languages = _languageRepository.All;
            cvModel.PersonAttributes = _personAttributeRepository.All;

            return View(cvModel);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}