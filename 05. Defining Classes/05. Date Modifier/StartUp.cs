using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string first = Console.ReadLine();
            string second = Console.ReadLine();

            var firstDate = DateTime.Parse(first);
            var secondDate = DateTime.Parse(second);

            DateModifier modifier = new DateModifier(firstDate, secondDate);

            var result = Math.Abs( modifier.CalculateDays());

            Console.WriteLine(result);
        }
    }
}
