using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Wizard : MiddleEarthCitizen
    {
        public void FirstStrike() { }
        private Horse horse { get; set; }

      //  public int power { get { return this.power; } set { power = value; } }



    public Wizard(int Power, string Name, Horse h): base(Power, Name)
        {
                if ((Power!=20))
            {
                    throw new Exception("Ошибка силы");
            }
            this.Power = this.Power + h.power1;
            horse = h;

        }
    }
}
