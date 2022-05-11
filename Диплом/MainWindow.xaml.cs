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

namespace Диплом
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = "академия";
            string Pass = "777777";
            if (textBoxLogin.Text == login && textBoxPass.Password == Pass)
            {
                MessageBox.Show("Добро пожаловать!");
                var menu = new Window1();
                menu.ShowDialog();
            }
            else
                MessageBox.Show("Неправильно введен пароль или логин");
        }

        private void Button_vo_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
