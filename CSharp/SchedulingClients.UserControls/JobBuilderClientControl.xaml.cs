﻿using SchedulingClients.JobBuilderServiceReference;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SchedulingClients.UserControls
{
    public partial class JobBuilderClientControl : UserControl
    {
        public JobBuilderClientControl()
        {
            InitializeComponent();
        }

        private void createJobButton_Click(object sender, RoutedEventArgs e)
        {
            JobBuilderClient client = DataContext as JobBuilderClient;
            JobData jobData;
            client.TryCreateJob(out jobData);
        }

        private void multiPickJobTest_Click(object sender, RoutedEventArgs e)
        {
            JobBuilderClient client = DataContext as JobBuilderClient;
            client.MultiPickJobTest();
        }
    }
}