using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06.SingleObjectBinding2
{
    class Person : ObservableObject
    {
        public string Name { get; set; }
        int _age;
        public int Age
        {
            get { return _age; }
            //set
            //{
            //    if (_age != value)
            //    {
            //        _age = value;
            //        OnPropertyChanged("Age");  
            //    }
            //}
            set
            {
                SetProperty(ref _age, value, () => Age);
            }
        }
    }
}
