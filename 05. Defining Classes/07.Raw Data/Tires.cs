using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tires
    {

        private List<Tire> tiresSet;

        public Tires()
        {
            tiresSet = new List<Tire> { };
        }

        public List<Tire> TiresSet
        {
            get { return tiresSet; }
            set { tiresSet = value; }
        }

    }
}
