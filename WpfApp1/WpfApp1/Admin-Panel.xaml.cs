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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin_Panel.xaml
    /// </summary>
    public partial class Admin_Panel : Window
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            EmploeePanel.Visibility = Visibility.Visible;
        }

        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMoneyBank_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
