using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
namespace Domain
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [MaxLength(32)]
        [Display(Name = "Eesnimi")]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(32)]
        [Display(Name = "Perekonna nimi")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Vanus")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Sünnikuupäev")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Sugu")]
        public char Gender { get; set; }

        [Required]
        [MaxLength(32)]
        [Display(Name = "Aadress")]
        public string Address { get; set; }

        [Required]
        [MaxLength(32)]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(32)]
        [Display(Name = "Mobiili number")]
        [DataType(DataType.PhoneNumber)]
        public string TelNr { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Haridustase")]
        public string EducationLevel { get; set; }

        [Required]
        [Display(Name = "Tutvustus ja eesmärgid")]
        [MaxLength(1024)]
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
