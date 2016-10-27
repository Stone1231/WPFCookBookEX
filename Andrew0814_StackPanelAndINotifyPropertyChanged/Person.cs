using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace CH06.SingleObjectBinding
{
    public class Person : INotifyPropertyChanged
    {
        //public string Name { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Age"));
            }
        }

        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        _age = value;
        //        var pc = PropertyChanged;
        //        if (pc != null)
        //            pc(this, new PropertyChangedEventArgs("Age"));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

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
