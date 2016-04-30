using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelNr { get; set; }
        public string EducationLevel { get; set; }
        public string Story { get; set; }
        public virtual List<ComputerSkill> ComputerSkill { get; set; }
        public virtual List<Education> Education { get; set; }
        public virtual List<Expectation> Expectation { get; set; }
        public virtual List<Job> Jobs { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<PersonAttribute> PersonAttribute { get; set; }
    }
}
