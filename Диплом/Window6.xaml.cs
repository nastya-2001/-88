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
using Word = Microsoft.Office.Interop.Word;

namespace Диплом
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private ппEntities context = new ппEntities();
        public Window6()
        {
            InitializeComponent();
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            var allОбучающиеся = context.Обучающиеся.ToList();
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
           
                    
            }
        }
    }

