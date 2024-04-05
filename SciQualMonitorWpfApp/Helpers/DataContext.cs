using Microsoft.EntityFrameworkCore;
using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciQualMonitorWpfApp.Helpers
{
    public class DataContext: DbContext
    {
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<ArticlesCount> Articles { get; set; }
        public DbSet<Expulsion> Expulsions { get; set; }
        public DbSet<GraduateMastersDegree> MastersDegrees { get; set; }
        public DbSet<HigherEducationGraduation> Graduations { get; set; }
        public DbSet<Interruption> Interruptions { get; set; }
        public DbSet<PapersCount> Papers { get; set; }
        public DbSet<Restoration> Restorations { get; set; }
        public DbSet<SemiAnnualCertification> Certifications { get; set; }
        public DbSet<ThesesCount> Theses { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        public string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source={DbPath}");
    }
}
