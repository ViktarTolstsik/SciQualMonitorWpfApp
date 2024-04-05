﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class Expulsion
    {
        [Key]
        public int Id { get; set; }
        public int GraduateId { get; set; }
        [ForeignKey("GraduateId")]
        public Graduate Graduate { get; set; }
        [MaxLength(4)]
        public int ExpulsionYear { get; set; }
        public string ExpulsionReason { get; set; }
    }
}
