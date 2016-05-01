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
   public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        public string Name { get; set; }
        public string Communication { get; set; }
        public string Presentation { get; set; }
        public string Reading { get; set; }
        public string Listening  { get; set; }
        public string Writing { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
