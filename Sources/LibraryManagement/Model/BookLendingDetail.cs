using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BookLendingDetail
    {
        public int Id { get; set; }
        [Required]
        public string Barcode { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public int BookLendingId { get; set; }
        public BookLending BookLending { get; set; }
    }
}
