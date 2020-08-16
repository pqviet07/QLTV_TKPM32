using System;
using System.Collections.Generic;

namespace Model
{
    public sealed class LibrarySystem
    {
        private LibrarySystem() { }
        private static readonly Lazy<LibrarySystem> lazy = new Lazy<LibrarySystem>(() => new LibrarySystem());
        public static LibrarySystem Instance { get { return lazy.Value; } }

        //------------------------------------------------------------
        public static List<Account> Accounts { get; set; }

        public static void attach(Account account)
        {
            Accounts.Add(account);
        }
        public static void notifyAllAccount()
        {

        }
        public static void notifyFine()
        {

        }
        public static void notifyDueDateLibCard()
        {

        }
        public static void notifyDueDateReturnBook()
        {

        }
    }
}
