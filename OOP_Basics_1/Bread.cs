using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Bread : Product
    {
        public Bread(double price) : base(price)
        {
        }

        public DateTime ExpiredDate { get; set; }

        public override double Weight 
        { 
            get 
            {
                return 1;
            } 
        }
    }
}
