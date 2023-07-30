using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Basket
    {
        public List<Product> ProductsList = new List<Product>();
        
        public double CalculateBasket() 
        { 
        double basketSum = 0;
            foreach (Product p in ProductsList)
            {
                basketSum += p.Price;
            }
            return basketSum;
        }
    }
}
