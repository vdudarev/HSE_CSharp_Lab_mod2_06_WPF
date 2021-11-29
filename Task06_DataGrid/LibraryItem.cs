namespace Library
{
    /// <summary>
    /// Represents a book as an element of library's collection.
    /// </summary>
    public class LibraryItem
    {
        public Book Book { get; init; }

        private int _total;
        private int _available;

        /// <summary>
        /// Total number of copies of the book owned by the library.
        /// Cannot be negative, cannot be less than available.
        /// </summary>
        public int Total
        {
            get => _total;
            set
            {
                if (value < 0 || value < _available)
                    return;
                _total = value;
            }
        }

        /// <summary>
        /// Number of available copies at the moment.
        /// Cannot be negative, cannot be greater than total.
        /// </summary>
        public int Available
        {
            get => _available;
            set
            {
                if (value < 0 || value > _total)
                    return;
                _available = value;
            }
        }

        /// <summary>
        /// Shows if the library is planning to order a new batch of this book.
        /// </summary>
        public bool ToBeOrdered { get; set; }

        /// <summary>
        /// Link to the book in the online library service.
        /// </summary>
        public string? Link { get; set; }


        public override string ToString()
        {
            return Book.ToString() + ";" + Total + ";" + Available + ";" + ToBeOrdered + ";" + Link;
        }
    }
}
