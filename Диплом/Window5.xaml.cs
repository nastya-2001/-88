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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        ппEntities context;
        public Window5()
        {
            InitializeComponent();
            context = new ппEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridСдача_отчетности.ItemsSource = context.Сдача_отчетности.ToList();

        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdeteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddpe_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(grid1, "Печать");
            }
        }
    }
}
