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

namespace Диплом
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window2();
            EditWindo.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window3();
            EditWindo.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window4();
            EditWindo.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window5();
            EditWindo.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window6();
            EditWindo.ShowDialog();
        }
    }
}
