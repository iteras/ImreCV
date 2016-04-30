using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Language
    {
        public int LanguageId { get; set; }
        public string Communication { get; set; }
        public string Presentation { get; set; }
        public string Reading { get; set; }
        public string Listening  { get; set; }
        public string Writing { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
