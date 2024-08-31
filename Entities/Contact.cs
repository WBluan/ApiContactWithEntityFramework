using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Contact
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string  Phone { get; set; }
        public bool Active { get; set; }
    }
}