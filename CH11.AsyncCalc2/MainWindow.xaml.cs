using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH11.AsyncCalc2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> _numbers = new ObservableCollection<int>();
        object _lock = new object();
        public MainWindow()
        {
            InitializeComponent();

            _list.ItemsSource = _numbers;
            BindingOperations.EnableCollectionSynchronization(_numbers, _lock);
            ThreadPool.QueueUserWorkItem(_ =>
            {
                var rnd = new Random();
                for (; ; )
                {
                    lock (_lock)
                    {
                        _numbers.Add(rnd.Next(1000));
                    }
                    Thread.Sleep(1000);
                }
            });

        }
    }
}
