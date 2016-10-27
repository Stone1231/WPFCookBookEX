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

namespace CH01.InheritDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _text2.ClearValue(TextBlock.FontSizeProperty);
        }

        public static readonly DependencyProperty DummyProperty =
        DependencyProperty.Register("Dummy", typeof(int),
        typeof(MainWindow), new FrameworkPropertyMetadata(0,
        FrameworkPropertyMetadataOptions.Inherits));
    }
}
