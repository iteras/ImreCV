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

        [MaxLength(100)]
        [Display(Name = "Esimene eelistatud töökoht")]
        public string PreferedJob { get; set; }

        [MaxLength(1024)]
        [Display(Name = "Soovitud ametid")]
        public string  DesiredJob { get; set; }

        [MaxLength(1024)]
        [Display(Name = "Soovitud tööaeg")]
        public string DesiredJobTime { get; set; }


        [MaxLength(100)]
        [Display(Name = "Asukoht")]
        public string Location { get; set; }

        
    }
}
