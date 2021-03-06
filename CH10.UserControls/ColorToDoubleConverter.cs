﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace CH10.UserControls
{
    class ColorToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color)value;
            _lastColor = color;//
            switch ((string)parameter)
            {
                case "r": return color.R;
                case "g": return color.G;
                case "b": return color.B;
                case "a": return color.A;
            }
            return Binding.DoNothing;
        }

        private Color _lastColor;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = _lastColor;
            var intensity = (byte)(double)value;
            switch ((string)parameter)
            {
                case "r":
                    color.R = intensity;
                    break;
                case "g":
                    color.G = intensity;
                    break;
                case "b":
                    color.B = intensity;
                    break;
                case "a":
                    color.A = intensity;
                    break;
            }
            _lastColor = color;
            return color;
        }
    }
}
