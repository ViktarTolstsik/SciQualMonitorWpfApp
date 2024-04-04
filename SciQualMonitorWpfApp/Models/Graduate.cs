using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Models
{
    public class Graduate
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Patronym { get; set; }
        [MaxLength(4)]
        public int DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsForeigner {  get; set; }
        public string ForeignCountry { get; set; }
        public string ForeignCommentary { get; set; }
        public string[] GraduationInstitutionTitle { get; set; }
        [MaxLength(4)]
        public int[] GraduationYear { get; set;}
        public string[] GraduationSpecialty { get; set; }
        public string[] GraduationQualification { get; set; }
        [MaxLength(4)]
        public int[] MastersDegreeYear { get; set; }
        public string[] MastersThesisTheme { get; set; }
        public string BIPGraduateType { get; set; }
        [MaxLength(4)]
        public int BIPAdmissionYear { get; set; }
        [MaxLength(4)]
        public int BIPContractYear { get; set; }
        public string BIPThesisTheme { get; set; }
        public string BIPSpecialty { get; set; }
        public string BIPStudyingForm { get; set; }
        public string BIPDepartment {  get; set; }
        public bool[] SemiAnnualCertification { get; set; }
        public int[] ArticlesCount { get; set; }
        public int[] ThesisCount { get; set; }
        public int PapersCount { get; set; }
        public string Transfers { get; set; }
        [MaxLength(4)]
        public int[] ExpulsionYear { get; set; }
        public string[] ExpulsionReason { get; set; }
        [MaxLength(4)]
        public int[] InterruptionYear { get; set; }
        public string[] InterruptionReason { get; set; }
        [MaxLength(4)]
        public int[] RestorationYear { get; set; }
        [MaxLength(4)]
        public int GraguationYear { get; set; }
        public string InGraduationYear { get; set; }
        [MaxLength(4)]
        public int ThesisDefenceYear { get; set; }
        [Indexed]
        public int SciAdviserId { get; set; }
    }
}
