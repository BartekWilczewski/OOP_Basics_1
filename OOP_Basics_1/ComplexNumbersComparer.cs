using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class ComplexNumbersComparer : IComparer<ComplexNumbers>
    {
        public int Compare(ComplexNumbers? x, ComplexNumbers? y)
        {
            return x.Real.CompareTo(y.Real) * -1;
        }
    }
}
