using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class Adviser
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronym { get; set; }
        public string AcademicDegree {  get; set; }
        public string Specialty { get; set; }
    }
}
