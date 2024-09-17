namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>()
            {
                new Person { FName = "Vo3", LName = "Kiet", Age = 21 },
                new Person { FName = "Vo5", LName = "Minh", Age = 1 },
                new Person { FName = "Vo1", LName = "Kiet", Age = 21 },
                new Person { FName = "Vo2", LName = "Minh", Age = 1 },
            };

            Console.WriteLine("Items in list: {0}", list.Count);
            foreach (Person p in GetEnumerable(list))
            {
                Console.WriteLine(p);
            }

            SortedSet<Person> sorted = new SortedSet<Person>()
            {
                new Person { FName = "Vo3", LName = "Kiet", Age = 4 },
                new Person { FName = "Vo5", LName = "Minh", Age = 6 },
                new Person { FName = "Vo1", LName = "Kiet", Age = 5 },
                new Person { FName = "Vo2", LName = "Minh", Age = 1 },
            };

            Console.WriteLine("Items in sorted set: {0}", sorted.Count);
            foreach (Person p in GetEnumerable(sorted))
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }

        // Method returning IEnumerable<T>
        static IEnumerable<Person> GetEnumerable(IEnumerable<Person> collection)
        {
        
            foreach (var item in collection)
            {
                yield return item;
            }
        }
    }
}