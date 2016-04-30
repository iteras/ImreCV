using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Expectation
    {
        public int ExpectationId { get; set; }
        public string PreferedJob { get; set; }
        public string  DesiredJob { get; set; }
        public string DesiredJobTime { get; set; }
        public string Location { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
