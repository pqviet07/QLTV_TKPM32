using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("BookDummys")]
    public class BookDummy : Book
    {
        public ICollection<BookItem> BookItems { get; set; }
        public ICollection<Author> Authors { get; set; }
        public BookDummy()
        {
            BookItems = new HashSet<BookItem>();
            Authors = new HashSet<Author>();
        }
    }
}
