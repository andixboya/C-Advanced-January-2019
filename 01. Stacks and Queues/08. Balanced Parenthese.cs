using System;
using System.Collections;
using System.Collections.Generic;

namespace P08BalancedParenthese
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Stack<char> openSymbols = new Stack<char> { };


            bool isBalanced = false;

            // in case opensymbols is 0 , then it is balanced!

            if (string.IsNullOrEmpty(input) )
            {
                Console.WriteLine("NO");
                return;
            }

            if (input[0] != '{' && input[0] != '[' && input[0] != '(')
            {
                Console.WriteLine("NO");
                return;
            }

            List<char> closedSymbols = new List<char> { };

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol=='{'|| currentSymbol == '['|| currentSymbol == '(')
                {
                     openSymbols.Push(input[i]);
                }

                else
                {

                    if (openSymbols.Count!=0)
                    {
                        char lastSymbol = openSymbols.Pop();

                        isBalanced = CheckForMatch(lastSymbol, currentSymbol);

                        if (isBalanced == false)
                        {
                            break;
                        }
                    }
                    else
                    {
                        closedSymbols.Add(currentSymbol);
                    }

                    
                }
            }

            if (isBalanced && openSymbols.Count==0 && closedSymbols.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        private static bool CheckForMatch(char openSymbol, char closingSymbol)
        {
            

            switch (closingSymbol)
            {
                case '}':
                    if (openSymbol=='{')
                    {
                        return true;
                    }
                    break;

                case ')':
                    if (openSymbol == '(')
                    {
                        return true;
                    }
                    break;

                case ']':
                    if (openSymbol == '[')
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }
    }
}
