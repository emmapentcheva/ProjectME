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
    /// Interaction logic for Ferrari.xaml
    /// </summary>
    public partial class Ferrari : Window
    {
        public Ferrari()
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
            TeamsInfo teaminfo = new TeamsInfo();
            teaminfo.Show();
            this.Close();
        }
    }
}
