using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Members
        //SongViewModel _viewModel;
        int _count = 0;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            //  We have declared the view model instance declaratively in the xaml.
            //  Get the reference to it here, so we can use it in the button click event.
            //_viewModel = (SongViewModel)base.DataContext;
        }

        private void ButtonUpdateArtist_Click(object sender, RoutedEventArgs e)
        {
            ++_count;
            _viewModel.ArtistName = string.Format("Elvis ({0})", _count);
        }
    }
}
