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

        public string Name { get; set; }

        [Display(Name = "School name")]
        public string SchoolName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime From { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Until { get; set; }
        public string Information { get; set; }

       
    }
}
