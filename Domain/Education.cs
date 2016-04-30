using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Education
    {
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public string Information { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
