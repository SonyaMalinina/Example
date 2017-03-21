using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Human : MiddleEarthCitizen
    {
        public Human(int Power, string Name): base(Power, Name)
        {
                if ((Power >= 8) && (Power <= 7)) 
                //{ base.Power = Power; }
                { throw new Exception("Ошибка силы"); }
        }
    }
}
