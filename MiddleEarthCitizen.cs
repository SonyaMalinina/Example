using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MiddleEarthCitizen
    {

        private int power;
        private string name;
            
            public MiddleEarthCitizen(int Power, string Name)
            {
                power = Power;
                name = Name;
        }

        public int Power {
            get { return power; }
            set { power = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name + " " + power;
        }


    }

    
}
