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
    /// Interaction logic for Driver_Info.xaml
    /// </summary>
    public partial class Driver_Info : Window
    {
        public Driver_Info()
        {
            InitializeComponent();
            ConnectionViewModel vm = new ConnectionViewModel();
            DataContext = vm;
        }

        private void LogInB_Click(object sender, RoutedEventArgs e)
        {
            Data_Gr dr = new Data_Gr();
            if (cmbx1.SelectedIndex == cmbx1.Items.Count - 1)
            {
                dr.Show();
                this.Close();

            }
        }
    }

    public class ConnectionViewModel : INotifyPropertyChanged
    {
        public ConnectionViewModel()
        {
            IList<PhoneBookEntry> list = new List<PhoneBookEntry>();
            list.Add(new PhoneBookEntry("Student"));
            list.Add(new PhoneBookEntry("Teacher"));
            _phonebookEntries = new CollectionView(list);
        }

        private readonly CollectionView _phonebookEntries;
        private string _phonebookEntry;

        public CollectionView PhonebookEntries
        {
            get { return _phonebookEntries; }
        }

        public string PhonebookEntry
        {
            get { return _phonebookEntry; }
            set
            {
                if (_phonebookEntry == value) return;
                _phonebookEntry = value;
                OnPropertyChanged("PhonebookEntry");
            }
        }

    }
}
}
