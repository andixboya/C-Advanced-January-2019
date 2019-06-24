using System;
using System.Collections.Generic;
using System.Linq;

namespace P07TheVlogger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, HashSet<string>> vloggerToHisFollowers = new Dictionary<string, HashSet<string>> { };

            Dictionary<string, HashSet<string>> followerToHisVloggers = new Dictionary<string, HashSet<string>> { };

            while (input != "Statistics")
            {
                string[] partitions = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = partitions[1];


                switch (command)
                {

                    case "joined":
                        string vlogger = partitions[0];

                        if (!vloggerToHisFollowers.ContainsKey(vlogger))
                        {
                            vloggerToHisFollowers.Add(vlogger, new HashSet<string> { });
                            followerToHisVloggers.Add(vlogger, new HashSet<string>{ });
                        }

                        break;

                    case "followed":

                        vlogger = partitions[2];
                        string follower = partitions[0];

                        if (follower!=vlogger)
                        {

                            if (vloggerToHisFollowers.ContainsKey(vlogger) && followerToHisVloggers.ContainsKey(follower))
                            {
                                // follow him
                                vloggerToHisFollowers[vlogger].Add(follower);

                                followerToHisVloggers[follower].Add(vlogger);

                            }

                        }


                        //otherwise do nothing
                        break;

                }

                input = Console.ReadLine();
            }

            int totalAmountOfVloggers = vloggerToHisFollowers.Keys.Count;

            Console.WriteLine($"The V-Logger has a total of {totalAmountOfVloggers} vloggers in its logs.");

            int counter = 0;

            foreach (var vlogger in vloggerToHisFollowers
                .OrderByDescending(v => v.Value.Count)
                .ThenBy(v => followerToHisVloggers[v.Key].Count))
            {
                counter++;

                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Count} followers, {followerToHisVloggers[vlogger.Key].Count} following");

                if (counter==1)
                {
                    if (vlogger.Value.Count > 0)
                    {
                        foreach (var follower in vlogger.Value.OrderBy(f => f))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }

                }

            }

        }
    }
}
