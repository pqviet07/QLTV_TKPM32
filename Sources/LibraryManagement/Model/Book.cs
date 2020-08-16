using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public abstract class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }
        public int Id { get; set; } 
        [Required]
        string ISBN { get; set; }
        [Required]
        string BookName { get; set; }
        
        public ICollection<Author> Authors { get; set; }
        [Required]
        BookType BookType { get; set; }
        string Publisher { get; set; }
        string Language { get; set; }
        int? NumsOfPages { get; set; }    
    }
}
