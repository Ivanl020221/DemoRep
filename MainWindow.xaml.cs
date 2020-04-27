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
using System.Windows.Threading;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += this.Timer_Tick;
            timer.Start();
            Last();
        }

        private void Last()
        {
            TimeSpan last = new DateTime(2020, 11, 24) - DateTime.Now;
            MatchTime.Content = $"дней {last.Days} часов {last.Hours} минут {last.Minutes} до марафона";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Last();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SponsorRunner sponsor = new SponsorRunner();
            //this.Hide();
            //sponsor.ShowDialog();
            //this.Show();
            SponsorRunner sponsor = new SponsorRunner();
            sponsor.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LastRunner last = new LastRunner();
            last.Show();
            this.Hide();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Information information = new Information();

            information.Show();
            this.Hide();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Avtorization avtorization = new Avtorization();
            avtorization.Show();
            this.Hide();

        }

    }
}
