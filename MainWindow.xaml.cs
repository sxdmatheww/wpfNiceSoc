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

namespace NICESOC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void zxc1(object sender, RoutedEventArgs e)
        {
            MainWindow.Navigate(new Page1());
        }

        private static void Navigate(Page1 page1)
        {
            throw new NotImplementedException();
        }

        private void zxc2(object sender, RoutedEventArgs e)
        {
            MainWindow.Navigate(new Page2());
        }

        private static void Navigate(Page2 page2)
        {
            throw new NotImplementedException();
        }

        private void zxc3(object sender, RoutedEventArgs e)
        {
            MainWindow.Navigate(new Page3());
        }

        private static void Navigate(Page3 page3)
        {
            throw new NotImplementedException();
        }

        private void zxc4(object sender, RoutedEventArgs e)
        {
            MainWindow.Navigate(new Page4());
        }
        private static void Navigate(Page4 page4)
        {
            throw new NotImplementedException();
        }
    }
}
