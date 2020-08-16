using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fine
    {
        public int Id { get; set; }
        public decimal fineWhenLateReturningBook { get; set; }
        public decimal numsOfTimesWillMultiplyWithBookPricing_WhenBookLost { get; set; }
        public decimal numsOfTimesWillMultiplyWithBookPricing_WhenBookTorned { get; set; }
        public decimal AmountPaidForRemakeLibCard { get; set; }
    }
}
