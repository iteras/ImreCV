using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class ComputerSkill
    {
        [Key]
        [DisplayName]
        public int ComputerSkillId { get; set; }

        [Required]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [Required]
        [MaxLength(1024)]
        [Display(Name = "Algaja oskus")]
        public string NewbieSkills { get; set; }

        [Required]
        [MaxLength(1024)]
        [Display(Name = "Keskmine tase")]
        public string ModerateSkills { get; set; }

        [Required]
        [MaxLength(1024)]
        [Display(Name ="Spetsialisti tase")]
        public string SpecialistSkills { get; set; }

       
    }
}
