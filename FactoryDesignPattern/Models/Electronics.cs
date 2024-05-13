using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Models
{
    internal class Electronics : Product
    {
        public Electronics(string name, decimal price) : base(name, price)
        {
                
        }
    }
}
