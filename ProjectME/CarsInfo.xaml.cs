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
    /// Interaction logic for CarsInfo.xaml
    /// </summary>
    public partial class CarsInfo : Window
    {
        public CarsInfo()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void submiting_Click(object sender, RoutedEventArgs e)
        {
            Carferrari ferraricar = new Carferrari();
            CarMercedes mercedescar = new CarMercedes();
            Caralphatauri alphaTauricar = new Caralphatauri();
            CarRedbull redbullcar = new CarRedbull();
            Carmclaren mclarencar = new Carmclaren();
            
           if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
            {
                ferraricar.Show();
                this.Close();
            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
            {
                mercedescar.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
            {
                alphaTauricar.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
            {
                redbullcar.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
            {
                mclarencar.Show();
                this.Close();
            }
        }
    }
}
