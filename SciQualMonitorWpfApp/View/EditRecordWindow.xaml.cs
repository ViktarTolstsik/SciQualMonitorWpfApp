﻿using SciQualMonitorWpfApp.Helpers.Data;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SciQualMonitorWpfApp.View
{
    /// <summary>
    /// Логика взаимодействия для EditRecordWindow.xaml
    /// </summary>
    public partial class EditRecordWindow : Window
    {
        public ObservableCollection<Adviser> advisers { get; set; }
        public EditRecordWindow()
        {
            InitializeComponent();
            advisers = new ObservableCollection<Adviser>(GraduatesBaseData<Adviser>.GetAdvisers());
            advisersComboBox.ItemsSource = advisers;
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
    }
}
