using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Author
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public ICollection<BookDummy> BookDummys { get; set; }
        public Author()
        {
            BookDummys = new HashSet<BookDummy>();
        }
    }
}
