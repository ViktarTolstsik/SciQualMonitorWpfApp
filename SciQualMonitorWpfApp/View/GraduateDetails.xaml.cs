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
    /// Логика взаимодействия для GraduateDetails.xaml
    /// </summary>
    public partial class GraduateDetails : Window
    {
        public Graduate Graduate;
        public GraduateDetails(Graduate graduate)
        {
            InitializeComponent();
            this.Graduate = graduate;

            tabControl.DataContext = Graduate;

            if (Graduate.Gender.ToLower() == "мужской")
            {
               genderRadioM.IsChecked = true;
            }
            else
            {
                genderRadioF.IsChecked = true;
            }

            if (Graduate.IsForeigner) 
            {
                foreignCheck.IsChecked = true;
            }
            else
            {
                foreignCheck.IsEnabled = false;

                foreignCountryLabel.Foreground = new SolidColorBrush(Colors.Gray);
                foreignCountryName.Content = null;

                foreignCommentaryLabel.Foreground = new SolidColorBrush(Colors.Gray);
                foreignCommentaryText.Text = null;
                foreignCommentaryText.IsEnabled = false;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
