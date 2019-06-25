using System;
using System.Collections.Generic;
using System.Linq;

namespace P11PartyReservationFilterMod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            string input = Console.ReadLine();


            List<Func<string, string, bool>> FuncsToImplement = new List<Func<string, string, bool>> { };

            List<string> parameters = new List<string> { };
            while (input!="Print")
            {

                string[] partitions = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string addOrRemove = partitions[0];
                string firstCommand = partitions[1];
                string parameter = partitions[2];

                var currentFunc = GetFunc(firstCommand, parameter);

                if (addOrRemove=="Add filter")
                {
                    FuncsToImplement.Add(currentFunc);
                    parameters.Add(parameter);
                }
                else
                {
                    if (FuncsToImplement.Contains(currentFunc))
                    {
                        FuncsToImplement.Remove(currentFunc);
                        parameters.Remove(parameter);
                    }
                    
                }

                input = Console.ReadLine();
            }


            for (int i = 0; i < FuncsToImplement.Count; i++)
            {
                names = names.Where(x=> !FuncsToImplement[i](x,parameters[i])).ToArray();
            }

            Print(names);
        }


        public static Func<string,string,bool> GetFunc(string firstCommand, string parameter)
            //word, what it does, parameter
        {
            if (firstCommand=="Starts with")
            {
                return (x, y) => x.StartsWith(y);
            }
            else if (firstCommand=="Ends with")
            {
                return (x, y) => x.EndsWith(y);
            }
            else if (firstCommand=="Length")
            {
                return (x, y) => x.Length == int.Parse(y);
            }
            else //firstCommand=="Contains"
            {
                return (x, y) => x.Contains(y);
            }


        }

        public static Action<string[]> Print = x => Console.WriteLine(string.Join(" ", x)); 
    }
}
