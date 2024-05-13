using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Models
{
    internal class ProductFactory
    {
        public Product CreateProductObject(string type, string name, decimal price)
        {
            switch (type.ToLower())
            {
                case "electronics":
                    return new Electronics(name, price);
                case "clothings":
                    return new Clothing(name, price);
                case "furnitures":
                    return new Furniture(name, price);
                default:
                    throw new ArgumentException("Unknown Product Type");
            }
        }

    }
}
