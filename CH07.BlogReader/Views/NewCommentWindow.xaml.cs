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
using System.Windows.Shapes;

namespace CH07.BlogReader.Views
{
    /// <summary>
    /// Interaction logic for NewCommentWindow.xaml
    /// </summary>
    public partial class NewCommentWindow : Window
    {
        public NewCommentWindow()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
