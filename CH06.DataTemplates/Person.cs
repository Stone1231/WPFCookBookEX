using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06.DataTemplates
{
    class Person
    {
        public string Name { get; set; }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}：{1}", Name, Age);
        }
    }
}
