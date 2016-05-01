using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ImreCV.ViewModels
{
   public class CVModel
    {
        public List<Person>  AllPersons { get; set; }
       public List<ComputerSkill> ComputerSkills { get; set; }
       public List<Education> Educations { get; set; }
       public List<Expectation> Expectations { get; set; }
       public List<Job> Jobs { get; set; }
       public List<Language> Languages  { get; set; }
       public List<PersonAttribute> PersonAttributes { get; set; }
    }
}
