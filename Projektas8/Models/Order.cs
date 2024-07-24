using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projektas8.Models
{
    public class Order
    {
        public Customer Client { get; set; }
        public List<ProductGroup> Products { get; set; }

        public Order(string name, string surname)
        {
            Client = new Customer(name, surname);
            Products = new List<ProductGroup>();
        }

        public void AddProduct(Product product, int amount)
        {
            Products.Add(new ProductGroup(product, amount));
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0.00;

            foreach (ProductGroup product in Products)
                totalPrice += product.Item.Price * Convert.ToDouble(product.Amount);
            return Math.Round(totalPrice, 2);
        }

        public override string ToString()
        {
            string description = "";

            foreach (ProductGroup product in Products)
                description += $"{product.Item.Name}: {product.Amount}\n";

            return description += $"Total price of this order: {GetTotalPrice()} Eur\n";
        }
    }
}
