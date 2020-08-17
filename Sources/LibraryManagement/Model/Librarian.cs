using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Librarian : Employee
    {
        
        public bool CreateBookLending() { return true; }
        public bool CreateBookReturning() { return true; }
        public bool AddMember(string username, MemberType memType) { return true; }
        public bool RenewLibraryCard(string username, MemberType memType) { return true; }
        public bool BlockMember(string libCardID) { return true; }
        public bool UnblockMember(string libCardID) { return true; }
    }
}
