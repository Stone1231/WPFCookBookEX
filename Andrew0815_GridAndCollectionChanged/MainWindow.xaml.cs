using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CH06.MasterDetail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        //List<Person> persons;
        ObservableCollection<Person> persons;

        public MainWindow()
        {
            InitializeComponent();
            persons = new ObservableCollection<Person>();
            persons.Add(new Person() { Name = "John",Age=25});
            persons.Add(new Person() { Name = "Bob", Age = 29 });
            persons.Add(new Person() { Name = "Bill", Age = 32 });

            this.DataContext = this;

            persons.CollectionChanged += persons_CollectionChanged;
        }

        void persons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Person psn = (e.NewItems[0] as Person);
            psn.Name = "Many";
        }


        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set
            {
                persons = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Persons"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            persons.Add(new Person() { Name = "Mary", Age = 27 });
           
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name {
            get
            { return _name; }
            set{
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        private int _age;
        public int Age { 
            get
            {return _age;} 
            set{
                _age = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Age"));
            } 
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
