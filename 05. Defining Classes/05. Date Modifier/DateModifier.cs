using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(DateTime first, DateTime second)
        {
            this.firstDate = first;
            this.secondDate = second;

        }

        public DateTime FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }


        

        public DateTime SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }

        public int CalculateDays()
        {
            var result= this.firstDate.Subtract(secondDate);

            return result.Days;

        }




    }
}
