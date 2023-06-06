using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }
        private void zxc5673(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new menu());
            
        }
        private void zxc1233(object sender, RoutedEventArgs e)
        {
            string url = "https://colab.research.google.com/drive/1ByHq6_i8F4Z00h_-oT2zU7t_NLpv4sR3?usp=sharing"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);
        }
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
