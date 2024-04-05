using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class ArticlesCount
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        public int YearOneArticles { get; set; }
        public int YearTwoArticles { get; set; }
        public int YearThreeArticles { get; set; }
        public int YearFourArticles { get; set; }
        public int YearFiveArticles { get; set; }
    }
}
