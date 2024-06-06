using SciQualMonitorWpfApp.Helpers.Data;
using SciQualMonitorWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using System.Windows.Shapes;

namespace SciQualMonitorWpfApp.View
{
    /// <summary>
    /// Логика взаимодействия для AddRecordWindow.xaml
    /// </summary>
    public partial class AddRecordWindow : Window
    {
        public ObservableCollection<Adviser> advisers { get; set; }
        public int NewRecordId { get; set; }
        public AddRecordWindow(int lastRecordId)
        {
            InitializeComponent();
            advisers = new ObservableCollection<Adviser>(GraduatesBaseData<Adviser>.GetAdvisers());
            advisersComboBox.ItemsSource = advisers;
            NewRecordId = lastRecordId + 1;
            contentFill();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void AddAdviserButton_Click(object sender, RoutedEventArgs e)
        {
            NewAdviserWindow adviserWindow = new NewAdviserWindow();
            adviserWindow.Owner = this;
            this.Opacity = 0.9;
            adviserWindow.ShowDialog();

            this.Opacity = 1;
            this.Effect = null;
            advisers = new ObservableCollection<Adviser>(GraduatesBaseData<Adviser>.GetAdvisers());
            advisersComboBox.ItemsSource = advisers;

        }

        private void contentFill()
        {
            int thisYear = DateTime.UtcNow.Year;
            for (int i = thisYear - 100; i <= thisYear; i++)
            {
                birthYearComboBox.Items.Add(i.ToString());
                expulsionYearComboBox.Items.Add(i.ToString());
                higherEdGradYearComboBox.Items.Add(i.ToString());
                interruptionYearComboBox.Items.Add(i.ToString());
                mastersGradYearComboBox.Items.Add(i.ToString());
                restorationYearComboBox.Items.Add(i.ToString());
                BIPAdmissionYearComboBox.Items.Add(i.ToString());
                BIPContractYearComboBox.Items.Add(i.ToString());
            }
            for (int i = thisYear - 30; i < thisYear + 10; i++)
            {
                BIPGraduationYearComboBox.Items.Add(i.ToString());
                BIPThesisDefYearComboBox.Items.Add(i.ToString());
            }
            for (int i = 0; i < 100; i++)
            {
                actCountComboBox.Items.Add(i.ToString());
                monoCountComboBox.Items.Add(i.ToString());
                thesesCountYear1ComboBox.Items.Add(i.ToString());
                thesesCountYear2ComboBox.Items.Add(i.ToString());
                thesesCountYear3ComboBox.Items.Add(i.ToString());
                thesesCountYear4ComboBox.Items.Add(i.ToString());
                thesesCountYear5ComboBox.Items.Add(i.ToString());
                articlesCountYear1ComboBox.Items.Add(i.ToString());
                articlesCountYear2ComboBox.Items.Add(i.ToString());
                articlesCountYear3ComboBox.Items.Add(i.ToString());
                articlesCountYear4ComboBox.Items.Add(i.ToString());
                articlesCountYear5ComboBox.Items.Add(i.ToString());
            }
        }
    }
}
