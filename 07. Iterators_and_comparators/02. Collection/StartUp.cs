using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {



            string input = Console.ReadLine();

            var collection = new ListyIterator<string>();

            while (input!="END")
            {

                string[] partitions = input
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = partitions[0];
                try
                {

                    switch (command)
                    {

                        case "Create":
                            
                            string[] items = partitions.Skip(1).ToArray();

                            collection = new ListyIterator<string>(items);

                            break;

                        case "Move":
                            bool result = collection.Move();

                            Console.WriteLine(result);

                            break;
                        case "HasNext":
                            result = collection.HasNext();
                            Console.WriteLine(result);
                            break;

                        case "Print":
                            collection.Print();
                            break;
                        case "PrintAll":
                            collection.PrintAll();
                            break;

                    }
                }

                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }


        }
    }
}
