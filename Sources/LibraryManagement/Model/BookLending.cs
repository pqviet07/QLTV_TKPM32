using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BookLending
    {
        public int Id { get; set; }
        [Required]
        public string LibCardNumber { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
    }
}
