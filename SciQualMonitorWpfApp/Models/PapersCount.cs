using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class PapersCount
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        public int MonoCount { get; set; }
        public int ActCount { get; set; }
    }
}
