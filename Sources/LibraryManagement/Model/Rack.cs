using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Rack
    {
        public Rack()
        {
            BookItems = new HashSet<BookItem>();
        }
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public char Block { get; set; }
        public ICollection<BookItem> BookItems { get; set; }
    }
}
