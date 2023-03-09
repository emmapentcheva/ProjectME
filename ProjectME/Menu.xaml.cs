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
using System.Windows.Shapes;

namespace ProjectME
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Driver_Info_Click(object sender, RoutedEventArgs e)
        {
            Driver_Info driverinfo = new Driver_Info();
            driverinfo.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        

        

        private void driverinfoss_Click(object sender, RoutedEventArgs e)
        {
            Driver_Info driverinfo = new Driver_Info();
            driverinfo.Show();
            this.Close();
        }
    }
}
