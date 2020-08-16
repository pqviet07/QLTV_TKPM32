using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LibraryCard
    {
        [ForeignKey("Account")]
        public int Id { get; set; }
        public string LibCardNumber { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public bool Active { get; set; }
        public Account Account { get; set; }
        public bool isActive()
        {
            return Active;
        }
    }
}
