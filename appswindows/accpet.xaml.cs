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

namespace appswindows
{
    /// <summary>
    /// Interaction logic for accpet.xaml
    /// </summary>
    public partial class accpet : Window
    {
        public accpet()
        {
            InitializeComponent();
        }

        private void bacp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ref_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
