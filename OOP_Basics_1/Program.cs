namespace OOP_Basics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jan", "Kowalski", 1980);
            //Person p2 = new Employee("Jan", "Kowalski", 1980, 5000);
            Employee e = new Employee("Anna", "Nowak", 1990, 6500);
            SayHello(p);
            
            List<Person> list = new List<Person>();
            list.Add(p);
            list.Add(e);

            foreach(var worker  in list)
            {
                var casted = worker as Employee;
                if (casted != null)
                {

                }
                if(worker is Employee) 
                {
                    Employee employee = (Employee) worker;
                    Console.WriteLine(employee.WhoAmIWithSalary());
                }
                else
                    Console.WriteLine(worker.WhoAmI());
            }

            
            
        }

        static void SayHello(Person p)
        {
            Console.WriteLine($"Hello {p.WhoAmI()}");
        }
    }
}