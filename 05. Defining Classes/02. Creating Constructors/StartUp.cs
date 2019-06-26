using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public  class StartUp
    {
        static void Main(string[] args)
        {


            List<string> dates = new List<string> { };

            for (int i = 0; i < 2; i++)
            {
                string line = Console.ReadLine();
                dates.Add(line);

            }

            var result = DateModifier.Modify(dates[0], dates[1]);


            Console.WriteLine(result);



            //return; 

            //int n = int.Parse(Console.ReadLine());
            //Family family = new Family { };

            //for (int i = 0; i < n; i++)
            //{
            //    string[] partitions = Console.ReadLine().Split();
            //    string name = partitions[0];
            //    int age = int.Parse(partitions[1]);

            //    Person currentPerson = new Person(age, name);
            //    family.AddMember(currentPerson);
            //}

            //Person oldestPerson = family.GetOldestMember(family);

            //foreach (var Person in family
            //    .Members
            //    .Where(m=> m.Age>30)
            //    .OrderBy(m=> m.Name))
            //{

            //    Console.WriteLine("{0} - {1}",
            //        Person.Name,
            //        Person.Age);    
            //}

        }


    }
}
