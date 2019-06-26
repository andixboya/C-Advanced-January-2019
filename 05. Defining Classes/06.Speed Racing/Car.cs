using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {

        private string model;
        private decimal fuel;
        private decimal consumptionPerKm;
        private decimal travelDistance;

        public Car()
        {
            TravelDistance = 0;
        }

        public decimal TravelDistance
        {
            get { return travelDistance; }
            set { travelDistance = value; }
        }

        public decimal ConsumptionPerKm
        {
            get { return consumptionPerKm; }
            set { consumptionPerKm = value; }
        }


        public decimal Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        
        public  bool CanMove( decimal amountOfKm)
        {
            if (this.Fuel< this.ConsumptionPerKm*amountOfKm)
            {
                return false;
            }

            return true;

        }

        public void Travel (decimal amountOfKm )
        {
            this.Fuel-= amountOfKm * this.ConsumptionPerKm;
            this.TravelDistance+= amountOfKm;
        }
    }
}
