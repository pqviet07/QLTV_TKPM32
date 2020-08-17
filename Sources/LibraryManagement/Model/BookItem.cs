using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("BookItems")]
    public class BookItem : Book
    {
        public string Barcode { get; set; }
        public bool IsReferenceOnly { get; set; }
        public bool IsBorrowed { get; set; }
        public BookFormat Format { get; set; }
        public BookStatus Status { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int RackId { get; set; }
        public Rack Rack { get; set; }
        public int BookDummyId { get; set; }
        public BookDummy BookDummy { get; set; }
        public bool Checkout()
        {
            return true;
        }
    }
}
