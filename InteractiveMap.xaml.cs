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
    /// Логика взаимодействия для InteractiveMap.xaml
    /// </summary>
    public partial class InteractiveMap : Window
    {
        public InteractiveMap()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            AboutMarathonSkills2016 aboutMarathonSkills2016 = new AboutMarathonSkills2016();
            aboutMarathonSkills2016.Show();
            this.Close();
        }

        private void GotoCheckpoint1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
