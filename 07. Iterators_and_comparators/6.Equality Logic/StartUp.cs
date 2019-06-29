using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person> { };
            HashSet<Person> peopleByHash = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine().Split();

                string name = partitions[0];
                int age = int.Parse(partitions[1]);

                Person person = new Person(name, age);

                peopleByHash.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(peopleByHash.Count);
            Console.WriteLine(sortedPeople.Count);


        }
    }
}
