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

        [Display(Name = "First name")]
        public string Firstname { get; set; }

        [Display(Name = "Last name")]
        public string Lastname { get; set; }
        
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public char Gender { get; set; }

        public string Address { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Telephone number")]
        [DataType(DataType.PhoneNumber)]
        public string TelNr { get; set; }

        [Display(Name ="Education level")]
        public string EducationLevel { get; set; }

        [DataType(DataType.MultilineText)]
        public string Story { get; set; }


        public virtual List<ComputerSkill> ComputerSkill { get; set; }
        public virtual List<Education> Education { get; set; }
        public virtual List<Expectation> Expectation { get; set; }
        public virtual List<Job> Job { get; set; }
        public virtual List<Language> Language { get; set; }
        public virtual List<PersonAttribute> PersonAttribute { get; set; }
    }
}
