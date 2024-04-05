using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class HigherEducationGraduation
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        public string GraduationInstitutionTitle { get; set; }
        [MaxLength(4)]
        public int GraduationYear { get; set; }
        public string GraduationSpecialty { get; set; }
        public string GraduationQualification { get; set; }
    }
}
