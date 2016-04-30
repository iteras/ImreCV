using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Expectation
    {
        [Key]
        public int ExpectationId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }


        [Display(Name = "Prefered job")]
        public string PreferedJob { get; set; }
        [Display(Name = "Desired job")]
        public string  DesiredJob { get; set; }

        [Display(Name = "Desired job time")]
        public string DesiredJobTime { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        
    }
}
