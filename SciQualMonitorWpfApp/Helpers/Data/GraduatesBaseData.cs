using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Helpers.Data
{
    public static class GraduatesBaseData
    {
        public static void AddAdvisers(Adviser adviser)
        {
            using (var db = new DataContext())
            {
                db.Add(adviser);
                db.SaveChanges();
            }
        }
        public static void AddArticles(ArticlesCount articlesCount)
        {

        }
        public static void AddExpulsions(Expulsion expulsion)
        {

        }
        public static void AddGraduates(Graduate graduate)
        {
            using (var db = new DataContext())
            {
                db.Add(graduate);
                db.SaveChanges();
            }
        }
        public static void AddMastersDegrees(GraduateMastersDegree mastersDegree)
        {

        }
        public static void AddHigherEducations(HigherEducationGraduation graduation)
        {

        }
        public static void AddInterruption(Interruption interruption)
        {

        }
        public static void AddPapers(PapersCount papersCount)
        {

        }
        public static void AddRestorations(Restoration restoration)
        {

        }
        public static void AddSemiAnnualCertifications(SemiAnnualCertification certification)
        {

        }
        public static void AddTheses(ThesesCount thesesCount)
        {

        }
        public static void AddTransfers(Transfer transfer)
        {

        }
    }
}
