using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface ISearch
    {
        List<Book> searchByAuthor(string authorName);
        List<Book> searchByBookName(string bookName);
        List<Book> searchByBookType(BookType bookType);
        List<Book> searchByISBN(string ISBN);
        List<Book> searchByDateAddToLibrary(DateTime datetime);
        List<Book> searchByReferenceOnlyBook(bool isRefOnly);
        List<Book> searchByBookFormat(BookFormat bookFormat);

    }
}
