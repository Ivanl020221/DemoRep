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
    /// Логика взаимодействия для Avtorization.xaml
    /// </summary>
    public partial class Avtorization : Window
    {
        Entities context = new Entities();
        public Avtorization()
        {
            InitializeComponent();
            Login.Focus();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = context.User.Where(i => i.Email == Login.Text && i.Password == PasswordTxt.Password).ToList();
            if (a.Count > 0)
            {

                if (a.FirstOrDefault().RoleId == "C")
                {
                    CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                    coordinatorMenu.Show();
                    this.Close();
                }
                else if (a.FirstOrDefault().RoleId == "R")
                {
                    MenuRunner menuRunner = new MenuRunner();
                    menuRunner.Show();
                    this.Close();
                }
                else if (a.FirstOrDefault().RoleId == "A")
                {
                    MenuAdministrator menuAdministrator = new MenuAdministrator();
                    menuAdministrator.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
