using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonalInfo
    {
        [ForeignKey("Account")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Account Account { get; set; }
    }
}
