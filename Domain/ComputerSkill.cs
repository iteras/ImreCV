using System;
using System.Collections.Generic;
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
        public int ComputerSkillId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [Display(Name = "Newbie skills")]
        public string NewbieSkills { get; set; }

        [Display(Name = "Moderate skills")]
        public string ModerateSkills { get; set; }

        [Display(Name ="Specialist skills")]
        public string SpecialistSkills { get; set; }

       
    }
}
