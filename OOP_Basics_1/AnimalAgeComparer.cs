using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class AnimalAgeComparer : IComparer<Animal>
    {
        public int Compare(Animal? x, Animal? y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
