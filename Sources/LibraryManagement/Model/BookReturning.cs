using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class BookReturning
    {
        [ForeignKey("BookLending")]
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
        public int BookLendingId { get; set; }
        public BookLending BookLending {get; set;}

        public string Note { get; set; }
    }
}
