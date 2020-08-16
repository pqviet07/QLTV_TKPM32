using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Catalog : ISearch
    {
        public Dictionary<string, List<Book>> booksSearchedByBookType { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByAuthor { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByBookName { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByISBN { get; set; }
        public Dictionary<DateTime, List<Book>> booksSearchedByDateAddToLibrary { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByBookFormat { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByReferenceOnlyBook { get; set; }

        public List<Book> searchByAuthor(string authorName)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookFormat(BookFormat bookFormat)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookName(string bookName)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookType(BookType bookType)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByDateAddToLibrary(DateTime datetime)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByISBN(string ISBN)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByReferenceOnlyBook(bool isRefOnly)
        {
            throw new NotImplementedException();
        }
    }
}
