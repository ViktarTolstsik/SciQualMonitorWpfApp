using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    internal class GraduateMastersDegree
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        [MaxLength(4)]
        public int MastersDegreeYear { get; set; }
        public string MastersThesisTheme { get; set; }
    }
}
