using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;


namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выбор цвета.
        /// </summary>
        /// <param name="sender"> Button </param>
        private void ColorPicker_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление всех нарисованных линий с холста.
        /// </summary>
        private void ClearCanvas()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку очистки холста.
        /// </summary>
        private void ClearButton_Click(object sender, RoutedEventArgs e) => ClearCanvas();

        /// <summary>
        /// Обработчик события нажатия на кнопку сохранения файла.
        /// </summary>
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку открытия файла.
        /// </summary>
        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обработчик события изменения толщины кисти.
        /// </summary>
        private void ThicknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
