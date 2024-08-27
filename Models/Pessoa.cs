using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.Models
{
    public class Pessoa(string name, string lastName)
    {
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
    }
}