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

namespace ProjectME
{
    /// <summary>
    /// Interaction logic for Charles_Leclerc.xaml
    /// </summary>
    public partial class Charles_Leclerc : Window
    {
        public Charles_Leclerc()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void DriverBack_Click(object sender, RoutedEventArgs e)
        {
            Driver_Info driverinfos = new Driver_Info();
            driverinfos.Show();
            this.Close();
        }
    }
}
