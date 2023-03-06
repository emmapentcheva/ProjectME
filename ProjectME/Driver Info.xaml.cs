using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Driver_Info.xaml
    /// </summary>
    public partial class Driver_Info : Window
    {
        public Driver_Info()
        {
            InitializeComponent();
            //ConnectionViewModel vm = new ConnectionViewModel();
            //DataContext = vm;
        }


        private void submiting_Click(object sender, RoutedEventArgs e)
        {
            Max_Verstappen mv = new Max_Verstappen();
            Charles_Leclerc cl = new Charles_Leclerc();
            Carlos_Sainz cs = new Carlos_Sainz();
            Pierre_Gasly pg = new Pierre_Gasly();
            Lewis_Hamilton lh = new Lewis_Hamilton();
            Daniel_Ricciardo dr = new Daniel_Ricciardo();

             if (comboBox.SelectedIndex == comboBox.Items.Count - 6)
            {
                mv.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
            {
                cl.Show();
                this.Close();
            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
            {
                cs.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
            {
                pg.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
            {
                lh.Show();
                this.Close();

            }
            else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
            {
                dr.Show();
                this.Close();
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void DriverBack_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }

    //public class ConnectionViewModel : INotifyPropertyChanged
    //{
    //    public ConnectionViewModel()
    //    {
    //        IList<PhoneBookEntry> list = new List<PhoneBookEntry>();
    //        list.Add(new PhoneBookEntry("Student"));
    //        list.Add(new PhoneBookEntry("Teacher"));
    //        _phonebookEntries = new CollectionView(list);
    //    }

    //    private readonly CollectionView _phonebookEntries;
    //    private string _phonebookEntry;

    //    public CollectionView PhonebookEntries
    //    {
    //        get { return _phonebookEntries; }
    //    }

    //    public string PhonebookEntry
    //    {
    //        get { return _phonebookEntry; }
    //        set
    //        {
    //            if (_phonebookEntry == value) return;
    //            _phonebookEntry = value;
    //            OnPropertyChanged("PhonebookEntry");
    //        }
    //    }

    }