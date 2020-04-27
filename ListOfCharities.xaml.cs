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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для ListOfCharities.xaml
    /// </summary>
    public partial class ListOfCharities : Window
    {
        Entities context = new Entities();
        DispatcherTimer timer = new DispatcherTimer();
        public ListOfCharities()
        {

            InitializeComponent();
            ListCharity.ItemsSource = context.Charity.ToList();
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += this.Timer_Tick;
            timer.Start();
            Last();

        }
        private void Last()
        {
            TimeSpan last = new DateTime(2020, 11, 24) - DateTime.Now;
            time.Content = $"дней {last.Days} часов {last.Hours} минут {last.Minutes} до марафона";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Last();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }
    }
}
