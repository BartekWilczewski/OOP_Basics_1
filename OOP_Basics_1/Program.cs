

namespace OOP_Basics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Mruczek");
            var dog = new Dog("Azor");
            var g = new Guitar();


            var sounds = new List<ISoundMaker>();
            sounds.Add(dog);
            sounds.Add(cat);
            sounds.Add(g);

            RecordSound(sounds);
        }

        static void RecordSound(List<ISoundMaker> sounds)
        {
            foreach (var s in sounds)
            {
                s.MakeSound();
            }
        }
    }
}