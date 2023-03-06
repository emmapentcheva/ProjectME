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
    /// Interaction logic for TeamsInfo.xaml
    /// </summary>
    public partial class TeamsInfo : Window
    {
        public TeamsInfo()
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
            Ferrari ferrari = new Ferrari();
            Mercedes mercedes = new Mercedes();
            Mclaren mclaren = new Mclaren();
            Redbull redbull = new Redbull();
            AlphaTauri alphaTauri = new AlphaTauri();

            if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
            {
                ferrari.Show();
                this.Close();
            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
            {
                mercedes.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
            {
                mclaren.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
            {
                redbull.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
            {
                alphaTauri.Show();
                this.Close();
            }
        }
    }
}
