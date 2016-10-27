using GalaSoft.MvvmLight.Messaging;
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

namespace CRUDMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = vm;

            //BindingExpression binding = ListViewEmployeeDetails.GetBindingExpression(ListView.ItemsSourceProperty);
            
            Messenger.Default.Register<Person>(this, "create", ((p) =>
            {
                //應該重新取得資料來源, 目前沒資料來源,所以在這新增
                vm.Persons.Add(p);
                //binding.UpdateSource();                
            }));

            Messenger.Default.Register<Person>(this, "read", ((p) =>
            {
                var dlg = new PersonWindow
                {
                    DataContext = p
                };
                dlg.ShowDialog();
            }));

            Messenger.Default.Register<Person>(this, "update", ((p) =>
            {

                //重新Binding, 有點奇怪?
                this.DataContext = null;
                this.DataContext = vm;
            }));

            Messenger.Default.Register<Person>(this, "delete", ((p) =>
            {
                //應該重新取得資料來源, 目前沒資料來源,所以在這刪除
                vm.Persons.Remove(p);
            }));
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            var dlg = new PersonWindow
            {
                DataContext = new Person(),
                IsCreate = true
            };
            dlg.ShowDialog();
        }
    }
}
