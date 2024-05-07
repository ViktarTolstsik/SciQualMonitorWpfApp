using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SciQualMonitorWpfApp.Helpers.Data;
using SciQualMonitorWpfApp.Models;
using SciQualMonitorWpfApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SciQualMonitorWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Graduate> graduates;
        public ObservableCollection<Adviser> advisers;

        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 10;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth - 10;

            graduates = new ObservableCollection<Graduate>(GraduatesBaseData<Graduate>.GetGraduates());
            advisers = new ObservableCollection<Adviser>(GraduatesBaseData<Adviser>.GetAdvisers());


            UpdateView();

        }

        public void UpdateView()
        {
            var viewGraduates = new ObservableCollection<Graduate>(GraduatesBaseData<Graduate>.GetGraduates());
            foreach (var graduate in viewGraduates)
            {
                Adviser? adviser = advisers.FirstOrDefault(x => x.Id == graduate.SciAdviserId);
                graduate.Adviser = adviser;
            }
            dataGrid.ItemsSource = viewGraduates;

            titlePlaceholder.Text = $"Количество записей: {viewGraduates.Count}";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            Graduate selectedGraduate = dataGrid.SelectedItem as Graduate;

            GraduateDetails detailsWindow = new GraduateDetails(selectedGraduate);
            detailsWindow.Owner = this;
            this.Opacity = 0.9;
            this.Effect = new BlurEffect();
            detailsWindow.ShowDialog();

            this.Opacity = 1;
            this.Effect = null;
            //UpdateView();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateView();
        }

        private void addRecordsButton_Click(object sender, RoutedEventArgs e)
        {
            AddRecordWindow addRecordWindow = new AddRecordWindow();
            addRecordWindow.Owner = this;
            this.Opacity = 0.9;
            this.Effect = new BlurEffect();
            addRecordWindow.ShowDialog();

            this.Opacity = 1;
            this.Effect = null;

            //Adviser adviser = new Adviser
            //{
            //    Name = "test",
            //    Surname = "tyurtyuryr",
            //    Patronym = "asdass",
            //    AcademicDegree = "asdasda",
            //    Specialty = "sadasdadas"
            //};

            //Graduate graduate = new Graduate
            //{
            //    Name = "ghcfhnfghnfhn",
            //    Surname = "zcxvzvzcv",
            //    Patronym = "sdafdasf",
            //    DateOfBirth = 4454,
            //    Gender = "dsfdasf",
            //    IsForeigner = false,
            //    ForeignCountry = "asdasdad",
            //    ForeignCommentary = "asdasda",
            //    BIPGraduateType = "dsasdfsf",
            //    BIPAdmissionYear = 2222,
            //    BIPContractYear = 2332,
            //    BIPThesisTheme = "asdfdsfasd",
            //    BIPSpecialty = "asdasdasd",
            //    BIPStudyingForm = "sdsdsasdas",
            //    BIPDepartment = "aassssss",
            //    GraguationYear = 1222,
            //    InGraduationYear = "sdsdsasdasd",
            //    ThesisDefenceYear = 4444,
            //    SciAdviserId = 1
            //};

            //ArticlesCount articles1 = new ArticlesCount
            //{
            //    GraduateId = 1,
            //    YearOneArticles = 4,
            //    YearTwoArticles = 2,
            //    YearThreeArticles = 3,
            //    YearFourArticles = 6,
            //    YearFiveArticles = 7
            //};

            //Expulsion expulsion = new Expulsion
            //{
            //    GraduateId = 1,
            //    ExpulsionYear = 2222,
            //    ExpulsionReason = "dfdsfasdfadsf"
            //};

            //GraduateMastersDegree mastersDegree = new GraduateMastersDegree
            //{
            //    GraduateId = 1,
            //    MastersDegreeYear = 3435,
            //    MastersThesisTheme = "dsscsdafasfasdfasf"
            //};

            //HigherEducationGraduation higherEducation = new HigherEducationGraduation
            //{
            //    GraduateId = 1,
            //    GraduationInstitutionTitle = "asdasdasdad",
            //    GraduationYear = 2134,
            //    GraduationQualification = "axczdscfasd",
            //    GraduationSpecialty = "xsxczfa"
            //};

            //Interruption interruption = new Interruption
            //{
            //    GraduateId = 1,
            //    InterruptionYear = 3432,
            //    InterruptionReason = "sdfsdfdasf"
            //};

            //PapersCount papersCount = new PapersCount
            //{ 
            //    GraduateId = 1,
            //    ActCount = 21,
            //    MonoCount = 12
            //};

            //Restoration restoration = new Restoration
            //{
            //    GraduateId = 1,
            //    RestorationYear = 2333
            //};

            //SemiAnnualCertification certification = new SemiAnnualCertification
            //{
            //    GraduateId = 1,
            //    CertificationResults = "21adsfasdf"
            //};

            //ThesesCount thesesCount = new ThesesCount
            //{
            //    GraduateId = 1,
            //    YearOneTheses = 1,
            //    YearTwoTheses = 2,
            //    YearThreeTheses = 4,
            //    YearFourTheses = 5,
            //    YearFiveTheses = 6
            //};

            //Transfer transfer = new Transfer
            //{
            //    GraduateId = 1,
            //    TransferInfo = "asdfsdfdasfdasfasdvf"
            //};

            //GraduatesBaseData<Adviser>.AddData(adviser);
            //GraduatesBaseData<Graduate>.AddData(graduate);
            //GraduatesBaseData<ArticlesCount>.AddData(articles1);
            //GraduatesBaseData<Expulsion>.AddData(expulsion);
            //GraduatesBaseData<GraduateMastersDegree>.AddData(mastersDegree);
            //GraduatesBaseData<HigherEducationGraduation>.AddData(higherEducation);
            //GraduatesBaseData<Interruption>.AddData(interruption);
            //GraduatesBaseData<PapersCount>.AddData(papersCount);
            //GraduatesBaseData<Restoration>.AddData(restoration);
            //GraduatesBaseData<SemiAnnualCertification>.AddData(certification);
            //GraduatesBaseData<ThesesCount>.AddData(thesesCount);
            //GraduatesBaseData<Transfer>.AddData(transfer);

            //List<ArticlesCount> articles =  (List<ArticlesCount>)GraduatesBaseData<ArticlesCount>.GetData();

            //UpdateView();
        }
    }
}
