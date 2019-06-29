using System;
using System.Collections.Generic;

namespace ComparinObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {

                string[] partitions = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = partitions[0];
                int age = int.Parse(partitions[1]);
                string town = partitions[1];

                var Person = new Person(name, age, town);
                people.Add(Person);

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine())-1;

            var personCondition = people[index];

            int matches = 0;
            int mismatches = 0;

            foreach (var p in people)
            {
                if (p.CompareTo(personCondition) == 0)
                {
                    matches++;
                }
                else
                {
                    mismatches++;
                }

            }

            string result = string.Empty;

            if (matches == 1)
            {
                result = "No matches";
            }

            else
            {
                result = $"{matches} {mismatches} {matches + mismatches}";
            }

            PrintResults(result);


        }

        private static void PrintResults(string result)
        {
            Console.WriteLine(result);
        }
    }
}
