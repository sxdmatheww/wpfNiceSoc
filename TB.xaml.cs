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
    /// Логика взаимодействия для TB.xaml
    /// </summary>
    public partial class TB : Page
    {
        public TB()
        {
            InitializeComponent();
        }
        private void zxc5675(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new menu());

        }
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
