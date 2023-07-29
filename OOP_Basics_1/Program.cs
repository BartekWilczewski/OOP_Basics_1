

namespace OOP_Basics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Mruczek");
            var dog = new Dog("Azor");
            var g = new Guitar();

            var sounds = new List<SoundMaker>();
            sounds.Add(dog);
            sounds.Add(cat);
            sounds.Add(g);

            RecordSound(sounds);
        }

        static void RecordSound(List<SoundMaker> sounds)
        {
            foreach (var animal in sounds)
            {
                animal.MakeSound();
            }
        }
    }
}