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
            Adviser adviser = new Adviser
            {
                Name = "test",
                Surname = "tyurtyuryr",
                Patronym = "asdass",
                AcademicDegree = "asdasda",
                Specialty = "sadasdadas"
            };
            Graduate graduate = new Graduate
            {
                Name = "ghcfhnfghnfhn",
                Surname = "zcxvzvzcv",
                Patronym = "sdafdasf",
                DateOfBirth = 4454,
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
            GraduatesBaseData<Adviser>.AddData(adviser);
            GraduatesBaseData<Graduate>.AddData(graduate);

            UpdateView();
        }
    }
}
