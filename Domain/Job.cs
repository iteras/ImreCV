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

        public string Company { get; set; }
        [Display(Name = "Job name")]
        public string JobName { get; set; }

        [DataType(DataType.Date)]
        public DateTime From { get; set; }
        [DataType(DataType.Date)]
        public DateTime Until { get; set; }

        public Boolean StillWorking { get; set; }

        [Display(Name = "Job's explanation")]
        public string JobExplanation { get; set; }
        [Display(Name = "Purpose of leaving the job")]
        public string PurposeOfLeaving { get; set; }

       
    }
}
