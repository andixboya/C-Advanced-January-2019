using System;
using System.Collections.Generic;
using System.Linq;

namespace P09SimpleTextEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> messages = new Stack<string> { };

            for (int i = 0; i < n; i++)
            {

                string[] partitions = Console.ReadLine().Split();

                string command = partitions[0];

                switch (command)
                {

                    case "1":

                        string textToAppend = partitions[1];

                        if (!messages.Any())
                        {
                            messages.Push(textToAppend);
                        }
                        else
                        {
                            messages.Push(messages.Peek() + textToAppend);
                        }
                        break;


                    case "2":


                        int countOfMessagesToDelete = int.Parse(partitions[1]);

                        if (!messages.Any())
                        {
                            continue;
                        }

                        string lastMessage = messages.Peek();

                        //probably... +1? 
                        int length = lastMessage.Length - countOfMessagesToDelete;

                        messages.Push(lastMessage.Substring(0, length));

                        break;


                    case "3":
                        if (!messages.Any())
                        {
                            continue;
                        }

                        //Check if... it gets an element or an index?
                        int indexOfText = int.Parse(partitions[1])-1;

                        string textToExtractFrom = messages.Peek();


                        //validte if the index is within the text perhaps? 
                        Console.WriteLine(textToExtractFrom[indexOfText]);

                        break;


                    case "4":

                        if (!messages.Any())
                        {
                            continue;
                        }

                        messages.Pop();
                        break;

                }
            }

        }
    }
}
