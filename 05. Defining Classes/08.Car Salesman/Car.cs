using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        private Engine engine;
        private string model;
        private string weight;
        private string color;

        public Car(Engine engine, string model)
        {
            this.Engine = engine;
            this.Model = model;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(Engine engine, string model, string weight) : this(engine,model)
        {
            this.Weight = weight;

        }
        public Car(Engine engine,
            string model,
            string weight,
            string color)
            : this(engine,model,weight)
        {
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }



        public string Model
        {
            get { return model; }
            set { model = value; }
        }



        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }



    }
}
