using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        private Tires tires;
        private Engine engine;
        private Cargo cargo;
        private string model;

        public Car(string model,
            int engSpeed,
            int engPower,
            int cargoWeight,
            string cargoType,
            double[] tyresInfo)
        {
            this.Engine = new Engine(engSpeed, engPower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Model = model;
            //this.Engine.Power = engPower;
            //this.Engine.Speed = engSpeed;
            //this.Cargo.Weight = cargoWeight;
            //this.cargo.Type = cargoType;

            this.Tires = new Tires { }; // this i was missing!
            //it should be outside the for, because it is rewriting the old list!

            for (int i = 0; i < tyresInfo.Length; i+=2)
            {
                

                double currentTirePressure = tyresInfo[i];
                double currentTireAge = tyresInfo[i+1];

                Tire tire = new Tire(currentTirePressure, currentTireAge);

                
                this.Tires.TiresSet.Add(tire);
            }

        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }



        public Tires Tires
        {
            get { return tires; }
            set { tires = value; }
        }


    }
}
