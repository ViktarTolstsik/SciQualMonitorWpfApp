using SciQualMonitorWpfApp.Helpers.Data;
using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SciQualMonitorWpfApp.View
{
    /// <summary>
    /// Логика взаимодействия для NewAdviserWindow.xaml
    /// </summary>
    public partial class NewAdviserWindow : Window
    {
        public NewAdviserWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Adviser adviser = new Adviser
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Patronym = patronymTextBox.Text,
                AcademicDegree = degreeTextBox.Text,
                Specialty = specialtyTextBox.Text
            };

            GraduatesBaseData<Adviser>.AddData(adviser);

            this.Close();
        }
    }
}
