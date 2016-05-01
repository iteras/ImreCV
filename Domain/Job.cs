using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Job
    {
        [Key]
        public int JobId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [MaxLength(100)]
        [Display(Name = "Firma/asutus")]
        public string Company { get; set; }

        [MaxLength(100)]
        [Display(Name = "Ametinimi")]
        public string JobName { get; set; }

        [Display(Name = "Alates")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }

        [Display(Name = "Kuni")]
        [DataType(DataType.Date)]
        public DateTime Until { get; set; }

        [Display(Name = "Veel töötan siiani selles asutuses")]
        public Boolean StillWorking { get; set; }

        [MaxLength(1024)]
        [Display(Name = "Töökirjeldus")]
        public string JobExplanation { get; set; }

        [MaxLength(200)]
        [Display(Name = "Lahkumise põhjus")]
        public string PurposeOfLeaving { get; set; }

       
    }
}
