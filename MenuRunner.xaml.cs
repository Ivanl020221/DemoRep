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
    /// Логика взаимодействия для MenuRunner.xaml
    /// </summary>
    public partial class MenuRunner : Window
    {
        public MenuRunner()
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
            RegOnMarathon regOnMarathon = new RegOnMarathon();
            regOnMarathon.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditRunnerProfile editRunnerProfile = new EditRunnerProfile();
            editRunnerProfile.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyRaceResult myRaceResult = new MyRaceResult();
            myRaceResult.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ContactsMarathon contacts = new ContactsMarathon();
            contacts.Owner = this;
            contacts.ShowDialog();
        }
    }
}
