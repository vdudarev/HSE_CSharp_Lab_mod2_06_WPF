using System;

namespace Library
{
    /// <summary>
    /// A book has its ISBN, title, author name, and release year. 
    /// None of these properties can be changed once they are set for obvious reasons. 
    /// Two books are considered equal if their ISBNs are equal. 
    /// (In a perfect world there could not be two books with equal ISBNs and different titles/authors/years. 
    /// Here it's possible but I couldn't care less...)
    /// </summary>
    public struct Book
    {
        private int _isbn;
        private string _title;
        private string _author;

        /// <summary>
        /// Book's ISBN. Cannot be negative
        /// </summary>
        public int ISBN
        {
            get => _isbn;
            init
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _isbn = value;
            }
        }

        /// <summary>
        /// Book's title. Cannot be null.
        /// </summary>
        public string Title
        {
            get => _title;
            init
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _title = value;
            }
        }

        /// <summary>
        /// Name of the author of the book. Cannot be null.
        /// </summary>
        public string Author
        {
            get => _author;
            init
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _author = value;
            }
        }

        /// <summary>
        /// Year of the release.
        /// </summary>
        public int Year { get; init; }

        public static bool operator ==(Book one, Book two)
        {
            return one.ISBN == two.ISBN;
        }

        public static bool operator !=(Book one, Book two)
        {
            return one.ISBN != two.ISBN;
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Book && (Book)obj == this;
        }

        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode();
        }

        public override string ToString()
        {
            return this.ISBN + ";" + this.Title + ";" + this.Author + ";" + this.Year;
        }
    }
}
