using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LibrarySystem
    {
        public List<Account> listAccounts { get; set; }
        public void attach(Account account)
        {
            listAccounts.Add(account);
        }
        public void notifyAllAccount()
        {

        }
        public void notifyFine()
        {

        }
        public void notifyDueDateLibCard()
        {

        }
        public void notifyDueDateReturnBook()
        {

        }
    }
}
