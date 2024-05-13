using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Models
{
    internal class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public Product(string name, decimal price)
        {
            this.name = name;

            this.price = price;
        }

    }
}
