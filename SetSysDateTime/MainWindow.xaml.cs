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

using System.Runtime.InteropServices;

namespace SetSysDateTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime toDay;
        DateTime oldDay;

        public MainWindow()
        {
            InitializeComponent();
            toDay = DateTime.Today;
            oldDay = DateTime.Parse("2014/7/1");
        }

        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SYSTEMTIME systime = new SYSTEMTIME();
            GetSystemTime(ref systime);//不先取得時間就修改不了
            systime.wYear = (ushort)oldDay.Year;
            systime.wMonth = (ushort)oldDay.Month;
            systime.wDay = (ushort)oldDay.Day;
            SetSystemTime(ref systime);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SYSTEMTIME systime = new SYSTEMTIME();
            GetSystemTime(ref systime);//不先取得時間就修改不了
            systime.wYear = (ushort)toDay.Year;
            systime.wMonth = (ushort)toDay.Month;
            systime.wDay = (ushort)toDay.Day;
            SetSystemTime(ref systime);
        }

        private struct SYSTEMTIME
        {
            public ushort wYear;

            public ushort wMonth;

            public ushort wDayOfWeek;

            public ushort wDay;

            public ushort wHour;

            public ushort wMinute;

            public ushort wSecond;

            public ushort wMilliseconds;

        }
    }



}
