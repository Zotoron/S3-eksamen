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

namespace S3_eksamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FuncLayer Func = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpretBog_Click(object sender, RoutedEventArgs e)
        {
            Func.OpretBog(tbForfatter.Text, tbTitel.Text, tbUdgiver.Text, int.Parse(tbEksemplarer.Text), int.Parse(tbISBN.Text));
        }

       
    }
}
