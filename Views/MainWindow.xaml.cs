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

namespace Zadanie_19_Wpf
{
    /// <summary>
    /// Разработать по аналогии с лекцией WPF приложение по технологии MVVM.
    /// В приложении должно содержаться поле для ввода радиуса.
    /// По нажатию на кнопку рассчитать значение длины окружности и вывести его во второе поле.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
