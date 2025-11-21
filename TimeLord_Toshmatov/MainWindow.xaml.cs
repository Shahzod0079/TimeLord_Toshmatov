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

namespace TimeLord_Toshmatov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            OpenPages(pages.stopwatch); 
        }

        /// <summary>
        /// перечесляемый тип страниц
        /// </summary>
        public enum pages
        {
            stopwatch // секундомер
        }

        /// <summary>
        /// Функция открытия страниц
        /// </summary>
        /// <param name="_page">Открыть страницу</param>
        public void OpenPages(pages _page)
        {
            if (_page == pages.stopwatch) 
                Frame.Navigate(new Pages.Stopwatch());
        }
    }
}
