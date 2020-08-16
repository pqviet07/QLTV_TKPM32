using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Stockkeeper : Employee
    {
        public bool addBookItem(BookItem book) { return true; }
        public bool updateBookItem(BookItem book) { return true; }
        public bool removeBookItem(string barcode) { return true; }
    }
}
