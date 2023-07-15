using Dummy;

namespace OOP_Basics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new()
            { 
                FirstName = "Jan",
                LastName = "Kowalski",
                YearOfBirth = 1980
            };
            //Person p2 = new Employee("Jan", "Kowalski", 1980, 5000);
            Employee e = new Employee("Anna", "Nowak", 1990, 6500);
            Manager m = new Manager("Tomasz", "Kwiatkowski", 1970, 6500);
            SayHello(e);
            e.FirstName = "a";

            List<Employee> list = new List<Employee>();
            list.Add(e);
            list.Add(m);

            foreach(var worker  in list)
            {
                Console.WriteLine(worker);
            }

            
            
        }

        internal static void SayHello(Person p)
        {
            Console.WriteLine($"Hello {p.WhoAmI()}");
        }


    }
}