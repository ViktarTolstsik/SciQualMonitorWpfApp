using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class SemiAnnualCertification
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        [MaxLength(1)]
        public int YearOneCertOne { get; set; }
        [MaxLength(1)]
        public int YearOneCertTwo { get; set; }
        [MaxLength(1)]
        public int YearTwoCertOne { get; set; }
        [MaxLength(1)]
        public int YearTwoCertTwo { get; set; }
        [MaxLength(1)]
        public int YearThreeCertOne { get; set; }
        [MaxLength(1)]
        public int YearThreeCertTwo { get; set; }
        [MaxLength(1)]
        public int YearFourCertOne { get; set; }
        [MaxLength(1)]
        public int YearFourCertTwo { get; set; }
        [MaxLength(1)]
        public int YearFiveCertOne { get; set; }
        [MaxLength(1)]
        public int YearFiveCertTwo { get; set; }
    }
}
