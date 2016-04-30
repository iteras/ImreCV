using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class PersonAttribute
    {
        [Key]
        public int PersonAttributeId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public string Personality { get; set; }
        [Display(Name = "Strong sides of you")]
        public string StrongSides { get; set; }

        [Display(Name = "Touch needing sides")]
        public string TouchNeedingSides { get; set; }
        public string Interrest { get; set; }

        
    }
}
