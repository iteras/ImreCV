using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class ComputerSkill
    {
        public int ComputerSkillId { get; set; }
        public string NewbieSkills { get; set; }
        public string ModerateSkills { get; set; }
        public string SpecialistSkills { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
