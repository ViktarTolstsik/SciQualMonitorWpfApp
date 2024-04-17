using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Helpers.Data
{
    public static class GraduatesBaseData<T>
    {
        public static void AddData(T data)
        {
            using (var db = new DataContext()) 
            {
                db.Add(data);
                db.SaveChanges();
            }
        }
        public static List<Graduate> GetGraduates()
        {
            using(var db = new DataContext()) 
            {
                return db.Graduates.OrderBy(grd => grd.Surname).ToList();
            }
        }
        public static List<Adviser> GetAdvisers()
        {
            using (var db = new DataContext())
            {
                return db.Advisers.OrderBy(adv => adv.Surname).ToList();
            }
        }
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
            using (var db = new DataContext())
            {
                db.Add(articlesCount);
                db.SaveChanges();
            }
        }
        public static void AddExpulsions(Expulsion expulsion)
        {
            using (var db = new DataContext())
            {
                db.Add(expulsion);
                db.SaveChanges();
            }
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
            using (var db = new DataContext())
            {
                db.Add(mastersDegree);
                db.SaveChanges();
            }
        }
        public static void AddHigherEducations(HigherEducationGraduation graduation)
        {
            using (var db = new DataContext())
            {
                db.Add(graduation);
                db.SaveChanges();
            }
        }
        public static void AddInterruption(Interruption interruption)
        {
            using (var db = new DataContext())
            {
                db.Add(interruption);
                db.SaveChanges();
            }

        }
        public static void AddPapers(PapersCount papersCount)
        {
            using (var db = new DataContext())
            {
                db.Add(papersCount);
                db.SaveChanges();
            }
        }
        public static void AddRestorations(Restoration restoration)
        {
            using (var db = new DataContext())
            {
                db.Add(restoration);
                db.SaveChanges();
            }
        }
        public static void AddSemiAnnualCertifications(SemiAnnualCertification certification)
        {
            using (var db = new DataContext())
            {
                db.Add(certification);
                db.SaveChanges();
            }
        }
        public static void AddTheses(ThesesCount thesesCount)
        {
            using (var db = new DataContext())
            {
                db.Add(thesesCount);
                db.SaveChanges();
            }
        }
        public static void AddTransfers(Transfer transfer)
        {
            using (var db = new DataContext())
            {
                db.Add(transfer);
                db.SaveChanges();
            }
        }
    }
}
