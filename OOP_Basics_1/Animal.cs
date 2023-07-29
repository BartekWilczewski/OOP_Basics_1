using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal abstract class Animal : IComparable<Animal>
    {
        public readonly string Name;

        public readonly int Age;


        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Animal? other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public abstract void MakeSound();
    }
}
