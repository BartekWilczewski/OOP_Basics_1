using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal abstract class Product
    {
        public readonly double Price;
        public abstract double Weight { get; }

        protected Product(double price)
        {
            Price = price;
        }
    }
    
}
