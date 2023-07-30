using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class ComplexNumbers : IComparable<ComplexNumbers>
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumbers(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        //public int CompareTo(ComplexNumbers? other)
        //{

        //    // return this.Imaginary.CompareTo(other.Imaginary);
        //    if (this.Imaginary != other.Imaginary)
        //        return this.Imaginary.CompareTo(other.Imaginary);
        //    return this.Real.CompareTo(other.Real);
        //}
        public int CompareTo(ComplexNumbers? other)
        {

            // return this.Imaginary.CompareTo(other.Imaginary);
            if (this.Imaginary != other.Imaginary)
                return this.Imaginary.CompareTo(other.Imaginary) * -1;
            return this.Real.CompareTo(other.Real) * -1;
        }



        public override string ToString()
        {
            return $"Real: {Real}, imaginary {Imaginary}";
        }
    }
}
