using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string[] line1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var firstName = line1[0];
            var secondName = line1[1];
            var fullName = firstName + " " + secondName;
            var address = line1[2];

            var tuppleOne = new TuppleClass<string,string>(fullName, address);

            string[] line2 = Console.ReadLine()
                .Split(" ");
            string name = line2[0];
            int litersConsumed = int.Parse(line2[1]);

            var tuppleTwo = new TuppleClass<string, int>(name, litersConsumed);

            string [] lineThree = Console.ReadLine()
                .Split(" ");

            int intNumber = int.Parse(lineThree[0]);
            double doubleNumber = double.Parse(lineThree[1]);

            var tuppleThree = new TuppleClass<int, double>(intNumber, doubleNumber);


            Console.WriteLine(tuppleOne);
            Console.WriteLine(tuppleTwo);
            Console.WriteLine(tuppleThree);

        }
    }
}
