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
    /// Логика взаимодействия для MyRaceResult.xaml
    /// </summary>
    public partial class MyRaceResult : Window
    {
        public int REgID = 2;
        public MyRaceResult()
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
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }

        private void AllRunner(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
