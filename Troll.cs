using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Troll : MiddleEarthCitizen
    {
        public Troll(int Power, string Name): base(Power, Name)
        {
                if ((Power >= 15) && (Power <= 11)) 

                    throw new Exception("Ошибка силы");
            
        }
    }
}
