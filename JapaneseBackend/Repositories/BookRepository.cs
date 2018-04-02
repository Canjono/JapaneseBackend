using JapaneseBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapaneseBackend.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>();

        public BookRepository()
        {
            for (var i = 0; i < 10; i++)
            {
                var book = new Book
                {
                    Isbn = i.ToString(),
                    Name = $"Book {i}"
                };

                _books.Add(book);
            }
        }

        public Book BookByIsbn(string isbn)
        {
            return _books.Find(x => x.Isbn == isbn);
        }

        public IEnumerable<Book> AllBooks()
        {
            return _books;
        }
    }
}
