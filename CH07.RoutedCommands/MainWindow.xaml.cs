using Microsoft.Win32;
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

namespace CH07.RoutedCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageData _image;
        public MainWindow()
        {
            InitializeComponent();

            //RoutedUICommand aa = new RoutedUICommand();
            //ApplicationCommands.Open
        }

        void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog{
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
            };
            if (dlg.ShowDialog() == true)
            {
                _image = new ImageData(dlg.FileName);
                DataContext = _image;
            }

        }
        void OnIsImageExist(object s, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _image != null;
        }
        void OnZoomOut(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom /= 1.2;
        }
        void OnZoomIn(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom *= 1.2;
        }
        void OnZoomNormal(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom = 1.0;
        }
    }
}
