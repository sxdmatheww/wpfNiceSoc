﻿using System;
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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void zxc9(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new menu());

        }
        private void zxc1237(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/Avar1tia/QRPy"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);

        }
    }
}
