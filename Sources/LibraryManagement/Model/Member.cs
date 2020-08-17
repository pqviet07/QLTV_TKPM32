using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member : Account
    {
        public Member()
        {
            this.BookLendings = new HashSet<BookLending>();
        }
        public decimal AmountPaid { get; set; }
        public MemberType MemberType { get; set; }
        public ICollection<BookLending> BookLendings { get; set; }
    }
}
