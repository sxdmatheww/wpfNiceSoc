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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }
        private void zxc5674(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new menu());

        }
        private void zxc5679(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TB());

        }
        private void zxc1231(object sender, RoutedEventArgs e)
        {
            string url = "https://app.roboflow.com/molotki/hard-hat-sample-spd9r/deploy/2"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
