using System;
using System.Collections.Generic;
using System.IO;
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

namespace TreeViewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitialUpdate();
        }

        void InitialUpdate()
        {
        }

        // Добавить в XAML
        // <TreeView Name="MyTreeView" TreeViewItem.Expanded="ExpandUpdate">
        private void ExpandUpdate(object sender, RoutedEventArgs e)
        {
        }
    }
}
