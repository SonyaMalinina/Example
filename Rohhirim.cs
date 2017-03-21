using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rohhirim :Human
    {
        public void FirstStrike() { }
        private Horse horse { get; set; }
        public Rohhirim(int Power, string Name, Horse h): base(Power, Name)
        {  
            horse = h;
            this.Power = this.Power + h.power1;
        }
         
    }
}
