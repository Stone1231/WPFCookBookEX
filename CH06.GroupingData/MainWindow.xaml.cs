using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CH06.GroupingData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var processes = Process.GetProcesses().Where(CanAccess);
            DataContext = processes;

            var view = CollectionViewSource.GetDefaultView(processes);
            //view.GroupDescriptions.Add(new PropertyGroupDescription("PriorityClass"));

            view.GroupDescriptions.Add(new PropertyGroupDescription("Threads.Count",
                new ThreadsToGroupConverter()));
        }

        public static bool CanAccess(Process process)
        {
            try
            {
                var h = process.Handle;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
