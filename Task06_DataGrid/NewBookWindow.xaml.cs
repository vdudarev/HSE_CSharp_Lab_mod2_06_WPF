using Library;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataGridSeminar
{
    /// <summary>
    /// Логика взаимодействия для NewBookWindow.xaml
    /// </summary>
    public partial class NewBookWindow : Window
    {
        private bool ready = false;

        /// <summary>
        /// The book created via this form.
        /// </summary>
        public LibraryItem? Result
        {
            get
            {
                if (!ready)
                    return null;
                return new LibraryItem
                {
                    Book = new Book
                    {
                        ISBN = int.Parse(ISBN.Text),
                        Title = Title.Text,
                        Author = Author.Text,
                        Year = int.Parse(Year.Text)
                    },
                    Total = int.Parse(Copies.Text),
                    Available = int.Parse(Copies.Text)
                };
            }
        }

        public NewBookWindow()
        {
            InitializeComponent();
        }

        private Regex numericRegex = new Regex(@"^\d+$");
        private Regex yearRegex = new Regex(@"^[-+]?\d+$");

        private void ISBN_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string text = (sender as TextBox).Text + e.Text;
            e.Handled = !(numericRegex.IsMatch(text) && int.Parse(text) > 0);
        }

        private void Copies_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string text = (sender as TextBox).Text + e.Text;
            e.Handled = !(numericRegex.IsMatch(text) && int.Parse(text) >= 0);
        }

        private void Year_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string text = (sender as TextBox).Text + e.Text;
            e.Handled = !(yearRegex.IsMatch(text));
        }

        private bool ValidateFields()
        {
            bool result = true;
            result &= !string.IsNullOrEmpty(ISBN.Text);
            result &= !string.IsNullOrEmpty(Title.Text);
            result &= !string.IsNullOrEmpty(Author.Text);
            result &= !string.IsNullOrEmpty(Year.Text);
            result &= !string.IsNullOrEmpty(Copies.Text);
            int isbn, year, copies;
            result &= int.TryParse(ISBN.Text, out isbn);
            result &= int.TryParse(Year.Text, out year);
            result &= int.TryParse(Copies.Text, out copies);
            result &= isbn > 0 & copies >= 0;
            return result;
        }

        private void readyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Not all fields are filled in or some are filled incorrectly.");
                return;
            }
            ready = true;
            Hide();
        }
    }
}
