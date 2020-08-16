using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BookReturning
    {
        public int Id { get; set; }
        [Required]
        public string Barcode { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public decimal Fine { get; set; }
        [Required]
        public ReturningStatus Status { get; set; }
        public string Note { get; set; }
    }
}
