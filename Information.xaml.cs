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

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutMarathonSkills2016 mar = new AboutMarathonSkills2016();
            mar.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HowLongMarathon howLongMarathon = new HowLongMarathon();
            howLongMarathon.Show();
            this.Close();
        }

        private void GotoListOfCharities(object sender, RoutedEventArgs e)
        {
            ListOfCharities listOfCharities = new ListOfCharities();
            listOfCharities.Show();
            this.Close();
        }

        private void GotoBMIcalculator(object sender, RoutedEventArgs e)
        {
            
        }

        private void GotoBMRcalculator(object sender, RoutedEventArgs e)
        {
            
        }

        private void GotoLastResultRunner(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
