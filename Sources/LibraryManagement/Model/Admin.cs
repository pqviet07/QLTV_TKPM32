using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Admin : Account
    {
        
        public bool AddEmployee(Employee employee) { return true; }
        public bool RemoveEmployee(string username) { return true; }
    }
}
