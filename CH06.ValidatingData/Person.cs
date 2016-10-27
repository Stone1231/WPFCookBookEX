using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CH06.ValidatingData
{
    class Person : INotifyPropertyChanged//, IDataErrorInfo
    {
        protected virtual void OnPropertyChanged(string propName)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(propName));
        }

        string _name;
        [Required(ErrorMessage = "A name is required"), StringLength(
        100, MinimumLength = 3, ErrorMessage =
        "Name must have at least 3 characters")]
        public string Name
        {
            get { return _name; }
            set
            {
                ValidateProperty(value, "Name");
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //            throw new ArgumentException(
        //            "Name cannot be empty");
        //       _name = value;
        //        OnPropertyChanged("Name");
        //    }
        //}

        int _age;
        [Range(1, 120,
        ErrorMessage = "Age must be a positive integer")]
        public int Age
        {
            get { return _age; }
            set
            {
                ValidateProperty(value, "Age");
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value < 1)
        //            throw new ArgumentException(
        //            "Age must be a positive integer");
        //        _age = value;
        //        OnPropertyChanged("Age");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        //public string Error
        //{
        //    get { return null; }
        //}

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        switch (columnName)
        //        {
        //            case "Name":
        //                if (string.IsNullOrWhiteSpace(Name))
        //                    return "Name cannot be empty";
        //                break;
        //            case "Age":
        //                if (Age < 1)
        //                    return "Age must be a positive integer";
        //                break;
        //        }
        //        return null;
        //    }
        //}


        protected void ValidateProperty<T>(T value, string name)
        {
                Validator.ValidateProperty(value, new ValidationContext(
                            this, null, null) { MemberName = name });  
        }
    }
}
