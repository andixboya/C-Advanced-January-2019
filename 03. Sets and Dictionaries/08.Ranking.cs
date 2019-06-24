using System;
using System.Collections.Generic;
using System.Linq;

namespace P08Rankings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> contestToPassword = new Dictionary<string, string> { };


            Dictionary<string, Dictionary<string, int>> personToContestToPoints = new Dictionary<string, Dictionary<string, int>> { };

            Dictionary<string, int> personToPoints = new Dictionary<string, int> { };


            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] partitions = input.Split(":");
                string contest = partitions[0];
                string password = partitions[1];

                if (!contestToPassword.ContainsKey(contest))
                {
                    contestToPassword.Add(contest, password);
                }

                // just in case the password is rewritten?
                else
                {
                    contestToPassword[contest] = password;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();


            while (input != "end of submissions")
            {
                string[] partitions = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = partitions[0];
                string password = partitions[1];
                string participant = partitions[2];
                int points = int.Parse(partitions[3]);



                //in case the contest exists, and the password matches we add the points to the person (with the contet), if we match the contest second, it will break!
                if (contestToPassword.ContainsKey(contest) && contestToPassword[contest] == password)
                {
                    if (!personToContestToPoints.ContainsKey(participant))
                    {
                        personToContestToPoints.Add(participant, new Dictionary<string, int> { });
                        personToPoints.Add(participant, 0);
                        //fist mistake here=> (it was below )
                    }

                    if (!personToContestToPoints[participant].ContainsKey(contest))
                    {
                        personToContestToPoints[participant].Add(contest, points);
                        

                    }

                    else
                    {
                        if (personToContestToPoints[participant][contest] < points)
                        {
                            personToContestToPoints[participant][contest] = points;

                        }
                    }

                }


                input = Console.ReadLine();
            }

            CountPointsOfEverybody(personToContestToPoints, personToPoints);

            var firstStudent = personToContestToPoints.OrderByDescending(p => personToPoints[p.Key]).First();

            Console.WriteLine($"Best candidate is {firstStudent.Key} with total {personToPoints[firstStudent.Key]} points.");

            

            Console.WriteLine("Ranking:");
            foreach (var kvp in personToContestToPoints.OrderBy(p=> p.Key))
            {

                Console.WriteLine($"{kvp.Key}");

                foreach (var secondKvp in kvp.Value.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"#  {secondKvp.Key} -> {secondKvp.Value}");
                }

            }

        }

        private static void CountPointsOfEverybody(Dictionary<string, Dictionary<string, int>> personToContestToPoints, Dictionary<string, int> personToPoints)
        {
            foreach (var kvp in personToContestToPoints)
            {
                string currentContestant = kvp.Key;

                foreach (var item in kvp.Value)
                {
                    personToPoints[currentContestant] += item.Value;
                }

            }
        }
    }
}
