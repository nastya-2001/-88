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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        ппEntities context;

        public string SearchText { get; set; }
        public Window3()
        {
            InitializeComponent();
            context = new ппEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridДПО.ItemsSource = context.ДПО.ToList();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxSearch.Text))
            {
                DataGridДПО.ItemsSource = context.ДПО.ToList();
            }
            else
            {
                DataGridДПО.ItemsSource = context.ДПО.Where(dpo =>
             dpo.Фамилия_указанная_в_дипломе.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            }
        }

        private void BtnAdeteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            var currentДПО = DataGridДПО.SelectedItem as ДПО;
            if (currentДПО == null)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.ДПО.Remove(currentДПО);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
