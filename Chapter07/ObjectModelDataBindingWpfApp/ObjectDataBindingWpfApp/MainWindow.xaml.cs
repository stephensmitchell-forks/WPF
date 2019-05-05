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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxMaritalStatus.Items.Add("Single");
            comboBoxMaritalStatus.Items.Add("Married");
            comboBoxMaritalStatus.Items.Add("Single Mom");
            comboBoxMaritalStatus.Items.Add("Divorce");
            comboBoxMaritalStatus.Items.Add("Others");
            comboBoxMaritalStatus.SelectedIndex = 0;

            comboBoxState.Items.Add("Kentucky");
            comboBoxState.Items.Add("Mississippi");
            comboBoxState.Items.Add("Nevada");
            comboBoxState.Items.Add("New York");
            comboBoxState.SelectedIndex = 0;

            comboBoxCountry.Items.Add("United States");
            comboBoxCountry.SelectedIndex = 0;

            DataBindingToListView();
        }

        private void DataBindingToListView()
        {
            listView.Items.Add(new Education(
                "Diplom", "Science", 
                "Lincoln University", 
                "United States", 
                "1999", "Excellent"));
            listView.Items.Add(new Education(
                "B.A", "Science", 
                "Lincoln University", 
                "United States", 
                "2001", "Excellent"));
            listView.Items.Add(new Education(
                "M.B.A", "Business", 
                "Chicago University", 
                "United States",
                "2003", "Excellent"));
            listView.Items.Add(new Education(
                "PhD", "Science", 
                "Columbus University", 
                "United States", 
                "2007", "Excellent"));
        }
    }
}