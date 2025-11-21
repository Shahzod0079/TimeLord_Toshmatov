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
            OpenPages(Pages.stopwatch);
        }

        /// <summary>
        /// Доступные страницы приложения
        /// </summary>
        public enum Pages
        {
            stopwatch
        }

        /// <summary>
        /// Навигация на указанную страницу
        /// </summary>
        /// <param name="page">Целевая страница</param>
        public void OpenPages(Pages page)
        {
            if (page == Pages.stopwatch)
                Frame.Navigate(new Pages.Stopwath());
        }
    }
}
