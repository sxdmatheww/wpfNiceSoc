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
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Page
    {
        public menu()
        {
            InitializeComponent();
        }
        private void zxc1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page1());
            // Manager.MainFrame = MainFrame;
        }

        private void zxc2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page2());
            // Manager.MainFrame = MainFrame;
        }

        private void zxc3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page3());
            // Manager.MainFrame = MainFrame;
        }

        private void zxc4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page4());
            // Manager.MainFrame = MainFrame;
        }
    }
}
