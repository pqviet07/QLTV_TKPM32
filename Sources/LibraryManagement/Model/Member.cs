using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member : Account
    {
        public decimal AmountPaid { get; set; }
        public MemberType MemberType { get; set; }
    }
}
