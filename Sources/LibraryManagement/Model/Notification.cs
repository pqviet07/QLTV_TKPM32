using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Notification
    {
        public int Id { get; set; }
        [Required]
        public string NotifyContent { get; set; }
        public Notification()
        {
            this.Accounts = new HashSet<Account>();
        }
        public ICollection<Account> Accounts { get; set; }
    }
}
