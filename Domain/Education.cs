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
   public class Education
    {
        [Key]
        public int EducationId { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [Required]
        [Display(Name = "Hariduse nimetus")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Kooli nimi")]
        public string SchoolName { get; set; }

        [Required]
        [Display(Name = "Alates")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }

        [Display(Name = "Kuni")]
        [DataType(DataType.Date)]
        public DateTime Until { get; set; }

        [Display(Name = "Lisainformatsioon")]
        [MaxLength(1024)]
        public string Information { get; set; }

       
    }
}
