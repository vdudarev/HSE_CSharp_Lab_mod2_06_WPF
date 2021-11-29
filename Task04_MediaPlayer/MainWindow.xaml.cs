using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WorkWithMedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            DefaultDialogService service = new DefaultDialogService();
            if (service.OpenFileDialog())
            {
                throw new NotImplementedException();

                CustomPlayer.Source = new Uri(service.FilePath);
            }
        }

        private void PlayMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PauseMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CustomPlayer_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimeSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CustomPlayer_OnMediaOpened(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}