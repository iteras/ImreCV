using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Job
    {
        public int JobId { get; set; }
        public string Company { get; set; }
        public string JobName { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public Boolean StillWorking { get; set; }
        public string JobExplanation { get; set; }
        public string PurposeOfLeaving { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
