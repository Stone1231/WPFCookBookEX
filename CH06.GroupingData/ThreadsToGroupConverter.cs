using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace CH06.GroupingData
{
    class ThreadsToGroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int count = (int)value;
            return count / 10;
        }

        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    int count = (int)value;
        //    string text = string.Format("{0}-{1}",
        //    count == 0 ? 1 : count * 10, count * 10 + 9);
        //    return text;
        //}


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
