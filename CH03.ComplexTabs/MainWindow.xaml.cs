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

namespace CH03.ComplexTabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _tabs.ItemsSource = new List<Dataitem> {
                new Dataitem { Header = "Header 1", Text = "Data 1 " },
                new Dataitem { Header = "Header 2", Text = "Data 2 " },
                new Dataitem { Header = "Header 3", Text = "Data 3 " },
            };

        }
    }
}
