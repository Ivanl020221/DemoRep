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

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для LastRunner.xaml
    /// </summary>
    public partial class LastRunner : Window
    {
        public LastRunner()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Reg(object sender, RoutedEventArgs e)
        {
            RegUser regUser = new RegUser();
            regUser.Show();
            this.Hide();
        }

        private void Avtoriz(object sender, RoutedEventArgs e)
        {
            Avtorization avtorization = new Avtorization();
            avtorization.Show();
            this.Close();
        }
    }
}