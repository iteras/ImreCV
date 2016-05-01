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

        [Required]
        [Display(Name = "Keel")]
        [MaxLength(32)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Suhtlemine")]
        [MaxLength(20)]
        public string Communication { get; set; }
        [Required]
        [Display(Name = "Esitlemine")]
        [MaxLength(20)]
        public string Presentation { get; set; }
        [Required]
        [Display(Name = "Lugemine")]
        [MaxLength(20)]
        public string Reading { get; set; }
        [Required]
        [Display(Name = "Kuulamine")]
        [MaxLength(20)]
        public string Listening  { get; set; }
        [Required]
        [Display(Name = "Kirjutamine")]
        [MaxLength(20)]
        public string Writing { get; set; }
        

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
