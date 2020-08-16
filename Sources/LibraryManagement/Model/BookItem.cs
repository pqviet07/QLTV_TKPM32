using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BookItem : Book
    {
        public int Id { get; set;}
        [Required]
        public string Barcode { get; set; }
        [Required]
        public bool IsReferenceOnly { get; set; }
        [Required]
        public bool IsBorrowed { get; set; }
        [Required]
        public BookFormat Format { get; set; }
        [Required]
        public BookStatus Status { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public bool Checkout()
        {
            return true;
        }
    }
}
