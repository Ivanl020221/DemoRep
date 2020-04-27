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
    /// Логика взаимодействия для Inventar.xaml
    /// </summary>
    public partial class Inventar : Window
    {
        public Inventar()
        {
            InitializeComponent();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuAdministrator menuAdministrator = new MenuAdministrator();
            menuAdministrator.Show();
            this.Close();
        }

        private void GotoOtchet(object sender, RoutedEventArgs e)
        {
           
        }

        private void GotoInventarPostuplenie(object sender, RoutedEventArgs e)
        {
            InventarPostuplenie inventarPostuplenie = new InventarPostuplenie();
            inventarPostuplenie.Show();
            this.Close();
        }
    }
}
