using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas8.Models
{
    public class Book
    {
        public string Pavadinimas { get; set; }
        public bool bIsRented { get; set; }

        public Book(string pavadinimas, bool bRented)
        {
            Pavadinimas = pavadinimas;
            bIsRented = bRented;
        }

        public override string ToString()
        {
            if(bIsRented)
                return $"Book {Pavadinimas} is rented";
            return $"Book {Pavadinimas} is not rented";
        }
    }
}
