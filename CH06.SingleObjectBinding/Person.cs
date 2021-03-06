﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CH06.SingleObjectBinding
{
    class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                var pc = PropertyChanged;
                if (pc != null)
                    pc(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
