using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUPMVVM
{
//    class PersonListVM : ViewModelBase<IList<Person>>
//    {
//        public PersonListVM()
//        {
//            Model = new List<Person>
//            {
//                new Person {
//                    Name = "Man A",
//                    Age = 10
//                },
//                new Person {
//                    Name = "Man B",
//                    Age = 10
//                }
//            };
//        }

//        public IEnumerable<PersonVM> Persons
//        {
//            get
//            {
//                return Model.Select(info =>
//                    new PersonVM { Model = info });
//            }
//        }

//        ICommand _AddCommand;
//        public ICommand AddCommand
//        {
//            get
//            {
//                return _AddCommand ?? (_AddCommand =
//                new RelayCommand(() =>
//                {
//                    var vm = new PersonVM();
//                    var dlg = new PersonWindow
//                    {
//                        DataContext = vm
//                    };
//                    if (dlg.ShowDialog() == true)
//                    {
//                        Model.Add(vm.Model);
//                        OnPropertyChanged("Persons");
//                    }
//                }));
//            }
//        }
//    }
}
