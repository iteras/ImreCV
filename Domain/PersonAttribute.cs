using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class PersonAttribute
    {
        [Key]
        public int PersonAttributeId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [MaxLength(160)]
        [Display(Name = "Isikuomadused")]
        public string Personality { get; set; }

        [MaxLength(160)]
        [Display(Name = "Tugevad küljed")]
        public string StrongSides { get; set; }

        [MaxLength(160)]
        [Display(Name = "Arendamist vajavad küljed")]
        public string TouchNeedingSides { get; set; }

        [MaxLength(160)]
        [Display(Name = "Huvid")]
        public string Interrest { get; set; }

        
    }
}
