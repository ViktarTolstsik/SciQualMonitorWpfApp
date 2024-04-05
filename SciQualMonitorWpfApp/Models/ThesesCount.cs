using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class ThesesCount
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        public int YearOneTheses { get; set; }
        public int YearTwoTheses { get; set; }
        public int YearThreeTheses { get; set; }
        public int YearFourTheses { get; set; }
        public int YearFiveTheses { get; set; }
    }
}
