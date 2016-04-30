using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class PersonAttribute
    {
        public int PersonAttributeId { get; set; }
        public string Personality { get; set; }
        public string StrongSides { get; set; }
        public string TouchNeedingSides { get; set; }
        public string Interrest { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
