﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Samples.Kinect.ControlsBasics.DataModel;

namespace Microsoft.Samples.Kinect.ControlsBasics.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewsList.xaml
    /// </summary>
    public partial class NewsList : UserControl
    {
        public NewsList()
        {
            InitializeComponent();

            this.itemsControl.ItemTemplate = (DataTemplate)this.FindResource(SampleDataSource.GetGroup("News").TypeGroup + "Template");
            this.itemsControl.ItemsSource = SampleDataSource.GetGroup("News");
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.OriginalSource;
            SampleDataItem sampleDataItem = button.DataContext as SampleDataItem;

            if (sampleDataItem != null)
            {
                if (sampleDataItem.Task == SampleDataItem.TaskType.Page && sampleDataItem.NavigationPage != null)
                {
                    MainWindow.history.Add(sampleDataItem.UniqueId);
                    MainWindow.var_navigationRegion.Content = Activator.CreateInstance(sampleDataItem.NavigationPage, sampleDataItem.Parametrs);
                }
            }
        }
    }
}