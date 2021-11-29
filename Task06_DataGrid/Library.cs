using System.Text;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Library
    {
        /// <summary>
        /// Collection of books owned by library.
        /// </summary>
        public List<LibraryItem> Books { get; private set; }

        /// <summary>
        /// Adds a new book to the library's collection.
        /// If the book is already owned by the library increases the number of total and available copies of the book.
        /// </summary>
        public void AddBook(LibraryItem book)
        {
            for (int i = 0; i < Books.Count; ++i)
            {
                if (Books[i].Book == book.Book)
                {
                    Books[i].Total += book.Total;
                    Books[i].Available += book.Available;
                    return;
                }
            }
            Books.Add(book);
        }

        private Library(List<LibraryItem> books)
        {
            Books = books;
        }

        /// <summary>
        /// Creates a new library with random set of books in collection.
        /// </summary>
        /// <param name="nBooks">Number of different books in the library.</param>
        public static Library CreateRandomLibrary(int nBooks = 100)
        {
            return Utils.CreateRandomLibrary(nBooks);
        }

        /// <summary>
        /// Reads the collection of books owned by library from csv file and creates a new library.
        /// </summary>
        /// <param name="path">Path to scv file.</param>
        public static Library ReadLibraryFromCSV(string path)
        {
            return Utils.ReadLibraryFromCSV(path);
        }

        /// <summary>
        /// Writes the collection of books owned by library to csv file.
        /// </summary>
        /// <param name="path">Path to scv file.</param>
        public void WriteLibraryToCSV(string path)
        {
            Utils.WriteLibraryToCSV(this, path);
        }

        /// <summary>
        /// Utility class with utility static methods to work with library.
        /// </summary>
        private static class Utils
        {
            private static Random _random = new Random();

            /// <summary>
            /// Creates a new library with random set of books in collection.
            /// </summary>
            /// <param name="nBooks">Number of different books in the library.</param>
            public static Library CreateRandomLibrary(int nBooks)
            {
                var books = new List<LibraryItem>(nBooks);
                for (int i = 0; i < nBooks; ++i)
                {
                    string title = GetRandomString(10);
                    var book = new Book
                    {
                        ISBN = i,
                        Author = GetRandomString(10),
                        Title = title,
                        Year = _random.Next(-1000, 2021)
                    };

                    int total = _random.Next(1, 20);
                    int available = _random.Next(1, total + 1);
                    bool toOrder = _random.NextDouble() < 0.2;
                    string link = "https://myrandomlibrary.com/" + title;
                    books.Add(new LibraryItem { Book = book, Total = total, Available = available, ToBeOrdered = toOrder, Link = link });
                }
                return new Library(books);
            }

            /// <summary>
            /// Creates a random string containg only latin letters and starts with a capital letter.
            /// </summary>
            /// <param name="length">Length of the result string</param>
            private static string GetRandomString(int length)
            {
                var result = new StringBuilder(length);
                result.Append((char)('A' + _random.Next(26)));
                for (int i = 0; i < length - 1; ++i)
                {
                    result.Append((char)('a' + _random.Next(26)));
                }
                return result.ToString();
            }

            /// <summary>
            /// Reads a books owned by library from csv-like line.
            /// </summary>
            private static LibraryItem ReadLibraryItemFromCSV(string CSVLine)
            {
                string[] data = CSVLine.Split(';');
                return new LibraryItem
                {
                    Book = new Book
                    {
                        ISBN = int.Parse(data[0]),
                        Title = data[1],
                        Author = data[2],
                        Year = int.Parse(data[3])
                    },
                    Total = int.Parse(data[4]),
                    Available = int.Parse(data[5]),
                    ToBeOrdered = bool.Parse(data[6]),
                    Link = data[7]
                };
            }

            /// <summary>
            /// Reads the collection of books owned by library from csv file and creates a new library.
            /// </summary>
            /// <param name="path">Path to scv file.</param>
            public static Library ReadLibraryFromCSV(string fileName)
            {
                // YOUR CODE HERE
                throw new NotImplementedException();
            }

            /// <summary>
            /// Writes the collection of books owned by library to csv file.
            /// </summary>
            /// <param name="path">Path to scv file.</param>
            public static void WriteLibraryToCSV(Library library, string fileName)
            {
                // YOUR CODE HERE
                throw new NotImplementedException();
            }
        }
    }
}