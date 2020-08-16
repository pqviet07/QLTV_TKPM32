using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    class BookReturning
    {
        public int Id { get; set; }
        [Required]
        public string Barcode { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? Duration { get; set; }
        public decimal? Fine { get; set; }
        [Required]
        public ReturningStatus Status { get; set; }
        public string Note { get; set; }
    }
}
