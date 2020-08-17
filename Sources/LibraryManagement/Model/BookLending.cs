using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BookLending
    {
        public BookLending()
        {
            BookLendingDetails = new HashSet<BookLendingDetail>();
        }
        public int Id { get; set; }
        [Required]
        public string LibCardNumber { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        public ICollection<BookLendingDetail> BookLendingDetails { get; set; }
        public BookReturning BookReturning { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
        
    }
}
