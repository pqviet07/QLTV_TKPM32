using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ViewModel
{
    public class QltvContext : DbContext
    {
        public QltvContext() : base("name=QLTV_ConnectionString")
        {

        }
        public virtual DbSet<Account> Account { get; set; }
    }
}
