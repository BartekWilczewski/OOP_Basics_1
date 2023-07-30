using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Milk : Product
    {
        private const double Density = 1.03;

        public Milk(double price, double capacity) : base(price)
        {
            Capacity = capacity;
        }

        public readonly double Capacity;

        public override double Weight => Capacity * Density;

    }
}
