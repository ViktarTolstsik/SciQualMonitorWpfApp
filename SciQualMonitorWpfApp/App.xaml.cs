using SciQualMonitorWpfApp.Helpers.Data;
using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SciQualMonitorWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Adviser adviser = new Adviser{ 
                Name = "test",
                Surname="sadsad",
                Patronym="asdass",
                AcademicDegree="asdasda",
                Specialty="sadasdadas"};
            Graduate graduate = new Graduate 
            {
                Name = "cdredfsdf",
                Surname = "sdfsdf",
                Patronym = "sdafdasf",
                DateOfBirth = 1234,
                Gender = "dsfdasf",
                IsForeigner = false,
                ForeignCountry = "asdasdad",
                ForeignCommentary = "asdasda",
                BIPGraduateType = "dsasdfsf",
                BIPAdmissionYear = 2222,
                BIPContractYear = 2332,
                BIPThesisTheme = "asdfdsfasd",
                BIPSpecialty = "asdasdasd",
                BIPStudyingForm = "sdsdsasdas",
                BIPDepartment = "aassssss",
                GraguationYear = 1222,
                InGraduationYear = "sdsdsasdasd",
                ThesisDefenceYear = 4444,
                SciAdviserId = 1
            };
            GraduatesBaseData.AddAdvisers(adviser);
            GraduatesBaseData.AddGraduates(graduate);
        }
    }
}
