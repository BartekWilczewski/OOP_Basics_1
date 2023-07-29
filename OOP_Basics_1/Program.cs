

namespace OOP_Basics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Mruczek", 7);
            var dog = new Dog("Azor", 4);
            var dog2 = new Dog("Alf", 2);


            var sounds = new List<Animal>();
            sounds.Add(dog);
            sounds.Add(cat);
            sounds.Add(dog2);
            sounds.Sort(new AnimalAgeComparer());

            foreach (var sound in sounds)
            {
                sound.MakeSound();
            } 
        }
    }
}