using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Rack
    {
        public int Id { get; set; }
        [Required]
        public int number { get; set; }
        [Required]
        public char block { get; set; }
    }
}
