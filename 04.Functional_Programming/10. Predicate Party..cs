using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ExercisesPredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> peopleThatAreComing = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            string line = Console.ReadLine();

            while (line != "Party!")
            {

                string[] partitions = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string command = partitions[0];
                string condition = partitions[1];
                string letter = partitions[2];


                switch (command)
                {
                    case "Remove":

                        for (int i = 0; i < peopleThatAreComing.Count; i++)
                        {
                            if (ValidatorForRemovalOrAddition(peopleThatAreComing[i],condition,letter))
                            {
                                peopleThatAreComing[i] = "-1";
                            }

                        }

                        peopleThatAreComing.RemoveAll(x => x == "-1");

                        break;

                    case "Double":

                        for (int i = 0; i < peopleThatAreComing.Count; i++)
                        {
                            if (ValidatorForRemovalOrAddition(peopleThatAreComing[i],condition,letter))
                            {
                                peopleThatAreComing.Insert(i, peopleThatAreComing[i]);
                                i++; // i think i should be +1 , because it would go into forloop?
                            }
                            
                        }

                        break;
                }
                line = Console.ReadLine();
            }


            if (peopleThatAreComing.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine("{0} are going to the party!",
                string.Join(", ", peopleThatAreComing));
            }


        }

      //  public static Func<string[], string, string, bool> Validator = (members, criteria, parameter) =>
      //{


      //    return false;
      //};

        public static bool ValidatorForRemovalOrAddition(string person, string criteria, string parameter)

        {
            // here we insert the 3 possible outcomes switch{length/starts/ends} 

            if (criteria=="StartsWith")
            {
                if (person.StartsWith(parameter))
                {
                    return true;
                }

                return false;
            }

            else if (criteria=="EndsWith")
            {

                if (person.EndsWith(parameter))
                {
                    return true;
                }
                return false;
            }

            else // criteria== Length
            {
                int countOfLength = int.Parse(parameter);
                if (person.Length == countOfLength)
                {
                    return true;
                }

                return false;
            }

        }
      
    }
}
