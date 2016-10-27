using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace CRUDMVVM
{
    public class Person : GalaSoft.MvvmLight.ViewModelBase
    {
        public Person()
        {
            //Age = 0;

            CreateCommand = new RelayCommand<Person>((p) =>
            {
                if (p != null)
                {
                    int? age = p.Age;//資料處裡...隨便寫
                    if (true)//處理成功後再通知更新
                    {
                        Messenger.Default.Send<Person>(p, "create");
                    }
                }
            });

            ReadCommand = new RelayCommand<Person>((p) =>
            {
                if (p != null)
                {
                    //p.Age += 1;
                    //Messenger.Default.Send("Test");
                    //Messenger.Default.Send<Person>(p, "ReadPerson");
                    Messenger.Default.Send<Person>(p, "read");
                }
            });

            UpdateCommand = new RelayCommand<Person>((p) =>
            {
                if (p != null)
                {
                    int? age = p.Age;//資料處裡...隨便寫
                    if (true)//處理成功後再通知更新
                    {
                        Messenger.Default.Send<Person>(p, "update");
                    }
                }
            });

            DeleteCommand = new RelayCommand<Person>((p) =>
            {
                if (p != null)
                {
                    int? age = p.Age;//資料處裡...隨便寫
                    if (true)//處理成功後再通知更新
                    {
                        Messenger.Default.Send<Person>(p, "delete");
                    }
                }
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

        private int? _age;
        public int? Age
        {
            get { return _age; }
            set
            {
                _age = value;
                RaisePropertyChanged("Age");
            }
        }

        public bool IsCommentOK
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name) &&
                !(Age < 0 || Age > 120);
            }
        }

        public RelayCommand<Person> ReadCommand { get; private set; }

        public RelayCommand<Person> UpdateCommand { get; private set; }

        public RelayCommand<Person> CreateCommand { get; private set; }

        public RelayCommand<Person> DeleteCommand { get; private set; }
    }
}
