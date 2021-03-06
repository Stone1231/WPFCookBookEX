﻿using System;
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

namespace CH06.SingleObjectBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        public MainWindow()
        {
            InitializeComponent();

            _person = new Person { Name = "Bart", Age = 10 };
            DataContext = _person;
            tb_name.Margin = new Thickness(2, 2, 0, 0);
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            _person.Age++;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _person.Age = 15;
        }
    }
}
