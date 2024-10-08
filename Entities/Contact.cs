using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Api.Entities
{
    // Representa uma classe para ser manipulada pela Api e ao mesmo tempo represeta uma tabela no bando de dados.
    public class Contact
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string  Phone { get; set; }
        public bool Active { get; set; }
    }
}