using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace CRUPMVVM
{
    public class Person : GalaSoft.MvvmLight.ViewModelBase
    {
        public Person()
        {
            Age = 0;

            UpdateCommand = new RelayCommand(() =>
                {
                    Age += 1;
                });
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                RaisePropertyChanged("Age");
            }
        }


        public RelayCommand UpdateCommand { get; private set; }

    }

    //class PersonVM : ViewModelBase<Person>
    //{
    //    public PersonVM() {
    //        Model = new Person();
    //    }

    //    public string Name
    //    {
    //        get { return Model.Name; }
    //        set
    //        {
    //            Model.Name = value;
    //            OnPropertyChanged("IsCommentOK");
    //        }
    //    }

    //    public int Age
    //    {
    //        get { return Model.Age; }
    //        set
    //        {
    //            Model.Age = value;
    //            OnPropertyChanged("IsCommentOK");
    //        }
    //    }

    //    public bool IsCommentOK
    //    {
    //        get
    //        {
    //            return !string.IsNullOrWhiteSpace(Model.Name) &&
    //            !(Model.Age < 0 || Model.Age > 120);
    //        }
    //    }

    //    ICommand _UpdateCommand;
    //    public ICommand UpdateCommand
    //    {
    //        get
    //        {
    //            return _UpdateCommand ?? (_UpdateCommand =
    //            new RelayCommand(() =>//new RelayCommand<int>(i =>
    //            {
    //                //Model = Persons[i];
    //                var dlg = new PersonWindow
    //                {
    //                    DataContext = this
    //                };
    //                if (dlg.ShowDialog() == true)
    //                {
    //                    int age = Age;//隨便寫
    //                }
    //            }));
    //        }
    //    }

    //    //private ObservableCollection<Person> m_Persons;
    //    //public ObservableCollection<Person> Persons
    //    //{
    //    //    get
    //    //    {
    //    //        return m_Persons;
    //    //    }
    //    //    set
    //    //    {
    //    //        m_Persons = value;
    //    //    }
    //    //}

    //    //ICommand _AddCommand;
    //    //public ICommand AddCommand
    //    //{
    //    //    get
    //    //    {
    //    //        return _AddCommand ?? (_AddCommand =
    //    //        new RelayCommand(() =>
    //    //        {
    //    //            Model = new Person();
    //    //            var dlg = new PersonWindow
    //    //            {
    //    //                DataContext = this
    //    //            };
    //    //            if (dlg.ShowDialog() == true)
    //    //            {
    //    //                Persons.Add(Model);
    //    //                OnPropertyChanged("Persons");
    //    //            }
    //    //        }));
    //    //    }
    //    //}
    //}
}
