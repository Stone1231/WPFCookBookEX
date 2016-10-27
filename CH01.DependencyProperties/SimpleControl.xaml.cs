using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH01.DependencyProperties
{
    /// <summary>
    /// Interaction logic for SimpleControl.xaml
    /// </summary>
    public partial class SimpleControl : UserControl
    {
        public SimpleControl()
        {
            InitializeComponent();
        }

        public int YearPublished
        {
            get { return (int)GetValue(YearPublishedProperty); }
            set { SetValue(YearPublishedProperty, value); }
        }

        //public static readonly DependencyProperty
        //YearPublishedProperty = DependencyProperty.Register(
        //"YearPublished", typeof(int), typeof(SimpleControl),
        //new UIPropertyMetadata(2000));

        public static readonly DependencyProperty YearPublishedProperty = 
            DependencyProperty.Register(
            "YearPublished", 
            typeof(int), 
            typeof(SimpleControl),
            new UIPropertyMetadata(2000, OnValueChanged));

        private static void OnValueChanged(DependencyObject obj,
        DependencyPropertyChangedEventArgs e)
        {
            if(int.Parse(e.NewValue.ToString())>2004)
            {
                ((SimpleControl)obj).YearPublished = 2000;
            }
            // do something when property changes
        }
    }
}
