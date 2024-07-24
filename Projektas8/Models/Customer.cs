using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas8.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
