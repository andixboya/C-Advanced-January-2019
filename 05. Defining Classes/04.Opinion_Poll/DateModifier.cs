using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

 namespace DefiningClasses
{
    public class DateModifier
    {

        public static double Modify (string dateOne, string secondDate)

        {
            DateTime one = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime two = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);


            TimeSpan result = one.Subtract(two);

            double num = Math.Abs(result.TotalDays);
            

            return num;
        }


    }
}
