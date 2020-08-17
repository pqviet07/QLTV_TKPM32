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
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string BookName { get; set; }
        public BookType BookType { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Language { get; set; }
        public int NumsOfPages { get; set; }
        
    }
}
