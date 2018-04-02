using JapaneseBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapaneseBackend.Repositories
{
    public interface IBookRepository
    {
        Book BookByIsbn(string isbn);
        IEnumerable<Book> AllBooks();
    }
}
