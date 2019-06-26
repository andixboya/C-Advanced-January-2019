using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {

        private string model;
        private double power;
        private string  displacement;
        private string efficiency;

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, double power ,string displacement ) : this(model, power)
        {
            this.Displacement = displacement;

        }
        public Engine(string model, double power, string displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Displacement

        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

       


    }
}
