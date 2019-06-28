using System;

namespace Tupple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Sofka Tripova Stolipinovo
            //Az 2
            //23 21.23212321

            string[] firstPerson = Console.ReadLine().Split();

            string fullName = firstPerson[0] + " " + firstPerson[1];
            string address = firstPerson[2];
            string town = firstPerson[3];

            CustomTupple<string, string,string> firstInfo = new CustomTupple<string, string,string> (fullName,address,town);


            string[] secondPerson = Console.ReadLine().Split();

            string name = secondPerson[0];
            int littersOfBeer = int.Parse(secondPerson[1]);
            bool drunkOrNot = secondPerson[2]== "drunk" ? true : false;
            CustomTupple<string, int,bool> secondInfo = new CustomTupple<string, int,bool>(name, littersOfBeer,drunkOrNot);

            string[] numbers = Console.ReadLine().Split();

            string nameTwo = numbers[0];
            double accountBallance = double.Parse(numbers[1]);
            string bankName = numbers[2];
            CustomTupple<string, double,string> thirdInfo = new CustomTupple<string, double,string>(nameTwo, accountBallance,bankName);



            Console.WriteLine(firstInfo);
            Console.WriteLine(secondInfo);
            Console.WriteLine(thirdInfo);

        }
    }
}
