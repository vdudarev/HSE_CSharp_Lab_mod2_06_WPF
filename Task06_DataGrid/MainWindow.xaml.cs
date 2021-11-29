using Library;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace DataGridSeminar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Library.Library library;

        public MainWindow()
        {
            InitializeComponent();

            // YOUR CODE HERE
        }

        /// <summary>
        /// Opens NewBookWindow to create a new book.
        /// </summary>
        private void newBook_Click(object sender, RoutedEventArgs e)
        {
            var newBookForm = new NewBookWindow();
            newBookForm.ShowDialog();
            // YOUR CODE HERE
        }

        /// <summary>
        /// Reads a library from csv file.
        /// </summary>
        private void openCSV_Click(object sender, RoutedEventArgs e)
        {
            // YOUR CODE HERE
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes library to a csv file
        /// </summary>
        private void saveCSV_Click(object sender, RoutedEventArgs e)
        {
            // YOUR CODE HERE
            throw new NotImplementedException();
        }

        /// <summary>
        /// Filters the data table to find only records that correspond the filter.
        /// </summary>
        private void searchLine_TextChanged(object sender, TextChangedEventArgs e)
        {
            // YOUR CODE HERE
            throw new NotImplementedException();
        }

        public void OnHyperlinkClick(object sender, RoutedEventArgs e)
        {
            Hyperlink link = (Hyperlink)e.OriginalSource;

            var psi = new ProcessStartInfo
            {
                FileName = link.NavigateUri.AbsoluteUri,
                UseShellExecute = true
            };
            Process.Start(psi);

        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                libraryGrid.ItemsSource = library.Books;
                libraryGrid.Items.Refresh();
            }
            catch { }; // This is super bad, dont try this at home.
        }
    }
}
