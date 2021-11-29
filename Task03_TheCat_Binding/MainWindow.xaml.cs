using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheshireCat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Binding binding = new Binding(); // Создаём объект привязки.
            //binding.ElementName = nameof(slider); // Присваиваем ему элемент, от которого мы будем получать значения.
            //binding.Path = new PropertyPath(nameof(slider.Value)); // Присваиваем ему свойство элемента, от которого мы будем получать значения.
            //cheshireCat.SetBinding(OpacityProperty, binding); // Устанавливаем свойство привязки у элемента Image. Указываем какому свойству нужна привязка.
        }
    }
}
