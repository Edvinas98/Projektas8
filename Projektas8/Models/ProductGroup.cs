using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas8.Models
{
    public class ProductGroup
    {
        public Product Item { get; set; }

        public int Amount { get; set; }

        public ProductGroup(Product item, int amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
