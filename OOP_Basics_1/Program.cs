

using System.Security.Cryptography.X509Certificates;

namespace OOP_Basics_1
{
    internal class Program
    {
        public static string PrintPlayers { get; private set; }

        static void Main(string[] args)
        {
            //var cat = new Cat("Mruczek", 7);
            //var dog = new Dog("Azor", 4);
            //var dog2 = new Dog("Alf", 2);


            //var sounds = new List<Animal>();
            //sounds.Add(dog);
            //sounds.Add(cat);
            //sounds.Add(dog2);
            //sounds.Sort(new AnimalAgeComparer());

            //foreach (var sound in sounds)
            //{
            //    sound.MakeSound();
            //} 

            var MyList = new List<ComplexNumbers>() 
            {
                new ComplexNumbers(2, 3.5),
                new ComplexNumbers(5.4, 8),
                new ComplexNumbers(-2, 14),
                new ComplexNumbers(3, -8),
                new ComplexNumbers(3, -10),
                new ComplexNumbers(2, -8),
                new ComplexNumbers(2, -8)

            };

            //MyList.Sort(new ComplexNumbersComparer());
            //foreach (var item in MyList)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            Display.Print(PrintPlayers);
        }
    }
}