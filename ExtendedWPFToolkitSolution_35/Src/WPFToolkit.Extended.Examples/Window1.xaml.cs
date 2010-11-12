﻿using System;
using System.Collections.Generic;
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

namespace WPFToolkit.Extended.Examples
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window1_Loaded);            
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            Microsoft.Windows.Controls.MessageBox.Show("MyStezt", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Stop);
        }
    }
}
