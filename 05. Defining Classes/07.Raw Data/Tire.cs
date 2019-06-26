using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {

        private double pressure;
        private double age;

        public Tire(double pressure, double age)
        {
            this.Pressure = pressure;
            this.Age = age;

        }

        public double Age
        {
            get { return age; }
            set { age = value; }
        }


        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }


    }
}
