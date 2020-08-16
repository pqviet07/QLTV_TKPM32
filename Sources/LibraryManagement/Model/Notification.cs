using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Notification
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public Notification()
        {
            this.Accounts = new HashSet<Account>();
        }
        public ICollection<Account> Accounts { get; set; }
    }
}
